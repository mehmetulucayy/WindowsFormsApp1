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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class KitapListelefrm : Form
    {
        public KitapListelefrm()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        DataSet daset = new DataSet();  
        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
        private void KitapListelefrm_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kayıtı silmek mi istiyorsunuz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlekmi Gerçekleişti");
                daset.Tables["Kitap"].Clear();
                kitaplistele();
                foreach (Control item in Controls)
                {

                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Kitap  set kitapadi=@kitapadi,yazari=@yazari,yayınevi=@yayınevi,sayfasiyisi=@sayfasiyisi,turu=@turu,stoksayisi=@stoksayisi,rafno=@rafno,aciklama=@aciklama where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazari.Text);
            komut.Parameters.AddWithValue("@sayfasiyisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@turu", comboTuru.Text);
            komut.Parameters.AddWithValue("@stoksayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@rafno", txtRafNo.Text);
            komut.Parameters.AddWithValue("@aciklama", txtAçiklama.Text);
            komut.Parameters.AddWithValue("@yayınevi", txtYayinEvi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlekmi Gerçekleişti");
            daset.Tables["Kitap"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {

                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void TxtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["Kitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Kitap where barkodno like'%" + TxtBarkodAra.Text + "%'", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kitap where barkodno like'" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {

                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazari.Text = read["yazari"].ToString();
                txtYayinEvi.Text = read["yayınevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasiyisi"].ToString();
                comboTuru.Text = read["turu"].ToString();
                txtStokSayisi.Text = read["stoksayisi"].ToString();
                txtRafNo.Text = read["rafno"].ToString();
                txtAçiklama.Text = read["aciklama"].ToString();



            }
            baglanti.Close();
        }
    }
}
