using NTPProje.Models;
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

namespace NTPProje
{
    public partial class GirisEkrani : Form
    {
        ProjeSQLEntities db = new ProjeSQLEntities();

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mail Adresi")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Mail Adresi";
                textBox1.ForeColor = Color.DimGray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';  
            }
        }

        char? none = null;

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.DimGray;
                textBox2.PasswordChar = Convert.ToChar(none) ;
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void GirisEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void GirisEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void GirisEkrani_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayitBilgileri Durum = db.KayitBilgileri.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if (Durum != null)
            {
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
            else
            {
                GirisBasarisiz gb = new GirisBasarisiz();
                gb.ShowDialog();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ŞifreYenileme sy = new ŞifreYenileme();
            sy.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitEkrani fm = new KayitEkrani();
            fm.ShowDialog();
        }
    }
}
