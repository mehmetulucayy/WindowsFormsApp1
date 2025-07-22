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
    public partial class EmanetKitapVerfrm : Form
    {
        public EmanetKitapVerfrm()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        DataSet daset = new DataSet();

        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr=new SqlDataAdapter("select *from sepet",baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();


        }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapEvi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinEvi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", txtKitapSayisi.Text);
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitaplar sepete eklendi", "Ekleme işlemi yapıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            lblKitapSayı.Text = "";
            kitapsayisi();
            foreach (Control item in grpKitapBilgi.Controls )
            {
                if (item is TextBox)
                {
                    if (item!=txtKitapSayisi)
                    {
                        item.Text = "";
                    }
                }
            }
        }
        private void kitapsayisi()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from sepet", baglanti);
            lblKitapSayı.Text=komut.ExecuteScalar().ToString();
            baglanti.Close() ;


        }
        private void EmanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            sepetlistele();
            kitapsayisi();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from UYE where tc like '"+ textBox1.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            { 
            txtAdSoyad.Text = read["adsoyad"].ToString();
            txtYas.Text = read["yas"].ToString();
            txtTelefon.Text = read["telefon"].ToString();

            }
            baglanti.Close() ;

            baglanti.Open() ;
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar", baglanti);
            lblKayitliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                foreach (Control  item in grpUyeBilgi.Controls)

                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                        lblKayitliKitapSayi.Text = "";
                    }
                    

                }
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open() ;
            SqlCommand komut = new SqlCommand("select *from Kitap where barkodno like '"+txtBarkodNo.Text+"'" ,baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                txtKitapEvi.Text = read["kitapadi"].ToString() ;
                txtYazar.Text = read["yazari"].ToString();
                txtYayinEvi.Text = read["yayınevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();
              


            }
            baglanti.Close();
            if (txtBarkodNo.Text=="")
            {

            
            foreach (Control item in grpKitapBilgi.Controls)
            {
                    if (item is TextBox)
                    {
                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";
                        }
                    }


                }
            }

            
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close() ;
            MessageBox.Show("Silme İşlemi Gerkçeleştirildi", "Silme İşlemi");
            daset.Tables["sepet"].Clear();
            lblKitapSayı.Text = "";
            kitapsayisi();
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayı.Text != "")
            {
                int kayitliKitapSayisi = string.IsNullOrEmpty(lblKayitliKitapSayi.Text) ? 0 : int.Parse(lblKayitliKitapSayi.Text);
                int yeniKitapSayisi = int.Parse(lblKitapSayı.Text);

                if ((kayitliKitapSayisi == 0 && yeniKitapSayisi <= 3) || (kayitliKitapSayisi + yeniKitapSayisi <= 3))
                {
                    if (!string.IsNullOrEmpty(txtTcAra.Text) && !string.IsNullOrEmpty(txtAdSoyad.Text) && !string.IsNullOrEmpty(txtYas.Text) && !string.IsNullOrEmpty(txtTelefon.Text))
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc,adsoyad,yas,telefon,barkodno,kitapadi,yazari,yayinevi,sayfasayisi,kitapsayisi,teslimtarihi,iadetarihi) values(@tc,@adsoyad,@yas,@telefon,@barkodno,@kitapadi,@yazari,@yayinevi,@sayfasayisi,@kitapsayisi,@teslimtarihi,@iadetarihi)", baglanti);
                            komut.Parameters.AddWithValue("@tc", txtTcAra.Text);
                            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                            komut.Parameters.AddWithValue("@yas", txtYas.Text);
                            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                            komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                            komut.Parameters.AddWithValue("@yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                            komut.Parameters.AddWithValue("@yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                            komut.Parameters.AddWithValue("@sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@kitapsayisi", dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString());
                            komut.Parameters.AddWithValue("@teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                            komut.Parameters.AddWithValue("@iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                            komut.ExecuteNonQuery();

                            SqlCommand komut2 = new SqlCommand("update UYE set okukitapsayisi=okukitapsayisi+@kitapsayisi where tc=@tc", baglanti);
                            komut2.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut2.Parameters.AddWithValue("@tc", txtTcAra.Text);
                            komut2.ExecuteNonQuery();

                            SqlCommand komut3 = new SqlCommand("update kitap set stoksayisi=stoksayisi-@kitapsayisi where barkodno=@barkodno", baglanti);
                            komut3.Parameters.AddWithValue("@kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut3.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut3.ExecuteNonQuery();

                            baglanti.Close();
                        }

                        baglanti.Open();
                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti);
                        komut4.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kitaplar Emanet Edildi");

                        daset.Tables["sepet"].Clear();
                        sepetlistele();
                        txtTcAra.Text = "";
                        lblKitapSayı.Text = "";
                        kitapsayisi();
                        lblKayitliKitapSayi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Üye İsmi Seçmeniz Gerekir", "Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Emanet Kitap Sayısı 3'ten Fazla Olamaz", "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Önce Sepete Kitap Eklenme İşlemini Yapınız", "Uyarı");
            }

            lblKitapSayı.Text = "";
            kitapsayisi();
        }

    }
}
