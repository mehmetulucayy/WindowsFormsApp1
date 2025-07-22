﻿using System;
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
    public partial class Grafikfrm : Form
    {
        public Grafikfrm()
        {
            InitializeComponent();
        }
        private static readonly string connectionString = "Data Source=MEHMET\\SQLEXPRESS;Initial Catalog=KütüphaneOtomasyonuu;Integrated Security=True;";
        SqlConnection baglanti = new SqlConnection(connectionString);
        private void Grafikfrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut= new SqlCommand("select adsoyad,okukitapsayisi from UYE",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read()) 
            {
                chart1.Series["Okunan Kitap Sayisi"].Points.AddXY(read["adsoyad"].ToString(), read["okukitapsayisi"]);
            }
            baglanti.Close();
            chart1.Series["Okunan Kitap Sayisi"].Color = Color.Blue;
        }
    }
}
