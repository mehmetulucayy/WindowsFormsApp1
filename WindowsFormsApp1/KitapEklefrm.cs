using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApp1
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }

        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);

        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitap(barkodno,kitapadi,yazari,yayınevi,sayfasiyisi,turu,stoksayisi,rafno,aciklama,kayittarihi) values(@barkodno,@kitapadi,@yazari,@yayınevi,@sayfasiyisi,@turu,@stoksayisi,@rafno,@aciklama,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@yayınevi", txtYayinEvi.Text);
            komut.Parameters.AddWithValue("@sayfasiyisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAçiklama.Text);
            komut.Parameters.AddWithValue("@kayittarihi", DateTime.Now.ToShortDateString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kayıt İşlemi Yapıldı");


        }
    }
}
