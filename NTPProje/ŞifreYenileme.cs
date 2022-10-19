using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NTPProje.Models;

namespace NTPProje
{
    public partial class ŞifreYenileme : Form
    {
        ProjeSQLEntities db = new ProjeSQLEntities();

        public ŞifreYenileme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        MailGonderme mg = new MailGonderme();

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenilemeBildirim syb = new SifreYenilemeBildirim();
            syb.ShowDialog();
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
            if (textBox2.Text == "Mail Şifresi")
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
                textBox2.Text = "Mail Şifresi";
                textBox2.ForeColor = Color.DimGray;
                textBox2.PasswordChar = Convert.ToChar(none); 
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void ŞifreYenileme_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void ŞifreYenileme_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void ŞifreYenileme_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        
    }
}
