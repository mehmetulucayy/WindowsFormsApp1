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
    public partial class EmanetKitapListelefrm : Form
    {
        public EmanetKitapListelefrm()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        DataSet daset = new DataSet();
        private void EmanetKitapListelefrm_Load(object sender, EventArgs e)
        {
            daset = new DataSet();
            emanetlistele();
            comboBox1.SelectedIndex = 0;
        }

        private void emanetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            
            // Kolon başlıklarını düzenle
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                emanetlistele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "' > iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                
                // Kolon başlıklarını düzenle
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
            else if (comboBox1.SelectedIndex == 2) 
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "' <= iadetarihi", baglanti);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                
                // Kolon başlıklarını düzenle
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
        }
    }
}
