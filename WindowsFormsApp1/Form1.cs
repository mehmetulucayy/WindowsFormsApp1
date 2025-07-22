using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            
            
            UyeEklefrm uyeekle=new UyeEklefrm();
            uyeekle.ShowDialog();
            
        }

        private void btnÜyeListe_Click(object sender, EventArgs e)
        {
            UyeListelefrm uyeListele=new UyeListelefrm();
            uyeListele.ShowDialog();    
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapekle=new KitapEklefrm();
            kitapekle.ShowDialog();
        }

        private void btnKitapLisete_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitaplisetele=new KitapListelefrm();
            kitaplisetele.ShowDialog(); 
        }

        private void btnEmanetKitap_Click(object sender, EventArgs e)
        {
            EmanetKitapVerfrm emanetKitapVer=new EmanetKitapVerfrm();
            emanetKitapVer.ShowDialog();
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListelefrm listele =new EmanetKitapListelefrm(); 
            listele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİadefrm iadee=new EmanetKitapİadefrm();
            iadee.ShowDialog();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            Sıralamafrm sırala=new Sıralamafrm();
            sırala.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikfrm grafikfrm=new Grafikfrm();    
            grafikfrm.ShowDialog();
        }
    }
}
