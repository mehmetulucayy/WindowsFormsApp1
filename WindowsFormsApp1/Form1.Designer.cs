namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelRaporlar = new System.Windows.Forms.Panel();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSırala = new System.Windows.Forms.Button();
            this.lblRaporlar = new System.Windows.Forms.Label();
            this.panelEmanet = new System.Windows.Forms.Panel();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetKitap = new System.Windows.Forms.Button();
            this.lblEmanet = new System.Windows.Forms.Label();
            this.panelKitap = new System.Windows.Forms.Panel();
            this.btnKitapLisete = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lblKitap = new System.Windows.Forms.Label();
            this.panelUye = new System.Windows.Forms.Panel();
            this.btnÜyeListe = new System.Windows.Forms.Button();
            this.btnÜyeEkle = new System.Windows.Forms.Button();
            this.lblUye = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelRaporlar.SuspendLayout();
            this.panelEmanet.SuspendLayout();
            this.panelKitap.SuspendLayout();
            this.panelUye.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.lblWelcome);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblWelcome.Location = new System.Drawing.Point(900, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "👋 Hoş Geldiniz, Yönetici";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(25, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(369, 37);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Kütüphane Yönetim Sistemi";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.panelRaporlar);
            this.panelContent.Controls.Add(this.panelEmanet);
            this.panelContent.Controls.Add(this.panelKitap);
            this.panelContent.Controls.Add(this.panelUye);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(1200, 600);
            this.panelContent.TabIndex = 1;
            // 
            // panelRaporlar
            // 
            this.panelRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.panelRaporlar.Controls.Add(this.btnGrafik);
            this.panelRaporlar.Controls.Add(this.btnSırala);
            this.panelRaporlar.Controls.Add(this.lblRaporlar);
            this.panelRaporlar.Location = new System.Drawing.Point(630, 330);
            this.panelRaporlar.Name = "panelRaporlar";
            this.panelRaporlar.Size = new System.Drawing.Size(540, 240);
            this.panelRaporlar.TabIndex = 3;
            // 
            // btnGrafik
            // 
            this.btnGrafik.BackColor = System.Drawing.Color.White;
            this.btnGrafik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafik.FlatAppearance.BorderSize = 0;
            this.btnGrafik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGrafik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnGrafik.Location = new System.Drawing.Point(280, 80);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(230, 50);
            this.btnGrafik.TabIndex = 2;
            this.btnGrafik.Text = "📊 Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = false;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // btnSırala
            // 
            this.btnSırala.BackColor = System.Drawing.Color.White;
            this.btnSırala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSırala.FlatAppearance.BorderSize = 0;
            this.btnSırala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSırala.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSırala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnSırala.Location = new System.Drawing.Point(30, 80);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(230, 50);
            this.btnSırala.TabIndex = 1;
            this.btnSırala.Text = "🔢 Sıralama";
            this.btnSırala.UseVisualStyleBackColor = false;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // lblRaporlar
            // 
            this.lblRaporlar.AutoSize = true;
            this.lblRaporlar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblRaporlar.ForeColor = System.Drawing.Color.White;
            this.lblRaporlar.Location = new System.Drawing.Point(25, 25);
            this.lblRaporlar.Name = "lblRaporlar";
            this.lblRaporlar.Size = new System.Drawing.Size(240, 30);
            this.lblRaporlar.TabIndex = 0;
            this.lblRaporlar.Text = "Raporlar ve Grafikler";
            // 
            // panelEmanet
            // 
            this.panelEmanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelEmanet.Controls.Add(this.btnEmanetİade);
            this.panelEmanet.Controls.Add(this.btnEmanetListele);
            this.panelEmanet.Controls.Add(this.btnEmanetKitap);
            this.panelEmanet.Controls.Add(this.lblEmanet);
            this.panelEmanet.Location = new System.Drawing.Point(30, 330);
            this.panelEmanet.Name = "panelEmanet";
            this.panelEmanet.Size = new System.Drawing.Size(570, 240);
            this.panelEmanet.TabIndex = 2;
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.BackColor = System.Drawing.Color.White;
            this.btnEmanetİade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetİade.FlatAppearance.BorderSize = 0;
            this.btnEmanetİade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetİade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEmanetİade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEmanetİade.Location = new System.Drawing.Point(30, 170);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(510, 50);
            this.btnEmanetİade.TabIndex = 3;
            this.btnEmanetİade.Text = "↩️ Emanet İade";
            this.btnEmanetİade.UseVisualStyleBackColor = false;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.BackColor = System.Drawing.Color.White;
            this.btnEmanetListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetListele.FlatAppearance.BorderSize = 0;
            this.btnEmanetListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetListele.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEmanetListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEmanetListele.Location = new System.Drawing.Point(280, 100);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(260, 50);
            this.btnEmanetListele.TabIndex = 2;
            this.btnEmanetListele.Text = "📋 Emanet Listeleme";
            this.btnEmanetListele.UseVisualStyleBackColor = false;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetKitap
            // 
            this.btnEmanetKitap.BackColor = System.Drawing.Color.White;
            this.btnEmanetKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetKitap.FlatAppearance.BorderSize = 0;
            this.btnEmanetKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetKitap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEmanetKitap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEmanetKitap.Location = new System.Drawing.Point(30, 100);
            this.btnEmanetKitap.Name = "btnEmanetKitap";
            this.btnEmanetKitap.Size = new System.Drawing.Size(230, 50);
            this.btnEmanetKitap.TabIndex = 1;
            this.btnEmanetKitap.Text = "📤 Emanet Kitap Verme";
            this.btnEmanetKitap.UseVisualStyleBackColor = false;
            this.btnEmanetKitap.Click += new System.EventHandler(this.btnEmanetKitap_Click);
            // 
            // lblEmanet
            // 
            this.lblEmanet.AutoSize = true;
            this.lblEmanet.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEmanet.ForeColor = System.Drawing.Color.White;
            this.lblEmanet.Location = new System.Drawing.Point(25, 25);
            this.lblEmanet.Name = "lblEmanet";
            this.lblEmanet.Size = new System.Drawing.Size(238, 30);
            this.lblEmanet.TabIndex = 0;
            this.lblEmanet.Text = "Emanet Kitap İşlemleri";
            // 
            // panelKitap
            // 
            this.panelKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelKitap.Controls.Add(this.btnKitapLisete);
            this.panelKitap.Controls.Add(this.btnKitapEkle);
            this.panelKitap.Controls.Add(this.lblKitap);
            this.panelKitap.Location = new System.Drawing.Point(630, 30);
            this.panelKitap.Name = "panelKitap";
            this.panelKitap.Size = new System.Drawing.Size(540, 270);
            this.panelKitap.TabIndex = 1;
            // 
            // btnKitapLisete
            // 
            this.btnKitapLisete.BackColor = System.Drawing.Color.White;
            this.btnKitapLisete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapLisete.FlatAppearance.BorderSize = 0;
            this.btnKitapLisete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapLisete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKitapLisete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnKitapLisete.Location = new System.Drawing.Point(30, 160);
            this.btnKitapLisete.Name = "btnKitapLisete";
            this.btnKitapLisete.Size = new System.Drawing.Size(480, 50);
            this.btnKitapLisete.TabIndex = 2;
            this.btnKitapLisete.Text = "📚 Kitap Listeleme";
            this.btnKitapLisete.UseVisualStyleBackColor = false;
            this.btnKitapLisete.Click += new System.EventHandler(this.btnKitapLisete_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.Color.White;
            this.btnKitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapEkle.FlatAppearance.BorderSize = 0;
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKitapEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnKitapEkle.Location = new System.Drawing.Point(30, 90);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(480, 50);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "➕ Kitap Ekleme";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKitap.ForeColor = System.Drawing.Color.White;
            this.lblKitap.Location = new System.Drawing.Point(25, 25);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(162, 30);
            this.lblKitap.TabIndex = 0;
            this.lblKitap.Text = "Kitap İşlemleri";
            // 
            // panelUye
            // 
            this.panelUye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panelUye.Controls.Add(this.btnÜyeListe);
            this.panelUye.Controls.Add(this.btnÜyeEkle);
            this.panelUye.Controls.Add(this.lblUye);
            this.panelUye.Location = new System.Drawing.Point(30, 30);
            this.panelUye.Name = "panelUye";
            this.panelUye.Size = new System.Drawing.Size(570, 270);
            this.panelUye.TabIndex = 0;
            // 
            // btnÜyeListe
            // 
            this.btnÜyeListe.BackColor = System.Drawing.Color.White;
            this.btnÜyeListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeListe.FlatAppearance.BorderSize = 0;
            this.btnÜyeListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜyeListe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnÜyeListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnÜyeListe.Location = new System.Drawing.Point(30, 160);
            this.btnÜyeListe.Name = "btnÜyeListe";
            this.btnÜyeListe.Size = new System.Drawing.Size(510, 50);
            this.btnÜyeListe.TabIndex = 2;
            this.btnÜyeListe.Text = "👥 Üye Listeleme";
            this.btnÜyeListe.UseVisualStyleBackColor = false;
            this.btnÜyeListe.Click += new System.EventHandler(this.btnÜyeListe_Click);
            // 
            // btnÜyeEkle
            // 
            this.btnÜyeEkle.BackColor = System.Drawing.Color.White;
            this.btnÜyeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnÜyeEkle.FlatAppearance.BorderSize = 0;
            this.btnÜyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnÜyeEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnÜyeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnÜyeEkle.Location = new System.Drawing.Point(30, 90);
            this.btnÜyeEkle.Name = "btnÜyeEkle";
            this.btnÜyeEkle.Size = new System.Drawing.Size(510, 50);
            this.btnÜyeEkle.TabIndex = 1;
            this.btnÜyeEkle.Text = "➕ Üye Ekleme";
            this.btnÜyeEkle.UseVisualStyleBackColor = false;
            this.btnÜyeEkle.Click += new System.EventHandler(this.btnÜyeEkle_Click);
            // 
            // lblUye
            // 
            this.lblUye.AutoSize = true;
            this.lblUye.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblUye.ForeColor = System.Drawing.Color.White;
            this.lblUye.Location = new System.Drawing.Point(25, 25);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(149, 30);
            this.lblUye.TabIndex = 0;
            this.lblUye.Text = "Üye İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Yönetim Sistemi - Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelRaporlar.ResumeLayout(false);
            this.panelRaporlar.PerformLayout();
            this.panelEmanet.ResumeLayout(false);
            this.panelEmanet.PerformLayout();
            this.panelKitap.ResumeLayout(false);
            this.panelKitap.PerformLayout();
            this.panelUye.ResumeLayout(false);
            this.panelUye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelUye;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.Button btnÜyeEkle;
        private System.Windows.Forms.Button btnÜyeListe;
        private System.Windows.Forms.Panel panelKitap;
        private System.Windows.Forms.Button btnKitapLisete;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Panel panelEmanet;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetKitap;
        private System.Windows.Forms.Label lblEmanet;
        private System.Windows.Forms.Panel panelRaporlar;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.Label lblRaporlar;
    }
}

