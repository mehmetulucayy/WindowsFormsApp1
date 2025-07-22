namespace WindowsFormsApp1
{
    partial class UyeListelefrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comcoCinsiyet = new System.Windows.Forms.ComboBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtOkunanSayi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAraTc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // comcoCinsiyet
            // 
            this.comcoCinsiyet.FormattingEnabled = true;
            this.comcoCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comcoCinsiyet.Location = new System.Drawing.Point(155, 200);
            this.comcoCinsiyet.Name = "comcoCinsiyet";
            this.comcoCinsiyet.Size = new System.Drawing.Size(100, 24);
            this.comcoCinsiyet.TabIndex = 37;
            // 
            // btniptal
            // 
            this.btniptal.Location = new System.Drawing.Point(180, 373);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(75, 23);
            this.btniptal.TabIndex = 36;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(67, 373);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 35;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(155, 118);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 34;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // txtOkunanSayi
            // 
            this.txtOkunanSayi.Location = new System.Drawing.Point(155, 314);
            this.txtOkunanSayi.Name = "txtOkunanSayi";
            this.txtOkunanSayi.Size = new System.Drawing.Size(100, 22);
            this.txtOkunanSayi.TabIndex = 33;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 286);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 32;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(155, 258);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 31;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(155, 230);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 30;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(155, 174);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 22);
            this.txtYas.TabIndex = 29;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(155, 146);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Okunan Kitap Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "E- Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "TC";
            // 
            // txtAraTc
            // 
            this.txtAraTc.Location = new System.Drawing.Point(488, 29);
            this.txtAraTc.Name = "txtAraTc";
            this.txtAraTc.Size = new System.Drawing.Size(160, 22);
            this.txtAraTc.TabIndex = 38;
            this.txtAraTc.TextChanged += new System.EventHandler(this.txtAraTc_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "TC Ara";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(781, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // UyeListelefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 493);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAraTc);
            this.Controls.Add(this.comcoCinsiyet);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtOkunanSayi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListelefrm";
            this.Text = "UyeListelefrm";
            this.Load += new System.EventHandler(this.UyeListelefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comcoCinsiyet;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtOkunanSayi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAraTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSil;
    }
}