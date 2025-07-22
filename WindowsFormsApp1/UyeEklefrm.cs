using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UyeEklefrm : Form
    {
        public UyeEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;");
        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into UYE(tc,adsoyad,yas,cinsiyet,telefon,adres,email,okukitapsayisi) values(@tc,@adsoyad,@yas,@cinsiyet,@telefon,@adres,@email,@okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@tc", txtTC.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comcoCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kayıt İşlemi Yapıldı");


          
            }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }
    }

    }

