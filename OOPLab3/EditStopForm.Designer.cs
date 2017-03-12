namespace OOPLab3
{
    partial class EditStopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStops = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.textBoxEditStreet = new System.Windows.Forms.TextBox();
            this.textBoxEditCity = new System.Windows.Forms.TextBox();
            this.textBoxEditStopName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Улица";
            // 
            // listBoxStops
            // 
            this.listBoxStops.FormattingEnabled = true;
            this.listBoxStops.Location = new System.Drawing.Point(12, 11);
            this.listBoxStops.Name = "listBoxStops";
            this.listBoxStops.Size = new System.Drawing.Size(126, 121);
            this.listBoxStops.TabIndex = 16;
            this.listBoxStops.SelectedIndexChanged += new System.EventHandler(this.listBoxStops_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(159, 83);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete.TabIndex = 25;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(334, 111);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(85, 23);
            this.BtnSubmit.TabIndex = 24;
            this.BtnSubmit.Text = "Назад";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(251, 83);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 23;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Enabled = false;
            this.BtnReplace.Location = new System.Drawing.Point(334, 83);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(85, 23);
            this.BtnReplace.TabIndex = 22;
            this.BtnReplace.Text = "Заменить";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // textBoxEditStreet
            // 
            this.textBoxEditStreet.Location = new System.Drawing.Point(252, 32);
            this.textBoxEditStreet.Name = "textBoxEditStreet";
            this.textBoxEditStreet.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditStreet.TabIndex = 27;
            this.textBoxEditStreet.TextChanged += new System.EventHandler(this.textBoxEditStreet_TextChanged);
            // 
            // textBoxEditCity
            // 
            this.textBoxEditCity.Location = new System.Drawing.Point(252, 6);
            this.textBoxEditCity.Name = "textBoxEditCity";
            this.textBoxEditCity.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditCity.TabIndex = 26;
            this.textBoxEditCity.TextChanged += new System.EventHandler(this.textBoxEditCity_TextChanged);
            // 
            // textBoxEditStopName
            // 
            this.textBoxEditStopName.Location = new System.Drawing.Point(252, 58);
            this.textBoxEditStopName.Name = "textBoxEditStopName";
            this.textBoxEditStopName.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditStopName.TabIndex = 29;
            this.textBoxEditStopName.TextChanged += new System.EventHandler(this.textBoxEditStopName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Название";
            // 
            // EditStopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 147);
            this.Controls.Add(this.textBoxEditStopName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEditStreet);
            this.Controls.Add(this.textBoxEditCity);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStops);
            this.Name = "EditStopForm";
            this.Text = "Редактировать остановки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStops;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.TextBox textBoxEditStreet;
        private System.Windows.Forms.TextBox textBoxEditCity;
        private System.Windows.Forms.TextBox textBoxEditStopName;
        private System.Windows.Forms.Label label3;
    }
}