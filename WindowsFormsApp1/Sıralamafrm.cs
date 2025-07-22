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
            baglanti.Close();
            label4.Text = "";
            label3.Text = "";
            label4.Text = daset.Tables["UYE"].Rows[0]["adsoyad"].ToString()+"=";
            label4.Text += daset.Tables["UYE"].Rows[0]["okukitapsayisi"].ToString();
            label3.Text = daset.Tables["UYE"].Rows[dataGridView1.Rows.Count-2]["adsoyad"].ToString()+"=";
            label3.Text += daset.Tables["UYE"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();
        }
    }
}
