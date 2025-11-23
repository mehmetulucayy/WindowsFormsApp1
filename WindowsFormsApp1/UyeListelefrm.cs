using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UyeListelefrm : Form
    {
        public UyeListelefrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTC.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;");


        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from UYE where tc like'"+txtTC.Text+"'", baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                comcoCinsiyet.Text = read["cinsiyet"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
                txtAdres.Text = read["adres"].ToString();
                txtEmail.Text = read["email"].ToString();
                txtOkunanSayi.Text = read["okukitapsayisi"].ToString();

            }
            baglanti.Close();

             
        }
        DataSet daset = new DataSet();
        private void txtAraTc_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["UYE"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYE where tc like'%" + txtAraTc.Text + "%'", baglanti);
            adtr.Fill(daset,"UYE");
            dataGridView1.DataSource = daset.Tables["UYE"];
            
            // Kolon başlıklarını düzenle
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["tc"].HeaderText = "TC KIMLIK NO";
                dataGridView1.Columns["adsoyad"].HeaderText = "AD SOYAD";
                dataGridView1.Columns["yas"].HeaderText = "YAŞ";
                dataGridView1.Columns["cinsiyet"].HeaderText = "CINSIYET";
                dataGridView1.Columns["telefon"].HeaderText = "TELEFON";
                dataGridView1.Columns["adres"].HeaderText = "ADRES";
                dataGridView1.Columns["email"].HeaderText = "E-MAIL";
                dataGridView1.Columns["okukitapsayisi"].HeaderText = "OKUNAN KITAP SAYISI";
            }
            
            baglanti.Close() ;
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kayıtı silmek mi istiyorsunuz ?","Sil" ,MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog==DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from UYE where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlekmi Gerçekleişti");
                daset.Tables["UYE"].Clear();
                uyelistele();
                foreach (Control item in panelLeft.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            
        }
        private void uyelistele()
        {
            baglanti.Open() ;
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYE", baglanti);
            adtr.Fill(daset, "UYE");
            dataGridView1.DataSource = daset.Tables["UYE"];
            
            // Kolon başlıklarını düzenle
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["tc"].HeaderText = "TC KIMLIK NO";
                dataGridView1.Columns["adsoyad"].HeaderText = "AD SOYAD";
                dataGridView1.Columns["yas"].HeaderText = "YAŞ";
                dataGridView1.Columns["cinsiyet"].HeaderText = "CINSIYET";
                dataGridView1.Columns["telefon"].HeaderText = "TELEFON";
                dataGridView1.Columns["adres"].HeaderText = "ADRES";
                dataGridView1.Columns["email"].HeaderText = "E-MAIL";
                dataGridView1.Columns["okukitapsayisi"].HeaderText = "OKUNAN KITAP SAYISI";
            }
            
            baglanti.Close() ;
        }

        private void UyeListelefrm_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int okunanSayi;
            if (!int.TryParse(txtOkunanSayi.Text, out okunanSayi))
            {
                MessageBox.Show("Okunan kitap sayısı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update UYE set adsoyad=@adsoyad, yas=@yas, cinsiyet=@cinsiyet, telefon=@telefon, adres=@adres, email=@email, okukitapsayisi=@okukitapsayisi where tc=@tc", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@yas", txtYas.Text);
                komut.Parameters.AddWithValue("@cinsiyet", comcoCinsiyet.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", txtAdres.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@okukitapsayisi", okunanSayi);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Güncelleme İşlemi Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                daset.Tables["UYE"].Clear();
                uyelistele();
                foreach (Control item in panelLeft.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

    }
}
