
namespace AlanCevre2
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
            this.checkUcgen = new System.Windows.Forms.CheckBox();
            this.checkKare = new System.Windows.Forms.CheckBox();
            this.checkAlan = new System.Windows.Forms.CheckBox();
            this.checkCevre = new System.Windows.Forms.CheckBox();
            this.lblgizli1 = new System.Windows.Forms.Label();
            this.lblgizli2 = new System.Windows.Forms.Label();
            this.txtgizli1 = new System.Windows.Forms.TextBox();
            this.txtgizli2 = new System.Windows.Forms.TextBox();
            this.lblgizli3 = new System.Windows.Forms.Label();
            this.txtgizli3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkUcgen
            // 
            this.checkUcgen.AutoSize = true;
            this.checkUcgen.Location = new System.Drawing.Point(63, 87);
            this.checkUcgen.Name = "checkUcgen";
            this.checkUcgen.Size = new System.Drawing.Size(58, 17);
            this.checkUcgen.TabIndex = 0;
            this.checkUcgen.Text = "Üçgen";
            this.checkUcgen.UseVisualStyleBackColor = true;
            this.checkUcgen.CheckedChanged += new System.EventHandler(this.checkUcgen_CheckedChanged);
            // 
            // checkKare
            // 
            this.checkKare.AutoSize = true;
            this.checkKare.Location = new System.Drawing.Point(63, 141);
            this.checkKare.Name = "checkKare";
            this.checkKare.Size = new System.Drawing.Size(48, 17);
            this.checkKare.TabIndex = 1;
            this.checkKare.Text = "Kare";
            this.checkKare.UseVisualStyleBackColor = true;
            // 
            // checkAlan
            // 
            this.checkAlan.AutoSize = true;
            this.checkAlan.Location = new System.Drawing.Point(557, 87);
            this.checkAlan.Name = "checkAlan";
            this.checkAlan.Size = new System.Drawing.Size(47, 17);
            this.checkAlan.TabIndex = 2;
            this.checkAlan.Text = "Alan";
            this.checkAlan.UseVisualStyleBackColor = true;
            // 
            // checkCevre
            // 
            this.checkCevre.AutoSize = true;
            this.checkCevre.Location = new System.Drawing.Point(557, 141);
            this.checkCevre.Name = "checkCevre";
            this.checkCevre.Size = new System.Drawing.Size(54, 17);
            this.checkCevre.TabIndex = 3;
            this.checkCevre.Text = "Çevre";
            this.checkCevre.UseVisualStyleBackColor = true;
            // 
            // lblgizli1
            // 
            this.lblgizli1.AutoSize = true;
            this.lblgizli1.Location = new System.Drawing.Point(247, 98);
            this.lblgizli1.Name = "lblgizli1";
            this.lblgizli1.Size = new System.Drawing.Size(35, 13);
            this.lblgizli1.TabIndex = 4;
            this.lblgizli1.Text = "label1";
            // 
            // lblgizli2
            // 
            this.lblgizli2.AutoSize = true;
            this.lblgizli2.Location = new System.Drawing.Point(247, 148);
            this.lblgizli2.Name = "lblgizli2";
            this.lblgizli2.Size = new System.Drawing.Size(35, 13);
            this.lblgizli2.TabIndex = 5;
            this.lblgizli2.Text = "label2";
            // 
            // txtgizli1
            // 
            this.txtgizli1.Location = new System.Drawing.Point(353, 98);
            this.txtgizli1.Name = "txtgizli1";
            this.txtgizli1.Size = new System.Drawing.Size(100, 20);
            this.txtgizli1.TabIndex = 6;
            // 
            // txtgizli2
            // 
            this.txtgizli2.Location = new System.Drawing.Point(353, 148);
            this.txtgizli2.Name = "txtgizli2";
            this.txtgizli2.Size = new System.Drawing.Size(100, 20);
            this.txtgizli2.TabIndex = 7;
            // 
            // lblgizli3
            // 
            this.lblgizli3.AutoSize = true;
            this.lblgizli3.Location = new System.Drawing.Point(247, 196);
            this.lblgizli3.Name = "lblgizli3";
            this.lblgizli3.Size = new System.Drawing.Size(35, 13);
            this.lblgizli3.TabIndex = 8;
            this.lblgizli3.Text = "label3";
            // 
            // txtgizli3
            // 
            this.txtgizli3.Location = new System.Drawing.Point(353, 193);
            this.txtgizli3.Name = "txtgizli3";
            this.txtgizli3.Size = new System.Drawing.Size(100, 20);
            this.txtgizli3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 356);
            this.Controls.Add(this.txtgizli3);
            this.Controls.Add(this.lblgizli3);
            this.Controls.Add(this.txtgizli2);
            this.Controls.Add(this.txtgizli1);
            this.Controls.Add(this.lblgizli2);
            this.Controls.Add(this.lblgizli1);
            this.Controls.Add(this.checkCevre);
            this.Controls.Add(this.checkAlan);
            this.Controls.Add(this.checkKare);
            this.Controls.Add(this.checkUcgen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkUcgen;
        private System.Windows.Forms.CheckBox checkKare;
        private System.Windows.Forms.CheckBox checkAlan;
        private System.Windows.Forms.CheckBox checkCevre;
        private System.Windows.Forms.Label lblgizli1;
        private System.Windows.Forms.Label lblgizli2;
        private System.Windows.Forms.TextBox txtgizli1;
        private System.Windows.Forms.TextBox txtgizli2;
        private System.Windows.Forms.Label lblgizli3;
        private System.Windows.Forms.TextBox txtgizli3;
    }
}

