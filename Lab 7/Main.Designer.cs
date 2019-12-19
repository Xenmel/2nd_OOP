namespace Lab_7
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одномерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двумерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рваныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типВводаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ручнойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дСЧToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типМассиваToolStripMenuItem,
            this.типВводаToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            resources.ApplyResources(this.параметрыToolStripMenuItem, "параметрыToolStripMenuItem");
            // 
            // типМассиваToolStripMenuItem
            // 
            this.типМассиваToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одномерныйToolStripMenuItem,
            this.двумерныйToolStripMenuItem,
            this.рваныйToolStripMenuItem});
            this.типМассиваToolStripMenuItem.Name = "типМассиваToolStripMenuItem";
            resources.ApplyResources(this.типМассиваToolStripMenuItem, "типМассиваToolStripMenuItem");
            // 
            // одномерныйToolStripMenuItem
            // 
            this.одномерныйToolStripMenuItem.Name = "одномерныйToolStripMenuItem";
            resources.ApplyResources(this.одномерныйToolStripMenuItem, "одномерныйToolStripMenuItem");
            this.одномерныйToolStripMenuItem.Click += new System.EventHandler(this.одномерныйToolStripMenuItem_Click_1);
            // 
            // двумерныйToolStripMenuItem
            // 
            this.двумерныйToolStripMenuItem.Name = "двумерныйToolStripMenuItem";
            resources.ApplyResources(this.двумерныйToolStripMenuItem, "двумерныйToolStripMenuItem");
            this.двумерныйToolStripMenuItem.Click += new System.EventHandler(this.двумерныйToolStripMenuItem_Click_1);
            // 
            // рваныйToolStripMenuItem
            // 
            this.рваныйToolStripMenuItem.Name = "рваныйToolStripMenuItem";
            resources.ApplyResources(this.рваныйToolStripMenuItem, "рваныйToolStripMenuItem");
            this.рваныйToolStripMenuItem.Click += new System.EventHandler(this.рваныйToolStripMenuItem_Click_1);
            // 
            // типВводаToolStripMenuItem
            // 
            this.типВводаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ручнойToolStripMenuItem,
            this.дСЧToolStripMenuItem,
            this.изФайлаToolStripMenuItem});
            this.типВводаToolStripMenuItem.Name = "типВводаToolStripMenuItem";
            resources.ApplyResources(this.типВводаToolStripMenuItem, "типВводаToolStripMenuItem");
            // 
            // ручнойToolStripMenuItem
            // 
            this.ручнойToolStripMenuItem.Name = "ручнойToolStripMenuItem";
            resources.ApplyResources(this.ручнойToolStripMenuItem, "ручнойToolStripMenuItem");
            this.ручнойToolStripMenuItem.Click += new System.EventHandler(this.ручнойToolStripMenuItem_Click_1);
            // 
            // дСЧToolStripMenuItem
            // 
            this.дСЧToolStripMenuItem.Name = "дСЧToolStripMenuItem";
            resources.ApplyResources(this.дСЧToolStripMenuItem, "дСЧToolStripMenuItem");
            this.дСЧToolStripMenuItem.Click += new System.EventHandler(this.дСЧToolStripMenuItem_Click_1);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Name = "richTextBox1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            resources.ApplyResources(this.изФайлаToolStripMenuItem, "изФайлаToolStripMenuItem");
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одномерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двумерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рваныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типВводаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ручнойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дСЧToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
    }
}

