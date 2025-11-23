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
    public partial class EmanetKitapİadefrm : Form
    {
        public EmanetKitapİadefrm()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        DataSet daset = new DataSet();

        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["tc"].HeaderText = "TC KIMLIK NO";
                dataGridView1.Columns["adsoyad"].HeaderText = "AD SOYAD";
                dataGridView1.Columns["yas"].HeaderText = "YAŞ";
                dataGridView1.Columns["telefon"].HeaderText = "TELEFON";
                dataGridView1.Columns["barkodno"].HeaderText = "BARKOD NO";
                dataGridView1.Columns["kitapadi"].HeaderText = "KITAP ADI";
                dataGridView1.Columns["yazari"].HeaderText = "YAZAR";
                dataGridView1.Columns["yayinevi"].HeaderText = "YAYIN EVI";
                dataGridView1.Columns["sayfasayisi"].HeaderText = "SAYFA SAYISI";
                dataGridView1.Columns["kitapsayisi"].HeaderText = "KITAP SAYISI";
                dataGridView1.Columns["teslimtarihi"].HeaderText = "TESLİM TARİHİ";
                dataGridView1.Columns["iadetarihi"].HeaderText = "İADE TARİHİ";
            }
            
            baglanti.Close();
        }
        private void EmanetKitapİadefrm_Load(object sender, EventArgs e)
        {
        emanetlistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr =  new SqlDataAdapter("select *from EmanetKitaplar where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["tc"].HeaderText = "TC KIMLIK NO";
                dataGridView1.Columns["adsoyad"].HeaderText = "AD SOYAD";
                dataGridView1.Columns["yas"].HeaderText = "YAŞ";
                dataGridView1.Columns["telefon"].HeaderText = "TELEFON";
                dataGridView1.Columns["barkodno"].HeaderText = "BARKOD NO";
                dataGridView1.Columns["kitapadi"].HeaderText = "KITAP ADI";
                dataGridView1.Columns["yazari"].HeaderText = "YAZAR";
                dataGridView1.Columns["yayinevi"].HeaderText = "YAYIN EVI";
                dataGridView1.Columns["sayfasayisi"].HeaderText = "SAYFA SAYISI";
                dataGridView1.Columns["kitapsayisi"].HeaderText = "KITAP SAYISI";
                dataGridView1.Columns["teslimtarihi"].HeaderText = "TESLİM TARİHİ";
                dataGridView1.Columns["iadetarihi"].HeaderText = "İADE TARİHİ";
            }
            
            baglanti.Close();
            if (txtTcAra.Text=="")
            {
                daset.Tables["Emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where barkodno like '%" + txtBarkodNo.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["tc"].HeaderText = "TC KIMLIK NO";
                dataGridView1.Columns["adsoyad"].HeaderText = "AD SOYAD";
                dataGridView1.Columns["yas"].HeaderText = "YAŞ";
                dataGridView1.Columns["telefon"].HeaderText = "TELEFON";
                dataGridView1.Columns["barkodno"].HeaderText = "BARKOD NO";
                dataGridView1.Columns["kitapadi"].HeaderText = "KITAP ADI";
                dataGridView1.Columns["yazari"].HeaderText = "YAZAR";
                dataGridView1.Columns["yayinevi"].HeaderText = "YAYIN EVI";
                dataGridView1.Columns["sayfasayisi"].HeaderText = "SAYFA SAYISI";
                dataGridView1.Columns["kitapsayisi"].HeaderText = "KITAP SAYISI";
                dataGridView1.Columns["teslimtarihi"].HeaderText = "TESLİM TARİHİ";
                dataGridView1.Columns["iadetarihi"].HeaderText = "İADE TARİHİ";
            }
            
            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                daset.Tables["Emanetkitaplar"].Clear();
                emanetlistele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Emanetkitaplar where tc=@tc and barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi+'" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString()+"'where barkodno=@barkodno",baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            MessageBox.Show("Kitaplar iade edildi");
            baglanti.Close();
            daset.Tables["Emanetkitaplar"].Clear();
            emanetlistele();
        }
    }
}
