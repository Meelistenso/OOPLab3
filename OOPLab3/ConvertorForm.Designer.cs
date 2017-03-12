namespace OOPLab3
{
    partial class ConvertorForm
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
            this.textBoxValue1 = new System.Windows.Forms.TextBox();
            this.textBoxValue2 = new System.Windows.Forms.TextBox();
            this.Typelabel1 = new System.Windows.Forms.Label();
            this.typelabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxValues = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxValue1
            // 
            this.textBoxValue1.Location = new System.Drawing.Point(15, 85);
            this.textBoxValue1.Name = "textBoxValue1";
            this.textBoxValue1.Size = new System.Drawing.Size(166, 20);
            this.textBoxValue1.TabIndex = 0;
            this.textBoxValue1.TextChanged += new System.EventHandler(this.textBoxValue1_TextChanged);
            // 
            // textBoxValue2
            // 
            this.textBoxValue2.Location = new System.Drawing.Point(222, 85);
            this.textBoxValue2.Name = "textBoxValue2";
            this.textBoxValue2.Size = new System.Drawing.Size(166, 20);
            this.textBoxValue2.TabIndex = 1;
            this.textBoxValue2.TextChanged += new System.EventHandler(this.textBoxValue2_TextChanged);
            // 
            // Typelabel1
            // 
            this.Typelabel1.AutoSize = true;
            this.Typelabel1.Location = new System.Drawing.Point(12, 69);
            this.Typelabel1.Name = "Typelabel1";
            this.Typelabel1.Size = new System.Drawing.Size(32, 13);
            this.Typelabel1.TabIndex = 4;
            this.Typelabel1.Text = "Тип1";
            // 
            // typelabel2
            // 
            this.typelabel2.AutoSize = true;
            this.typelabel2.Location = new System.Drawing.Point(219, 69);
            this.typelabel2.Name = "typelabel2";
            this.typelabel2.Size = new System.Drawing.Size(32, 13);
            this.typelabel2.TabIndex = 5;
            this.typelabel2.Text = "Тип2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип преобразования:";
            // 
            // comboBoxValues
            // 
            this.comboBoxValues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValues.FormattingEnabled = true;
            this.comboBoxValues.Location = new System.Drawing.Point(127, 32);
            this.comboBoxValues.Name = "comboBoxValues";
            this.comboBoxValues.Size = new System.Drawing.Size(261, 21);
            this.comboBoxValues.TabIndex = 10;
            this.comboBoxValues.SelectedIndexChanged += new System.EventHandler(this.comboBoxValues_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Значения:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = ">";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(127, 6);
            this.comboBoxType.MaxDropDownItems = 10;
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(261, 21);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // ConvertorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 112);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxValues);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typelabel2);
            this.Controls.Add(this.Typelabel1);
            this.Controls.Add(this.textBoxValue2);
            this.Controls.Add(this.textBoxValue1);
            this.Name = "ConvertorForm";
            this.Text = "ConvertorForm";
            this.Load += new System.EventHandler(this.ConvertorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue1;
        private System.Windows.Forms.TextBox textBoxValue2;
        private System.Windows.Forms.Label Typelabel1;
        private System.Windows.Forms.Label typelabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxValues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}