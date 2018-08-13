namespace Öğrenci_Not_Kayıt
{
    partial class FrmMesjalar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RchMesaj = new System.Windows.Forms.RichTextBox();
            this.TxtKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskAlıcı = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskGonderen = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gelen Kutusu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giden Kutusu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(699, 203);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RchMesaj);
            this.groupBox1.Controls.Add(this.TxtKonu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskAlıcı);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskGonderen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 113);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(614, 28);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(91, 63);
            this.BtnGonder.TabIndex = 8;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesaj:";
            // 
            // RchMesaj
            // 
            this.RchMesaj.Location = new System.Drawing.Point(328, 17);
            this.RchMesaj.Name = "RchMesaj";
            this.RchMesaj.Size = new System.Drawing.Size(280, 81);
            this.RchMesaj.TabIndex = 6;
            this.RchMesaj.Text = "";
            // 
            // TxtKonu
            // 
            this.TxtKonu.Location = new System.Drawing.Point(93, 80);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Size = new System.Drawing.Size(134, 24);
            this.TxtKonu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu:";
            // 
            // MskAlıcı
            // 
            this.MskAlıcı.Location = new System.Drawing.Point(93, 47);
            this.MskAlıcı.Mask = "0000";
            this.MskAlıcı.Name = "MskAlıcı";
            this.MskAlıcı.Size = new System.Drawing.Size(134, 24);
            this.MskAlıcı.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alıcı:";
            // 
            // MskGonderen
            // 
            this.MskGonderen.Location = new System.Drawing.Point(93, 17);
            this.MskGonderen.Mask = "0000";
            this.MskGonderen.Name = "MskGonderen";
            this.MskGonderen.Size = new System.Drawing.Size(134, 24);
            this.MskGonderen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderen:";
            // 
            // FrmMesjalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(720, 364);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMesjalar";
            this.Text = "FrmMesjalar";
            this.Load += new System.EventHandler(this.FrmMesjalar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RchMesaj;
        private System.Windows.Forms.TextBox TxtKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskAlıcı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskGonderen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}