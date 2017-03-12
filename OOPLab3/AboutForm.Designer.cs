namespace OOPLab3
{
    partial class AboutForm
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
            this.MenuItemFill = new System.Windows.Forms.ToolStripMenuItem();
            this.заполнитьСлучайнымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уничтожитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.конверторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.comboBoxTransportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFill,
            this.MenuItemAbout,
            this.конверторToolStripMenuItem,
            this.MenuItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemFill
            // 
            this.MenuItemFill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заполнитьСлучайнымиToolStripMenuItem,
            this.уничтожитьToolStripMenuItem});
            this.MenuItemFill.Name = "MenuItemFill";
            this.MenuItemFill.Size = new System.Drawing.Size(62, 20);
            this.MenuItemFill.Text = "Модель";
            // 
            // заполнитьСлучайнымиToolStripMenuItem
            // 
            this.заполнитьСлучайнымиToolStripMenuItem.Name = "заполнитьСлучайнымиToolStripMenuItem";
            this.заполнитьСлучайнымиToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.заполнитьСлучайнымиToolStripMenuItem.Text = "Заполнить случайными";
            this.заполнитьСлучайнымиToolStripMenuItem.Click += new System.EventHandler(this.FillToolStripMenuItem_Click);
            // 
            // уничтожитьToolStripMenuItem
            // 
            this.уничтожитьToolStripMenuItem.Name = "уничтожитьToolStripMenuItem";
            this.уничтожитьToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.уничтожитьToolStripMenuItem.Text = "Уничтожить";
            this.уничтожитьToolStripMenuItem.Click += new System.EventHandler(this.DestroyToolStripMenuItem_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(94, 20);
            this.MenuItemAbout.Text = "О программе";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // конверторToolStripMenuItem
            // 
            this.конверторToolStripMenuItem.Name = "конверторToolStripMenuItem";
            this.конверторToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.конверторToolStripMenuItem.Text = "Конвертор";
            this.конверторToolStripMenuItem.Click += new System.EventHandler(this.ConvertorToolStripMenuItem_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(53, 20);
            this.MenuItemExit.Text = "Выход";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Останавлевается на улице";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(19, 80);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(260, 20);
            this.textBoxNumber.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(196, 191);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(83, 26);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // comboBoxTransportType
            // 
            this.comboBoxTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTransportType.FormattingEnabled = true;
            this.comboBoxTransportType.Items.AddRange(new object[] {
            "Автобус",
            "Маршрутное такси",
            "Метро",
            "Трамвай",
            "Троллейбус",
            "Электропоезд"});
            this.comboBoxTransportType.Location = new System.Drawing.Point(19, 121);
            this.comboBoxTransportType.Name = "comboBoxTransportType";
            this.comboBoxTransportType.Size = new System.Drawing.Size(260, 21);
            this.comboBoxTransportType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Найти информацию о маршруте";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип транспорта";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(19, 165);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(260, 20);
            this.textBoxStreet.TabIndex = 8;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 228);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTransportType);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AboutForm";
            this.Text = "Транспорт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFill;
        private System.Windows.Forms.ComboBox comboBoxTransportType;
        private System.Windows.Forms.ToolStripMenuItem заполнитьСлучайнымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уничтожитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конверторToolStripMenuItem;
    }
}

