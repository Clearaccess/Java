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
            this.случайнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сВыборомКолчичестваСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьСловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиТекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            // случайнаяToolStripMenuItem
            // 
            this.случайнаяToolStripMenuItem.Name = "случайнаяToolStripMenuItem";
            this.случайнаяToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.случайнаяToolStripMenuItem.Text = "Случайная";
            this.случайнаяToolStripMenuItem.Click += new System.EventHandler(this.случайнаяToolStripMenuItem_Click);
            // 
            // сВыборомКолчичестваСловToolStripMenuItem
            // 
            this.сВыборомКолчичестваСловToolStripMenuItem.Name = "сВыборомКолчичестваСловToolStripMenuItem";
            this.сВыборомКолчичестваСловToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.сВыборомКолчичестваСловToolStripMenuItem.Text = "С указанием колличества слов";
            this.сВыборомКолчичестваСловToolStripMenuItem.Click += new System.EventHandler(this.сВыборомКолчичестваСловToolStripMenuItem_Click);
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
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // ввестиТекстToolStripMenuItem
            // 
            this.ввестиТекстToolStripMenuItem.Name = "ввестиТекстToolStripMenuItem";
            this.ввестиТекстToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ввестиТекстToolStripMenuItem.Text = "Ввести текст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

