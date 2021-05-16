#version 430

struct SCamera
{
    vec3 Position;
    vec3 View;
    vec3 Up;
    vec3 Side;
    vec2 Scale;
};

struct SLight
{
    vec3 Position;
};

struct SRay
{
    vec3 Origin;
    vec3 Direction;
};

struct STracingRay
{
    SRay  ray;
    float contribution;
    int   depth;
};

struct SIntersection
{
    float Time;
    vec3  Point;
    vec3  Normal;
    vec3  Color;
    vec4  LightCoeffs;
    float ReflectionCoef;
    float RefractionCoef;
    int   MaterialType;
};

struct SSphere
{
    vec3  Center;
    float Radius;
};

struct STriangle
{
    vec3 v1;
    vec3 v2;
    vec3 v3;
    int  MaterialIdx;
};

const float RefractionIndex = 0.3;
const vec3 RED     = vec3( 1.0,  0.0,  0.0);
const vec3 GREEN   = vec3( 0.0,  1.0,  0.0);
const vec3 BLUE    = vec3( 0.0,  0.0,  1.0);
const vec3 YELLOW  = vec3( 1.0,  1.0,  0.0);
const vec3 WHITE   = vec3( 1.0,  1.0,  1.0);
const vec3 Zero    = vec3( 0.0,  0.0,  0.0);
const vec3 Unit    = vec3( 1.0,  1.0,  1.0);
const vec3 AxisX   = vec3( 1.0,  0.0,  0.0);
const vec3 AxisY   = vec3( 0.0,  1.0,  0.0);
const vec3 AxisZ   = vec3( 0.0,  0.0,  1.0);
const vec3 MirrorX = vec3(-1.0,  1.0,  1.0);
const vec3 MirrorY = vec3( 1.0, -1.0,  1.0);
const vec3 MirrorZ = vec3( 1.0,  1.0, -1.0);
const int DIFFUSE_REFLECTION = 1;
const int MIRROR_REFLECTION  = 2;
const int REFRACTION         = 3;

#define BIG 1000000.0
#define EPSILON 0.001 

out vec4 FragColor;
in  vec3 glPosition;
uniform SCamera uCamera;
uniform SLight uLight;
layout (binding = 2, rgba32f) uniform  imageBuffer uPoints;
layout (binding = 3, rgba32f) uniform  imageBuffer uIndexes;
layout (binding = 4, rgba32f) uniform  imageBuffer uSpheres;

struct SMaterial
{
    vec3  Color;
    vec4  LightCoeffs;
    float ReflectionCoef;
    float RefractionCoef;
    int   MaterialType;
};

uniform SMaterial uMaterials[7];

bool solveQuadratic(const float a, const float b, const float c, out float x0, out float x1)
{
    float discr = b * b - 4 * a * c;
    if (discr < 0)  return false;
    if (discr == 0) x0 = x1 = - 0.5 * b / a;
    else 
    {
        float q = (b + (b > 0 ? 1 : -1) * sqrt(discr)) / (-2);
        x0 = q / a;
        x1 = c / q;
    }
    return true;
}

bool IntersectSphere ( SSphere sphere, SRay ray, float start, float final, out float time)
{
    ray.Origin -= sphere.Center;
    float A = dot (ray.Direction, ray.Direction);
    float B = dot (ray.Direction, ray.Origin);
    float C = dot (ray.Origin,    ray.Origin) - sphere.Radius * sphere.Radius;
    float D = B * B - A * C;
    if (D <= 0.0) return false;
    D = sqrt(D);
    float t1 = (-B - D) / A;
    float t2 = (-B + D) / A;
    if (t1 < 0 && t2 < 0) return false;
    
    if (min(t1, t2) < 0) time = max(t1,t2);
    else time = min(t1, t2);
    return true;
}


bool RayTriangleIntersection(SRay ray, vec3 v1, vec3 v2, vec3 v3, out float time)
{
    time = -1;
    vec3 N = cross(v2 - v1, v3 - v1);
    float NdotRayDirection = dot(N, ray.Direction);
    if ((NdotRayDirection > -EPSILON) && (NdotRayDirection < EPSILON)) return false;
    
    float t = -(dot(N, ray.Origin) - dot(N, v1)) / NdotRayDirection;
    if (t < 0) return false;
    
    vec3 P = ray.Origin + t * ray.Direction;
    if ((dot(N, cross(v2 - v1, P - v1)) < 0) || 
        (dot(N, cross(v3 - v2, P - v2)) < 0) ||
        (dot(N, cross(v1 - v3, P - v3)) < 0)) return false;
 
    time = t;
    return true;
}

SRay GenerateRay()
{
    vec2 coords    = glPosition.xy * uCamera.Scale;
    vec3 direction = uCamera.View + uCamera.Side * coords.x + uCamera.Up * coords.y;
    return SRay (uCamera.Position, normalize(direction));
}

vec3 Phong(SIntersection intersect, SLight currLight, vec3 viewDirection, float shadowing)
{
    vec3  light     = normalize(currLight.Position - intersect.Point);
    vec3  view      = normalize(uCamera.Position - intersect.Point);
    float diffuse   = max(dot(light, intersect.Normal), 0.0);
    vec3  reflected = reflect(-view, intersect.Normal);
    float specular  = pow(max(dot(reflected, light), 0.0), intersect.LightCoeffs.w);
    return intersect.LightCoeffs.x * intersect.Color +
           intersect.LightCoeffs.y * diffuse * intersect.Color * shadowing +
           intersect.LightCoeffs.z * specular * Unit;
}

bool Raytrace(SRay ray, float start, float final, inout SIntersection intersect)
{
    bool  result = false;
    float test   = start;
    intersect.Time = final;
    for (int j = 0; j < imageSize(uSpheres); j++)
    {
        SSphere Sphere = SSphere(imageLoad(uSpheres, j).xyz, imageLoad(uSpheres, j).w);
        if (IntersectSphere(Sphere, ray, start, final, test) && test < intersect.Time)
        {
            intersect.Time           = test;
            intersect.Point          = ray.Origin + ray.Direction * test;
            intersect.Normal         = normalize ( intersect.Point - Sphere.Center );
            intersect.Color          = uMaterials[6].Color;
            intersect.LightCoeffs    = uMaterials[6].LightCoeffs;
            intersect.ReflectionCoef = uMaterials[6].ReflectionCoef;
            intersect.RefractionCoef = uMaterials[6].RefractionCoef;
            intersect.MaterialType   = uMaterials[6].MaterialType;
            result = true;
        }
    }

    for (int j = 0; j < imageSize(uIndexes); j++)
    {
        int vertex1 = int(imageLoad(uIndexes, j).x);
        int vertex2 = int(imageLoad(uIndexes, j).y);
        int vertex3 = int(imageLoad(uIndexes, j).z);
        STriangle triangle = STriangle(
            imageLoad(uPoints, vertex1).xyz, 
            imageLoad(uPoints, vertex2).xyz, 
            imageLoad(uPoints, vertex3).xyz, 1
        );

        if (RayTriangleIntersection(ray, triangle.v1, triangle.v2, triangle.v3, test) && test < intersect.Time)
        {
            intersect.Time   = test;
            intersect.Point  = ray.Origin + ray.Direction * test;
            intersect.Normal = normalize(cross(triangle.v1 - triangle.v2, triangle.v3 - triangle.v2));

            int material = int(imageLoad(uIndexes, j).w);
            intersect.Color          = uMaterials[material].Color;
            intersect.LightCoeffs    = uMaterials[material].LightCoeffs;
            intersect.ReflectionCoef = uMaterials[material].ReflectionCoef;
            intersect.RefractionCoef = uMaterials[material].RefractionCoef;
            intersect.MaterialType   = uMaterials[material].MaterialType;
            result = true;
        }

    }
    return result;
}

float Shadow(SLight currLight, SIntersection intersect)
{
    vec3  direction     = normalize(currLight.Position - intersect.Point);
    float distanceLight = distance(currLight.Position, intersect.Point);
    SRay  shadowRay     = SRay(intersect.Point + direction * EPSILON, direction);
    SIntersection shadowIntersect;
    shadowIntersect.Time = BIG;
    return (Raytrace(shadowRay, 0, distanceLight, shadowIntersect) ? 0.0 : 1.0);
}


float Fresnel(const vec3 I, const vec3 N, const float ior)
{
    float cosi = clamp(-1, 1, dot(I,N));
    float etai = 1, etat = ior;
    if (cosi > 0) 
    {
        float temp = etai;
        etai = etat;
        etat = temp;
    }

    float sint = etai / etat * sqrt(max(0.f, 1 - cosi * cosi));
    if (sint >= 1) return 1;
    else 
    {
        float cost = sqrt(max(0.f, 1 - sint * sint));
        cosi = abs(cosi);
        float Rs = ((etat * cosi) - (etai * cost)) / ((etat * cosi) + (etai * cost));
        float Rp = ((etai * cosi) - (etat * cost)) / ((etai * cosi) + (etat * cost));
        return (Rs * Rs + Rp * Rp) / 2;
    }
} 

const int MAX_STACK_SIZE = 10;
const int MAX_TRACE_DEPTH = 8;
STracingRay stack[MAX_STACK_SIZE];
int stackSize = 0;
bool pushRay(STracingRay secondaryRay)
{
    if (stackSize < MAX_STACK_SIZE - 1 && secondaryRay.depth < MAX_TRACE_DEPTH)
    {
        stack[stackSize] = secondaryRay;
        stackSize++;
        return true;
    }
    return false;
}

bool isEmpty()
{
    return (stackSize < 0);
}

STracingRay popRay()
{
    stackSize--;
    return stack[stackSize];    
}

void main ()
{
    SRay ray = GenerateRay();

    float start;
    float final;
    vec3  resultColor = Zero;
    STracingRay sray  = STracingRay(ray, 1, 0);
    pushRay(sray);
    while (!isEmpty())
    {
        STracingRay sray = popRay();
        ray = sray.ray;
        SIntersection intersect;
        intersect.Time = BIG;
        start = 0;
        final = BIG;
        if (Raytrace(ray, start, final, intersect)) 
        {
            switch(intersect.MaterialType)
            {
                case DIFFUSE_REFLECTION:
                    float shadowing = Shadow(uLight, intersect);
                    resultColor += sray.contribution * Phong(intersect, uLight, -normalize(ray.Direction), shadowing);
                    break;

                case MIRROR_REFLECTION: 
                    if (intersect.ReflectionCoef < 1)
                    {
                        float shadowing = Shadow(uLight, intersect);
                        resultColor += (1 - intersect.ReflectionCoef) * Phong(intersect, uLight, -normalize(ray.Direction), shadowing);
                    }
                    vec3 reflectDirection = reflect(ray.Direction, intersect.Normal);
                    STracingRay reflectRay = STracingRay(
                        SRay(intersect.Point + reflectDirection * EPSILON, reflectDirection), 
                        sray.contribution * intersect.ReflectionCoef, 
                        sray.depth + 1
                    );
                    pushRay(reflectRay);
                    break;

                case REFRACTION:
                    bool  outside = (dot(ray.Direction, intersect.Normal) < 0);
                    vec3  bias = EPSILON * intersect.Normal;
                    float ior = outside ? 1.0 / intersect.RefractionCoef : intersect.RefractionCoef;
                    int   signOut = outside ? 1 : -1;
                    vec3 refractionDirection = normalize(refract(ray.Direction,  intersect.Normal * signOut, ior));
                    vec3 refractionRayOrig   = intersect.Point + EPSILON * refractionDirection;
                    pushRay(STracingRay(SRay(refractionRayOrig, refractionDirection), sray.contribution * 0.99, sray.depth + 1));
                    break;
            }
        }
    }
    FragColor = vec4 ( resultColor, 1.0 );
}


