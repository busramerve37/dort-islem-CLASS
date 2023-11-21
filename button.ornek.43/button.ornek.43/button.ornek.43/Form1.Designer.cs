namespace button.ornek._43
{
    partial class Form1
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblToplama = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblCikarma = new System.Windows.Forms.Label();
            this.lblCarpma = new System.Windows.Forms.Label();
            this.lblBolme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(22, 27);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(36, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "Sayı 1";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(22, 60);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(36, 13);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "Sayı 2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(75, 27);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 5;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(75, 60);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 6;
            // 
            // lblToplama
            // 
            this.lblToplama.AutoSize = true;
            this.lblToplama.Location = new System.Drawing.Point(259, 30);
            this.lblToplama.Name = "lblToplama";
            this.lblToplama.Size = new System.Drawing.Size(48, 13);
            this.lblToplama.TabIndex = 10;
            this.lblToplama.Text = "Toplama";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(44, 141);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 48);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblCikarma
            // 
            this.lblCikarma.AutoSize = true;
            this.lblCikarma.Location = new System.Drawing.Point(262, 63);
            this.lblCikarma.Name = "lblCikarma";
            this.lblCikarma.Size = new System.Drawing.Size(45, 13);
            this.lblCikarma.TabIndex = 12;
            this.lblCikarma.Text = "Çıkarma";
            // 
            // lblCarpma
            // 
            this.lblCarpma.AutoSize = true;
            this.lblCarpma.Location = new System.Drawing.Point(262, 99);
            this.lblCarpma.Name = "lblCarpma";
            this.lblCarpma.Size = new System.Drawing.Size(43, 13);
            this.lblCarpma.TabIndex = 13;
            this.lblCarpma.Text = "Çarpma";
            // 
            // lblBolme
            // 
            this.lblBolme.AutoSize = true;
            this.lblBolme.Location = new System.Drawing.Point(259, 141);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(36, 13);
            this.lblBolme.TabIndex = 14;
            this.lblBolme.Text = "Bölme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 418);
            this.Controls.Add(this.lblBolme);
            this.Controls.Add(this.lblCarpma);
            this.Controls.Add(this.lblCikarma);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblToplama);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblToplama;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblCikarma;
        private System.Windows.Forms.Label lblCarpma;
        private System.Windows.Forms.Label lblBolme;
    }
}

