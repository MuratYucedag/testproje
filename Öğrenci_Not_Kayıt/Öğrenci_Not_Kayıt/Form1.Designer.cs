namespace Öğrenci_Not_Kayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnOgretmenGiris = new System.Windows.Forms.Button();
            this.TxtOgretmenSifre = new System.Windows.Forms.TextBox();
            this.MskOgretmenNumara = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.TxtOGrenciSifre = new System.Windows.Forms.TextBox();
            this.MskOgrenciNumara = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnOgretmenGiris);
            this.groupBox1.Controls.Add(this.TxtOgretmenSifre);
            this.groupBox1.Controls.Add(this.MskOgretmenNumara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen";
            // 
            // BtnOgretmenGiris
            // 
            this.BtnOgretmenGiris.Location = new System.Drawing.Point(226, 93);
            this.BtnOgretmenGiris.Name = "BtnOgretmenGiris";
            this.BtnOgretmenGiris.Size = new System.Drawing.Size(119, 32);
            this.BtnOgretmenGiris.TabIndex = 5;
            this.BtnOgretmenGiris.Text = "Giriş Yap";
            this.BtnOgretmenGiris.UseVisualStyleBackColor = true;
            this.BtnOgretmenGiris.Click += new System.EventHandler(this.BtnOgretmenGiris_Click);
            // 
            // TxtOgretmenSifre
            // 
            this.TxtOgretmenSifre.Location = new System.Drawing.Point(226, 63);
            this.TxtOgretmenSifre.Name = "TxtOgretmenSifre";
            this.TxtOgretmenSifre.Size = new System.Drawing.Size(119, 24);
            this.TxtOgretmenSifre.TabIndex = 4;
            this.TxtOgretmenSifre.UseSystemPasswordChar = true;
            // 
            // MskOgretmenNumara
            // 
            this.MskOgretmenNumara.Location = new System.Drawing.Point(226, 29);
            this.MskOgretmenNumara.Mask = "0000";
            this.MskOgretmenNumara.Name = "MskOgretmenNumara";
            this.MskOgretmenNumara.Size = new System.Drawing.Size(119, 24);
            this.MskOgretmenNumara.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnOgrenciGiris);
            this.groupBox2.Controls.Add(this.TxtOGrenciSifre);
            this.groupBox2.Controls.Add(this.MskOgrenciNumara);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(19, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 149);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci";
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(226, 93);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(119, 32);
            this.BtnOgrenciGiris.TabIndex = 5;
            this.BtnOgrenciGiris.Text = "Giriş Yap";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = true;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // TxtOGrenciSifre
            // 
            this.TxtOGrenciSifre.Location = new System.Drawing.Point(226, 63);
            this.TxtOGrenciSifre.Name = "TxtOGrenciSifre";
            this.TxtOGrenciSifre.Size = new System.Drawing.Size(119, 24);
            this.TxtOGrenciSifre.TabIndex = 4;
            this.TxtOGrenciSifre.UseSystemPasswordChar = true;
            // 
            // MskOgrenciNumara
            // 
            this.MskOgrenciNumara.Location = new System.Drawing.Point(226, 29);
            this.MskOgrenciNumara.Mask = "0000";
            this.MskOgrenciNumara.Name = "MskOgrenciNumara";
            this.MskOgrenciNumara.Size = new System.Drawing.Size(119, 24);
            this.MskOgrenciNumara.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numara:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(403, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Öğrenci Not Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnOgretmenGiris;
        private System.Windows.Forms.TextBox TxtOgretmenSifre;
        private System.Windows.Forms.MaskedTextBox MskOgretmenNumara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnOgrenciGiris;
        private System.Windows.Forms.TextBox TxtOGrenciSifre;
        private System.Windows.Forms.MaskedTextBox MskOgrenciNumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

