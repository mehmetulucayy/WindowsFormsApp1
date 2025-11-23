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
    public partial class Sıralamafrm : Form
    {
        public Sıralamafrm()
        {
            InitializeComponent();
        }

        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        DataSet daset = new DataSet();

        private void Sıralamafrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from UYE order by okukitapsayisi desc", baglanti);
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
            
            baglanti.Close();
            
            // En çok ve en az okuyan üye bilgilerini göster
            if (daset.Tables["UYE"].Rows.Count > 0)
            {
                string enCokOkuyan = daset.Tables["UYE"].Rows[0]["adsoyad"].ToString();
                string enCokSayi = daset.Tables["UYE"].Rows[0]["okukitapsayisi"].ToString();
                label4.Text = enCokOkuyan + " (" + enCokSayi + " kitap)";
                
                if (dataGridView1.Rows.Count > 1)
                {
                    string enAzOkuyan = daset.Tables["UYE"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString();
                    string enAzSayi = daset.Tables["UYE"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();
                    label3.Text = enAzOkuyan + " (" + enAzSayi + " kitap)";
                }
            }
        }
    }
}
