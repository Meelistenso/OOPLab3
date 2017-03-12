namespace OOPLab3
{
    partial class VechileForm
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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVechiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(161, 84);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(95, 23);
            this.BtnEdit.TabIndex = 15;
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(251, 35);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(0, 13);
            this.labelModel.TabIndex = 14;
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Location = new System.Drawing.Point(251, 12);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(0, 13);
            this.labelTransportType.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Модель";
            // 
            // listBoxVechiles
            // 
            this.listBoxVechiles.FormattingEnabled = true;
            this.listBoxVechiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxVechiles.Name = "listBoxVechiles";
            this.listBoxVechiles.Size = new System.Drawing.Size(126, 95);
            this.listBoxVechiles.TabIndex = 8;
            this.listBoxVechiles.SelectedIndexChanged += new System.EventHandler(this.listBoxVechiles_SelectedIndexChanged);
            // 
            // VechileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 120);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelTransportType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVechiles);
            this.Name = "VechileForm";
            this.Text = "Транспорт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxVechiles;
    }
}