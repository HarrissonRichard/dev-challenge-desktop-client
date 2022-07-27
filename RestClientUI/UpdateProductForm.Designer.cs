namespace RestClientUI
{
    partial class UpdateProductForm
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
            this.saveAlteredProductButton = new System.Windows.Forms.Button();
            this.vatToUpdateValue = new System.Windows.Forms.TextBox();
            this.availableSTKToUpdateValue = new System.Windows.Forms.TextBox();
            this.unitToUpdateValue = new System.Windows.Forms.TextBox();
            this.identifierToUpdateValue = new System.Windows.Forms.TextBox();
            this.priceToUpdateValue = new System.Windows.Forms.TextBox();
            this.descriptionToUpdateValue = new System.Windows.Forms.TextBox();
            this.descriptionENToUpdateValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inactiveToUpdateValue = new System.Windows.Forms.CheckBox();
            this.idNotToUpdateValue = new System.Windows.Forms.TextBox();
            this.remoteIdNotToUpdateValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveAlteredProductButton
            // 
            this.saveAlteredProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveAlteredProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAlteredProductButton.Location = new System.Drawing.Point(184, 310);
            this.saveAlteredProductButton.Name = "saveAlteredProductButton";
            this.saveAlteredProductButton.Size = new System.Drawing.Size(269, 60);
            this.saveAlteredProductButton.TabIndex = 18;
            this.saveAlteredProductButton.Text = "Salvar Alterações";
            this.saveAlteredProductButton.UseVisualStyleBackColor = true;
            this.saveAlteredProductButton.Click += new System.EventHandler(this.saveAlteredProductButton_Click);
            // 
            // vatToUpdateValue
            // 
            this.vatToUpdateValue.Location = new System.Drawing.Point(162, 223);
            this.vatToUpdateValue.Multiline = true;
            this.vatToUpdateValue.Name = "vatToUpdateValue";
            this.vatToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.vatToUpdateValue.TabIndex = 32;
            // 
            // availableSTKToUpdateValue
            // 
            this.availableSTKToUpdateValue.Location = new System.Drawing.Point(162, 157);
            this.availableSTKToUpdateValue.Multiline = true;
            this.availableSTKToUpdateValue.Name = "availableSTKToUpdateValue";
            this.availableSTKToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.availableSTKToUpdateValue.TabIndex = 31;
            // 
            // unitToUpdateValue
            // 
            this.unitToUpdateValue.Location = new System.Drawing.Point(514, 148);
            this.unitToUpdateValue.Multiline = true;
            this.unitToUpdateValue.Name = "unitToUpdateValue";
            this.unitToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.unitToUpdateValue.TabIndex = 30;
            // 
            // identifierToUpdateValue
            // 
            this.identifierToUpdateValue.Location = new System.Drawing.Point(162, 17);
            this.identifierToUpdateValue.Multiline = true;
            this.identifierToUpdateValue.Name = "identifierToUpdateValue";
            this.identifierToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.identifierToUpdateValue.TabIndex = 29;
            // 
            // priceToUpdateValue
            // 
            this.priceToUpdateValue.Location = new System.Drawing.Point(514, 86);
            this.priceToUpdateValue.Multiline = true;
            this.priceToUpdateValue.Name = "priceToUpdateValue";
            this.priceToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.priceToUpdateValue.TabIndex = 28;
            // 
            // descriptionToUpdateValue
            // 
            this.descriptionToUpdateValue.Location = new System.Drawing.Point(514, 17);
            this.descriptionToUpdateValue.Multiline = true;
            this.descriptionToUpdateValue.Name = "descriptionToUpdateValue";
            this.descriptionToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.descriptionToUpdateValue.TabIndex = 27;
            // 
            // descriptionENToUpdateValue
            // 
            this.descriptionENToUpdateValue.Location = new System.Drawing.Point(162, 77);
            this.descriptionENToUpdateValue.Multiline = true;
            this.descriptionENToUpdateValue.Name = "descriptionENToUpdateValue";
            this.descriptionENToUpdateValue.Size = new System.Drawing.Size(175, 34);
            this.descriptionENToUpdateValue.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "VAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "AvailableSTK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(374, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Unit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(374, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "DescriptionEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(374, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Identifier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(374, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Inactive:";
            // 
            // inactiveToUpdateValue
            // 
            this.inactiveToUpdateValue.AutoSize = true;
            this.inactiveToUpdateValue.Location = new System.Drawing.Point(466, 250);
            this.inactiveToUpdateValue.Name = "inactiveToUpdateValue";
            this.inactiveToUpdateValue.Size = new System.Drawing.Size(63, 17);
            this.inactiveToUpdateValue.TabIndex = 34;
            this.inactiveToUpdateValue.Text = "inactive";
            this.inactiveToUpdateValue.UseVisualStyleBackColor = true;
            // 
            // idNotToUpdateValue
            // 
            this.idNotToUpdateValue.Location = new System.Drawing.Point(648, 308);
            this.idNotToUpdateValue.Multiline = true;
            this.idNotToUpdateValue.Name = "idNotToUpdateValue";
            this.idNotToUpdateValue.Size = new System.Drawing.Size(15, 34);
            this.idNotToUpdateValue.TabIndex = 35;
            this.idNotToUpdateValue.Visible = false;
            // 
            // remoteIdNotToUpdateValue
            // 
            this.remoteIdNotToUpdateValue.Location = new System.Drawing.Point(648, 348);
            this.remoteIdNotToUpdateValue.Multiline = true;
            this.remoteIdNotToUpdateValue.Name = "remoteIdNotToUpdateValue";
            this.remoteIdNotToUpdateValue.Size = new System.Drawing.Size(15, 34);
            this.remoteIdNotToUpdateValue.TabIndex = 36;
            this.remoteIdNotToUpdateValue.Visible = false;
            // 
            // UpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 394);
            this.Controls.Add(this.remoteIdNotToUpdateValue);
            this.Controls.Add(this.idNotToUpdateValue);
            this.Controls.Add(this.inactiveToUpdateValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vatToUpdateValue);
            this.Controls.Add(this.availableSTKToUpdateValue);
            this.Controls.Add(this.unitToUpdateValue);
            this.Controls.Add(this.identifierToUpdateValue);
            this.Controls.Add(this.priceToUpdateValue);
            this.Controls.Add(this.descriptionToUpdateValue);
            this.Controls.Add(this.descriptionENToUpdateValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveAlteredProductButton);
            this.Name = "UpdateProductForm";
            this.Text = "UpdateProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAlteredProductButton;
        private System.Windows.Forms.TextBox vatToUpdateValue;
        private System.Windows.Forms.TextBox availableSTKToUpdateValue;
        private System.Windows.Forms.TextBox unitToUpdateValue;
        private System.Windows.Forms.TextBox identifierToUpdateValue;
        private System.Windows.Forms.TextBox priceToUpdateValue;
        private System.Windows.Forms.TextBox descriptionToUpdateValue;
        private System.Windows.Forms.TextBox descriptionENToUpdateValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox inactiveToUpdateValue;
        private System.Windows.Forms.TextBox idNotToUpdateValue;
        private System.Windows.Forms.TextBox remoteIdNotToUpdateValue;
    }
}