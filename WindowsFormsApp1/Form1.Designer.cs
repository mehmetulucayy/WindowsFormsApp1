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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnÜyeListe = new System.Windows.Forms.Button();
            this.btnÜyeEkle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapLisete = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetKitap = new System.Windows.Forms.Button();
            this.btnSırala = new System.Windows.Forms.Button();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnÜyeListe);
            this.groupBox1.Controls.Add(this.btnÜyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(79, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            // 
            // btnÜyeListe
            // 
            this.btnÜyeListe.Location = new System.Drawing.Point(31, 64);
            this.btnÜyeListe.Name = "btnÜyeListe";
            this.btnÜyeListe.Size = new System.Drawing.Size(234, 23);
            this.btnÜyeListe.TabIndex = 1;
            this.btnÜyeListe.Text = "Üye Listeleme";
            this.btnÜyeListe.UseVisualStyleBackColor = true;
            this.btnÜyeListe.Click += new System.EventHandler(this.btnÜyeListe_Click);
            // 
            // btnÜyeEkle
            // 
            this.btnÜyeEkle.Location = new System.Drawing.Point(31, 35);
            this.btnÜyeEkle.Name = "btnÜyeEkle";
            this.btnÜyeEkle.Size = new System.Drawing.Size(234, 23);
            this.btnÜyeEkle.TabIndex = 0;
            this.btnÜyeEkle.Text = "Üye Ekleme ";
            this.btnÜyeEkle.UseVisualStyleBackColor = true;
            this.btnÜyeEkle.Click += new System.EventHandler(this.btnÜyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapLisete);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(537, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapLisete
            // 
            this.btnKitapLisete.Location = new System.Drawing.Point(32, 73);
            this.btnKitapLisete.Name = "btnKitapLisete";
            this.btnKitapLisete.Size = new System.Drawing.Size(234, 23);
            this.btnKitapLisete.TabIndex = 2;
            this.btnKitapLisete.Text = "Kitap Listeleme";
            this.btnKitapLisete.UseVisualStyleBackColor = true;
            this.btnKitapLisete.Click += new System.EventHandler(this.btnKitapLisete_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(32, 44);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(234, 23);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekleme";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetKitap);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(79, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 161);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.Location = new System.Drawing.Point(33, 95);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(234, 23);
            this.btnEmanetİade.TabIndex = 3;
            this.btnEmanetİade.Text = "Emanet İade";
            this.btnEmanetİade.UseVisualStyleBackColor = true;
            this.btnEmanetİade.Click += new System.EventHandler(this.btnEmanetİade_Click);
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Location = new System.Drawing.Point(33, 66);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(234, 23);
            this.btnEmanetListele.TabIndex = 2;
            this.btnEmanetListele.Text = "Emanet Listeleme";
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            this.btnEmanetListele.Click += new System.EventHandler(this.btnEmanetListele_Click);
            // 
            // btnEmanetKitap
            // 
            this.btnEmanetKitap.Location = new System.Drawing.Point(33, 37);
            this.btnEmanetKitap.Name = "btnEmanetKitap";
            this.btnEmanetKitap.Size = new System.Drawing.Size(234, 23);
            this.btnEmanetKitap.TabIndex = 1;
            this.btnEmanetKitap.Text = "Emanet Kitap Verme";
            this.btnEmanetKitap.UseVisualStyleBackColor = true;
            this.btnEmanetKitap.Click += new System.EventHandler(this.btnEmanetKitap_Click);
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(32, 48);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(234, 23);
            this.btnSırala.TabIndex = 2;
            this.btnSırala.Text = "Sıralama";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(32, 77);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(234, 23);
            this.btnGrafik.TabIndex = 3;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            this.btnGrafik.Click += new System.EventHandler(this.btnGrafik_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSırala);
            this.groupBox4.Location = new System.Drawing.Point(537, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 143);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 594);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnÜyeListe;
        private System.Windows.Forms.Button btnÜyeEkle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKitapLisete;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetKitap;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

