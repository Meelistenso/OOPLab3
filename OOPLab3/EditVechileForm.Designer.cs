namespace OOPLab3
{
    partial class EditVechileForm
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
            this.listBoxVechiles = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.textBoxEditModel = new System.Windows.Forms.TextBox();
            this.textBoxEditType = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.model = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEditNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxVechiles
            // 
            this.listBoxVechiles.FormattingEnabled = true;
            this.listBoxVechiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxVechiles.Name = "listBoxVechiles";
            this.listBoxVechiles.Size = new System.Drawing.Size(126, 95);
            this.listBoxVechiles.TabIndex = 16;
            this.listBoxVechiles.SelectedIndexChanged += new System.EventHandler(this.listBoxVechiles_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Location = new System.Drawing.Point(151, 87);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(85, 23);
            this.BtnDelete.TabIndex = 29;
            this.BtnDelete.Text = "Удалить";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // textBoxEditModel
            // 
            this.textBoxEditModel.Location = new System.Drawing.Point(242, 61);
            this.textBoxEditModel.Name = "textBoxEditModel";
            this.textBoxEditModel.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditModel.TabIndex = 28;
            // 
            // textBoxEditType
            // 
            this.textBoxEditType.Location = new System.Drawing.Point(242, 36);
            this.textBoxEditType.Name = "textBoxEditType";
            this.textBoxEditType.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditType.TabIndex = 27;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(324, 114);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(85, 23);
            this.BtnSubmit.TabIndex = 26;
            this.BtnSubmit.Text = "Назад";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(243, 87);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 25;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Enabled = false;
            this.BtnReplace.Location = new System.Drawing.Point(324, 87);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(85, 23);
            this.BtnReplace.TabIndex = 24;
            this.BtnReplace.Text = "Заменить";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(149, 61);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(46, 13);
            this.model.TabIndex = 23;
            this.model.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Тип транспорта";
            // 
            // textBoxEditNumber
            // 
            this.textBoxEditNumber.Location = new System.Drawing.Point(242, 11);
            this.textBoxEditNumber.Name = "textBoxEditNumber";
            this.textBoxEditNumber.Size = new System.Drawing.Size(167, 20);
            this.textBoxEditNumber.TabIndex = 31;
            this.textBoxEditNumber.TextChanged += new System.EventHandler(this.textBoxEditNumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Номер";
            // 
            // EditVechileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 150);
            this.Controls.Add(this.textBoxEditNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.textBoxEditModel);
            this.Controls.Add(this.textBoxEditType);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVechiles);
            this.Name = "EditVechileForm";
            this.Text = "Редактировать транспорт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxVechiles;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox textBoxEditModel;
        private System.Windows.Forms.TextBox textBoxEditType;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEditNumber;
        private System.Windows.Forms.Label label3;
    }
}