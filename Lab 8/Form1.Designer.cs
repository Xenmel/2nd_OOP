namespace Lab_8
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Add = new System.Windows.Forms.GroupBox();
            this.maskedTemp = new System.Windows.Forms.MaskedTextBox();
            this.plus = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedDay = new System.Windows.Forms.MaskedTextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search = new System.Windows.Forms.Button();
            this.LowTemp = new System.Windows.Forms.CheckBox();
            this.HighTemp = new System.Windows.Forms.CheckBox();
            this.SrTemperature = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedDayDel = new System.Windows.Forms.MaskedTextBox();
            this.tempetarue = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Del = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DSC = new System.Windows.Forms.CheckBox();
            this.menuStrip2.SuspendLayout();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(730, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.загрузитьToolStripMenuItem.Text = "Сохранить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Add
            // 
            this.Add.Controls.Add(this.DSC);
            this.Add.Controls.Add(this.maskedTemp);
            this.Add.Controls.Add(this.plus);
            this.Add.Controls.Add(this.buttonAdd);
            this.Add.Controls.Add(this.textBox1);
            this.Add.Controls.Add(this.maskedDay);
            this.Add.Controls.Add(this.Day);
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(13, 32);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(351, 152);
            this.Add.TabIndex = 2;
            this.Add.TabStop = false;
            this.Add.Text = "Добавить";
            // 
            // maskedTemp
            // 
            this.maskedTemp.Location = new System.Drawing.Point(106, 68);
            this.maskedTemp.Mask = "00";
            this.maskedTemp.Name = "maskedTemp";
            this.maskedTemp.Size = new System.Drawing.Size(82, 24);
            this.maskedTemp.TabIndex = 12;
            this.maskedTemp.ValidatingType = typeof(int);
            // 
            // plus
            // 
            this.plus.FormattingEnabled = true;
            this.plus.Items.AddRange(new object[] {
            "Плюс",
            "Минус"});
            this.plus.Location = new System.Drawing.Point(200, 67);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(97, 25);
            this.plus.TabIndex = 11;
            this.plus.Text = "Плюс";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(66, 111);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(231, 35);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(0, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 17);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Температура";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedDay
            // 
            this.maskedDay.Location = new System.Drawing.Point(106, 37);
            this.maskedDay.Mask = "00";
            this.maskedDay.Name = "maskedDay";
            this.maskedDay.Size = new System.Drawing.Size(82, 24);
            this.maskedDay.TabIndex = 2;
            this.maskedDay.ValidatingType = typeof(int);
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.SystemColors.Menu;
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Day.Location = new System.Drawing.Point(0, 37);
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Size = new System.Drawing.Size(100, 17);
            this.Day.TabIndex = 0;
            this.Day.Text = "Дата";
            this.Day.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(348, 680);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.LowTemp);
            this.groupBox1.Controls.Add(this.HighTemp);
            this.groupBox1.Controls.Add(this.SrTemperature);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 180);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(66, 139);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(231, 35);
            this.Search.TabIndex = 8;
            this.Search.Text = "Найти";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LowTemp
            // 
            this.LowTemp.AutoSize = true;
            this.LowTemp.Location = new System.Drawing.Point(6, 89);
            this.LowTemp.Name = "LowTemp";
            this.LowTemp.Size = new System.Drawing.Size(220, 22);
            this.LowTemp.TabIndex = 11;
            this.LowTemp.Text = "Самая низкая температура";
            this.LowTemp.UseVisualStyleBackColor = true;
            // 
            // HighTemp
            // 
            this.HighTemp.AutoSize = true;
            this.HighTemp.Location = new System.Drawing.Point(6, 61);
            this.HighTemp.Name = "HighTemp";
            this.HighTemp.Size = new System.Drawing.Size(232, 22);
            this.HighTemp.TabIndex = 10;
            this.HighTemp.Text = "Самая высокая температура";
            this.HighTemp.UseVisualStyleBackColor = true;
            // 
            // SrTemperature
            // 
            this.SrTemperature.AutoSize = true;
            this.SrTemperature.Location = new System.Drawing.Point(6, 33);
            this.SrTemperature.Name = "SrTemperature";
            this.SrTemperature.Size = new System.Drawing.Size(182, 22);
            this.SrTemperature.TabIndex = 9;
            this.SrTemperature.Text = "Средняя температура";
            this.SrTemperature.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.maskedDayDel);
            this.groupBox2.Controls.Add(this.tempetarue);
            this.groupBox2.Controls.Add(this.data);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.Del);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 376);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 193);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удалить";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Плюс",
            "Минус"});
            this.comboBox2.Location = new System.Drawing.Point(200, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 25);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Плюс";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 98);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 24);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedDayDel
            // 
            this.maskedDayDel.Location = new System.Drawing.Point(106, 68);
            this.maskedDayDel.Mask = "00";
            this.maskedDayDel.Name = "maskedDayDel";
            this.maskedDayDel.Size = new System.Drawing.Size(82, 24);
            this.maskedDayDel.TabIndex = 9;
            this.maskedDayDel.ValidatingType = typeof(System.DateTime);
            // 
            // tempetarue
            // 
            this.tempetarue.BackColor = System.Drawing.SystemColors.Menu;
            this.tempetarue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tempetarue.Location = new System.Drawing.Point(0, 98);
            this.tempetarue.Name = "tempetarue";
            this.tempetarue.ReadOnly = true;
            this.tempetarue.Size = new System.Drawing.Size(100, 17);
            this.tempetarue.TabIndex = 9;
            this.tempetarue.Text = "Температура";
            this.tempetarue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.SystemColors.Menu;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.Location = new System.Drawing.Point(0, 68);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Size = new System.Drawing.Size(100, 17);
            this.data.TabIndex = 8;
            this.data.Text = "Дата";
            this.data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По дате",
            "По температуре"});
            this.comboBox1.Location = new System.Drawing.Point(200, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 25);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "По дате";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(66, 158);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(231, 35);
            this.Del.TabIndex = 8;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DSC
            // 
            this.DSC.AutoSize = true;
            this.DSC.Location = new System.Drawing.Point(200, 40);
            this.DSC.Name = "DSC";
            this.DSC.Size = new System.Drawing.Size(63, 22);
            this.DSC.TabIndex = 13;
            this.DSC.Text = "ДСЧ";
            this.DSC.UseVisualStyleBackColor = true;
            this.DSC.CheckedChanged += new System.EventHandler(this.DSC_CheckedChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 724);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Температура";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox maskedDay;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LowTemp;
        private System.Windows.Forms.CheckBox HighTemp;
        private System.Windows.Forms.CheckBox SrTemperature;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedDayDel;
        private System.Windows.Forms.TextBox tempetarue;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.MaskedTextBox maskedTemp;
        private System.Windows.Forms.ComboBox plus;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox DSC;
    }
}

