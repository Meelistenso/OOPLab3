namespace OOPLab3
{
    partial class EditRouteForm
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
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.textBoxEditType = new System.Windows.Forms.TextBox();
            this.textBoxEditNumber = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(333, 88);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(85, 23);
            this.BtnSubmit.TabIndex = 15;
            this.BtnSubmit.Text = "Назад";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(252, 61);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Enabled = false;
            this.BtnReplace.Location = new System.Drawing.Point(333, 61);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(85, 23);
            this.BtnReplace.TabIndex = 11;
            this.BtnReplace.Text = "Заменить";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Тип транспорта";
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(12, 12);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(126, 95);
            this.listBoxRoutes.TabIndex = 8;
            this.listBoxRoutes.SelectedIndexChanged += new System.EventHandler(this.listBoxRoutes_SelectedIndexChanged);
            // 
            // textBoxEditType
            // 
            this.textBoxEditType.Location = new System.Drawing.Point(251, 9);
            this.textBoxEditType.Name = "textBoxEditType";
            this.textBoxEditType.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditType.TabIndex = 16;
            this.textBoxEditType.TextChanged += new System.EventHandler(this.textBoxEditType_TextChanged);
            // 
            // textBoxEditNumber
            // 
            this.textBoxEditNumber.Location = new System.Drawing.Point(251, 35);
            this.textBoxEditNumber.Name = "textBoxEditNumber";
            this.textBoxEditNumber.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditNumber.TabIndex = 17;
            this.textBoxEditNumber.TextChanged += new System.EventHandler(this.textBoxEditNumber_TextChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(160, 61);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EditRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 121);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.textBoxEditNumber);
            this.Controls.Add(this.textBoxEditType);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRoutes);
            this.Name = "EditRouteForm";
            this.Text = "Редактировать маршруты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.TextBox textBoxEditType;
        private System.Windows.Forms.TextBox textBoxEditNumber;
        private System.Windows.Forms.Button BtnDelete;
    }
}