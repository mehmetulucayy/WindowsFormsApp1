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
    public partial class KullanıcıGrişifrm : Form
    {
        public KullanıcıGrişifrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkadı.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hatalı Giriş Denemesi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtkadı.Text=="Mehmet" && txtsifre.Text=="1234")
                {
                    Form1 anafrm = new Form1();
                    anafrm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");
                }



            }
        }

        private void KullanıcıGrişifrm_Load(object sender, EventArgs e)
        {

        }

        private void txtkadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(41, 128, 185); // Darker blue on hover
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(52, 152, 219); // Original blue
        }
    }
}
