namespace RestClientUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.listProductsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(172, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo a Rekwest";
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewProductButton.Location = new System.Drawing.Point(348, 216);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(269, 60);
            this.addNewProductButton.TabIndex = 2;
            this.addNewProductButton.Text = "Adicionar novo produto";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // listProductsButton
            // 
            this.listProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.listProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProductsButton.Location = new System.Drawing.Point(12, 216);
            this.listProductsButton.Name = "listProductsButton";
            this.listProductsButton.Size = new System.Drawing.Size(269, 60);
            this.listProductsButton.TabIndex = 3;
            this.listProductsButton.Text = "Ver Todos Produtos";
            this.listProductsButton.UseVisualStyleBackColor = true;
            this.listProductsButton.Click += new System.EventHandler(this.listProductsButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 328);
            this.Controls.Add(this.listProductsButton);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button listProductsButton;
    }
}

