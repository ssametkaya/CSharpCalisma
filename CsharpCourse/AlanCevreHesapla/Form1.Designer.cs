
namespace AlanCevreHesapla
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
            this.hesaplabuton = new System.Windows.Forms.Button();
            this.txtKisaKenar = new System.Windows.Forms.TextBox();
            this.txtUzunKenar = new System.Windows.Forms.TextBox();
            this.checkAlan = new System.Windows.Forms.CheckBox();
            this.checkCevre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlanCevreSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hesaplabuton
            // 
            this.hesaplabuton.Location = new System.Drawing.Point(192, 130);
            this.hesaplabuton.Name = "hesaplabuton";
            this.hesaplabuton.Size = new System.Drawing.Size(75, 23);
            this.hesaplabuton.TabIndex = 0;
            this.hesaplabuton.Text = "Hesapla";
            this.hesaplabuton.UseVisualStyleBackColor = true;
            this.hesaplabuton.Click += new System.EventHandler(this.hesaplabuton_Click);
            // 
            // txtKisaKenar
            // 
            this.txtKisaKenar.Location = new System.Drawing.Point(167, 34);
            this.txtKisaKenar.Name = "txtKisaKenar";
            this.txtKisaKenar.Size = new System.Drawing.Size(100, 20);
            this.txtKisaKenar.TabIndex = 1;
            // 
            // txtUzunKenar
            // 
            this.txtUzunKenar.Location = new System.Drawing.Point(167, 81);
            this.txtUzunKenar.Name = "txtUzunKenar";
            this.txtUzunKenar.Size = new System.Drawing.Size(100, 20);
            this.txtUzunKenar.TabIndex = 2;
            // 
            // checkAlan
            // 
            this.checkAlan.AutoSize = true;
            this.checkAlan.Location = new System.Drawing.Point(312, 33);
            this.checkAlan.Name = "checkAlan";
            this.checkAlan.Size = new System.Drawing.Size(47, 17);
            this.checkAlan.TabIndex = 3;
            this.checkAlan.Text = "Alan";
            this.checkAlan.UseVisualStyleBackColor = true;
            // 
            // checkCevre
            // 
            this.checkCevre.AutoSize = true;
            this.checkCevre.Location = new System.Drawing.Point(312, 67);
            this.checkCevre.Name = "checkCevre";
            this.checkCevre.Size = new System.Drawing.Size(54, 17);
            this.checkCevre.TabIndex = 4;
            this.checkCevre.Text = "Çevre";
            this.checkCevre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kısa Kenar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uzun Kenar";
            // 
            // AlanCevreSonuc
            // 
            this.AlanCevreSonuc.AutoSize = true;
            this.AlanCevreSonuc.Location = new System.Drawing.Point(39, 135);
            this.AlanCevreSonuc.Name = "AlanCevreSonuc";
            this.AlanCevreSonuc.Size = new System.Drawing.Size(0, 13);
            this.AlanCevreSonuc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.AlanCevreSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkCevre);
            this.Controls.Add(this.checkAlan);
            this.Controls.Add(this.txtUzunKenar);
            this.Controls.Add(this.txtKisaKenar);
            this.Controls.Add(this.hesaplabuton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabuton;
        private System.Windows.Forms.TextBox txtKisaKenar;
        private System.Windows.Forms.TextBox txtUzunKenar;
        private System.Windows.Forms.CheckBox checkAlan;
        private System.Windows.Forms.CheckBox checkCevre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AlanCevreSonuc;
    }
}

