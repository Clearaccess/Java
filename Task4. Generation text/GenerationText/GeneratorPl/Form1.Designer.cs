namespace GeneratorPl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.генерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сВыборомКолчичестваСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияToolStripMenuItem,
            this.загрузитьСловаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // генерацияToolStripMenuItem
            // 
            this.генерацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.случайнаяToolStripMenuItem,
            this.сВыборомКолчичестваСловToolStripMenuItem});
            this.генерацияToolStripMenuItem.Name = "генерацияToolStripMenuItem";
            this.генерацияToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.генерацияToolStripMenuItem.Text = "Генерация";
            // 
            // загрузитьСловаToolStripMenuItem
            // 
            this.загрузитьСловаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изФайлаToolStripMenuItem,
            this.ввестиТекстToolStripMenuItem});
            this.загрузитьСловаToolStripMenuItem.Name = "загрузитьСловаToolStripMenuItem";
            this.загрузитьСловаToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.загрузитьСловаToolStripMenuItem.Text = "Загрузить текст";
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            this.изФайлаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.изФайлаToolStripMenuItem.Text = "Из файла";
            // 
            // ввестиТекстToolStripMenuItem
            // 
            this.ввестиТекстToolStripMenuItem.Name = "ввестиТекстToolStripMenuItem";
            this.ввестиТекстToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ввестиТекстToolStripMenuItem.Text = "Ввести текст";
            // 
            // случайнаяToolStripMenuItem
            // 
            this.случайнаяToolStripMenuItem.Name = "случайнаяToolStripMenuItem";
            this.случайнаяToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.случайнаяToolStripMenuItem.Text = "Случайная";
            // 
            // сВыборомКолчичестваСловToolStripMenuItem
            // 
            this.сВыборомКолчичестваСловToolStripMenuItem.Name = "сВыборомКолчичестваСловToolStripMenuItem";
            this.сВыборомКолчичестваСловToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.сВыборомКолчичестваСловToolStripMenuItem.Text = "С указанием колличества слов";
            this.сВыборомКолчичестваСловToolStripMenuItem.Click += new System.EventHandler(this.сВыборомКолчичестваСловToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 352);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem генерацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сВыборомКолчичестваСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьСловаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ввестиТекстToolStripMenuItem;
    }
}

