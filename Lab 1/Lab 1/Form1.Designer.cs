namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вПолутоновоеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектСтеклаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектВолныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеПоГауссуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.первоеЯдроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.второеЯдроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделенияГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurФильтерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ядро3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ядро7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ядро10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеГистограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьЯдроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.dilationрасширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosioncetybtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingоткрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingзакрытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1209, 565);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.линейноеРастяжениеГистограммыToolStripMenuItem,
            this.математическаяМорфологияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.серыйМирToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.вПолутоновоеToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem,
            this.эффектСтеклаToolStripMenuItem,
            this.эффектВолныToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // вПолутоновоеToolStripMenuItem
            // 
            this.вПолутоновоеToolStripMenuItem.Name = "вПолутоновоеToolStripMenuItem";
            this.вПолутоновоеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.вПолутоновоеToolStripMenuItem.Text = "В полутоновое";
            this.вПолутоновоеToolStripMenuItem.Click += new System.EventHandler(this.вПолутоновоеToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // эффектСтеклаToolStripMenuItem
            // 
            this.эффектСтеклаToolStripMenuItem.Name = "эффектСтеклаToolStripMenuItem";
            this.эффектСтеклаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.эффектСтеклаToolStripMenuItem.Text = "Эффект стекла";
            this.эффектСтеклаToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаToolStripMenuItem_Click);
            // 
            // эффектВолныToolStripMenuItem
            // 
            this.эффектВолныToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.горизонтальнойToolStripMenuItem,
            this.вертикальнойToolStripMenuItem});
            this.эффектВолныToolStripMenuItem.Name = "эффектВолныToolStripMenuItem";
            this.эффектВолныToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.эффектВолныToolStripMenuItem.Text = "Эффект волны";
            // 
            // горизонтальнойToolStripMenuItem
            // 
            this.горизонтальнойToolStripMenuItem.Name = "горизонтальнойToolStripMenuItem";
            this.горизонтальнойToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.горизонтальнойToolStripMenuItem.Text = "Горизонтальной";
            this.горизонтальнойToolStripMenuItem.Click += new System.EventHandler(this.горизонтальнойToolStripMenuItem_Click);
            // 
            // вертикальнойToolStripMenuItem
            // 
            this.вертикальнойToolStripMenuItem.Name = "вертикальнойToolStripMenuItem";
            this.вертикальнойToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.вертикальнойToolStripMenuItem.Text = "Вертикальной";
            this.вертикальнойToolStripMenuItem.Click += new System.EventHandler(this.вертикальнойToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.размытиеПоГауссуToolStripMenuItem,
            this.повыситьРезкостьToolStripMenuItem,
            this.выделенияГраницToolStripMenuItem,
            this.motionBlurФильтерToolStripMenuItem,
            this.тиснениеToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // размытиеПоГауссуToolStripMenuItem
            // 
            this.размытиеПоГауссуToolStripMenuItem.Name = "размытиеПоГауссуToolStripMenuItem";
            this.размытиеПоГауссуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.размытиеПоГауссуToolStripMenuItem.Text = "Размытие по Гауссу";
            this.размытиеПоГауссуToolStripMenuItem.Click += new System.EventHandler(this.размытиеПоГауссуToolStripMenuItem_Click);
            // 
            // повыситьРезкостьToolStripMenuItem
            // 
            this.повыситьРезкостьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.первоеЯдроToolStripMenuItem,
            this.второеЯдроToolStripMenuItem});
            this.повыситьРезкостьToolStripMenuItem.Name = "повыситьРезкостьToolStripMenuItem";
            this.повыситьРезкостьToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.повыситьРезкостьToolStripMenuItem.Text = "Повысить резкость";
            // 
            // первоеЯдроToolStripMenuItem
            // 
            this.первоеЯдроToolStripMenuItem.Name = "первоеЯдроToolStripMenuItem";
            this.первоеЯдроToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.первоеЯдроToolStripMenuItem.Text = "Первое ядро";
            this.первоеЯдроToolStripMenuItem.Click += new System.EventHandler(this.первоеЯдроToolStripMenuItem_Click);
            // 
            // второеЯдроToolStripMenuItem
            // 
            this.второеЯдроToolStripMenuItem.Name = "второеЯдроToolStripMenuItem";
            this.второеЯдроToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.второеЯдроToolStripMenuItem.Text = "Второе ядро";
            this.второеЯдроToolStripMenuItem.Click += new System.EventHandler(this.второеЯдроToolStripMenuItem_Click);
            // 
            // выделенияГраницToolStripMenuItem
            // 
            this.выделенияГраницToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторСобеляToolStripMenuItem,
            this.операторЩарраToolStripMenuItem,
            this.операторПрюиттаToolStripMenuItem});
            this.выделенияГраницToolStripMenuItem.Name = "выделенияГраницToolStripMenuItem";
            this.выделенияГраницToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.выделенияГраницToolStripMenuItem.Text = "Выделения границ";
            // 
            // операторСобеляToolStripMenuItem
            // 
            this.операторСобеляToolStripMenuItem.Name = "операторСобеляToolStripMenuItem";
            this.операторСобеляToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.операторСобеляToolStripMenuItem.Text = "Оператор Собеля";
            this.операторСобеляToolStripMenuItem.Click += new System.EventHandler(this.операторСобеляToolStripMenuItem_Click);
            // 
            // операторЩарраToolStripMenuItem
            // 
            this.операторЩарраToolStripMenuItem.Name = "операторЩарраToolStripMenuItem";
            this.операторЩарраToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.операторЩарраToolStripMenuItem.Text = "Оператор Щарра";
            this.операторЩарраToolStripMenuItem.Click += new System.EventHandler(this.операторЩарраToolStripMenuItem_Click);
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            this.операторПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.операторПрюиттаToolStripMenuItem_Click);
            // 
            // motionBlurФильтерToolStripMenuItem
            // 
            this.motionBlurФильтерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ядро3ToolStripMenuItem,
            this.ядро7ToolStripMenuItem,
            this.ядро10ToolStripMenuItem});
            this.motionBlurФильтерToolStripMenuItem.Name = "motionBlurФильтерToolStripMenuItem";
            this.motionBlurФильтерToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.motionBlurФильтерToolStripMenuItem.Text = "MotionBlur фильтер";
            // 
            // ядро3ToolStripMenuItem
            // 
            this.ядро3ToolStripMenuItem.Name = "ядро3ToolStripMenuItem";
            this.ядро3ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ядро3ToolStripMenuItem.Text = "Ядро 3";
            this.ядро3ToolStripMenuItem.Click += new System.EventHandler(this.ядро3ToolStripMenuItem_Click);
            // 
            // ядро7ToolStripMenuItem
            // 
            this.ядро7ToolStripMenuItem.Name = "ядро7ToolStripMenuItem";
            this.ядро7ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ядро7ToolStripMenuItem.Text = "Ядро 5";
            this.ядро7ToolStripMenuItem.Click += new System.EventHandler(this.ядро7ToolStripMenuItem_Click);
            // 
            // ядро10ToolStripMenuItem
            // 
            this.ядро10ToolStripMenuItem.Name = "ядро10ToolStripMenuItem";
            this.ядро10ToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ядро10ToolStripMenuItem.Text = "Ядро 11";
            this.ядро10ToolStripMenuItem.Click += new System.EventHandler(this.ядро10ToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеГистограммыToolStripMenuItem
            // 
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Name = "линейноеРастяжениеГистограммыToolStripMenuItem";
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Size = new System.Drawing.Size(220, 20);
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Text = "Линейное растяжение гистограммы";
            this.линейноеРастяжениеГистограммыToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеГистограммыToolStripMenuItem_Click);
            // 
            // математическаяМорфологияToolStripMenuItem
            // 
            this.математическаяМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьЯдроToolStripMenuItem,
            this.dilationрасширениеToolStripMenuItem,
            this.erosioncetybtToolStripMenuItem,
            this.openingоткрытиеToolStripMenuItem,
            this.closingзакрытиеToolStripMenuItem});
            this.математическаяМорфологияToolStripMenuItem.Name = "математическаяМорфологияToolStripMenuItem";
            this.математическаяМорфологияToolStripMenuItem.Size = new System.Drawing.Size(185, 20);
            this.математическаяМорфологияToolStripMenuItem.Text = "Математическая морфология";
            // 
            // задатьЯдроToolStripMenuItem
            // 
            this.задатьЯдроToolStripMenuItem.Name = "задатьЯдроToolStripMenuItem";
            this.задатьЯдроToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.задатьЯдроToolStripMenuItem.Text = "Задать ядро";
            this.задатьЯдроToolStripMenuItem.Click += new System.EventHandler(this.задатьЯдроToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 614);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1022, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1041, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dilationрасширениеToolStripMenuItem
            // 
            this.dilationрасширениеToolStripMenuItem.Name = "dilationрасширениеToolStripMenuItem";
            this.dilationрасширениеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dilationрасширениеToolStripMenuItem.Text = "Dilation (расширение)";
            this.dilationрасширениеToolStripMenuItem.Click += new System.EventHandler(this.dilationрасширениеToolStripMenuItem_Click);
            // 
            // erosioncetybtToolStripMenuItem
            // 
            this.erosioncetybtToolStripMenuItem.Name = "erosioncetybtToolStripMenuItem";
            this.erosioncetybtToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.erosioncetybtToolStripMenuItem.Text = "Erosion (сужение)";
            this.erosioncetybtToolStripMenuItem.Click += new System.EventHandler(this.erosioncetybtToolStripMenuItem_Click);
            // 
            // openingоткрытиеToolStripMenuItem
            // 
            this.openingоткрытиеToolStripMenuItem.Name = "openingоткрытиеToolStripMenuItem";
            this.openingоткрытиеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openingоткрытиеToolStripMenuItem.Text = "Opening (открытие)";
            this.openingоткрытиеToolStripMenuItem.Click += new System.EventHandler(this.openingоткрытиеToolStripMenuItem_Click);
            // 
            // closingзакрытиеToolStripMenuItem
            // 
            this.closingзакрытиеToolStripMenuItem.Name = "closingзакрытиеToolStripMenuItem";
            this.closingзакрытиеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.closingзакрытиеToolStripMenuItem.Text = "Closing (закрытие)";
            this.closingзакрытиеToolStripMenuItem.Click += new System.EventHandler(this.closingзакрытиеToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеПоГауссуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вПолутоновоеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделенияГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторСобеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem первоеЯдроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem второеЯдроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurФильтерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ядро3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ядро7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ядро10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектВолныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеГистограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem математическаяМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьЯдроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilationрасширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosioncetybtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingоткрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingзакрытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
    }
}

