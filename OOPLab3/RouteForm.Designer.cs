namespace OOPLab3
{
    partial class RouteForm
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
            this.listBoxRoutes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnStops = new System.Windows.Forms.Button();
            this.BtnVechiles = new System.Windows.Forms.Button();
            this.labelTransportType = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRoutes
            // 
            this.listBoxRoutes.FormattingEnabled = true;
            this.listBoxRoutes.Location = new System.Drawing.Point(12, 12);
            this.listBoxRoutes.Name = "listBoxRoutes";
            this.listBoxRoutes.Size = new System.Drawing.Size(126, 95);
            this.listBoxRoutes.TabIndex = 0;
            this.listBoxRoutes.SelectedIndexChanged += new System.EventHandler(this.listBoxRoutes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип транспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер";
            // 
            // BtnStops
            // 
            this.BtnStops.Enabled = false;
            this.BtnStops.Location = new System.Drawing.Point(161, 84);
            this.BtnStops.Name = "BtnStops";
            this.BtnStops.Size = new System.Drawing.Size(75, 23);
            this.BtnStops.TabIndex = 3;
            this.BtnStops.Text = "Остановки";
            this.BtnStops.UseVisualStyleBackColor = true;
            this.BtnStops.Click += new System.EventHandler(this.BtnStops_Click);
            // 
            // BtnVechiles
            // 
            this.BtnVechiles.Enabled = false;
            this.BtnVechiles.Location = new System.Drawing.Point(242, 84);
            this.BtnVechiles.Name = "BtnVechiles";
            this.BtnVechiles.Size = new System.Drawing.Size(75, 23);
            this.BtnVechiles.TabIndex = 4;
            this.BtnVechiles.Text = "Транспорт";
            this.BtnVechiles.UseVisualStyleBackColor = true;
            this.BtnVechiles.Click += new System.EventHandler(this.BtnVechiles_Click);
            // 
            // labelTransportType
            // 
            this.labelTransportType.AutoSize = true;
            this.labelTransportType.Location = new System.Drawing.Point(251, 12);
            this.labelTransportType.Name = "labelTransportType";
            this.labelTransportType.Size = new System.Drawing.Size(0, 13);
            this.labelTransportType.TabIndex = 5;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(251, 35);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(0, 13);
            this.labelNumber.TabIndex = 6;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(323, 84);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(95, 23);
            this.BtnEdit.TabIndex = 7;
            this.BtnEdit.Text = "Редактировать";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 125);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelTransportType);
            this.Controls.Add(this.BtnVechiles);
            this.Controls.Add(this.BtnStops);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxRoutes);
            this.Name = "RouteForm";
            this.Text = "Маршруты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRoutes;
        private System.Windows.Forms.Button BtnStops;
        private System.Windows.Forms.Button BtnVechiles;
        private System.Windows.Forms.Label labelTransportType;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button BtnEdit;
    }
}