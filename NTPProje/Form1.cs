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
using NTPProje.Models;

namespace NTPProje
{
    public partial class Form1 : Form
    {
        ProjeSQLEntities db = new ProjeSQLEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           // SqlConnection command = new SqlConnection("Insert into KayitBilgileri (FirstName, LastName, MailAdress, Password) values ('"+textBox1.Text+ "', '"+textBox2.Text+ "', '"+textBox3.Text+ "', '"+textBox4.Text+"')");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "İsim")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;

            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "İsim";
                textBox1.ForeColor = Color.DimGray;

            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Soyisim")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Soyisim";
                textBox2.ForeColor = Color.DimGray;

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Mail Adresi")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Mail Adresi";
                textBox3.ForeColor = Color.DimGray;

            }
        }


        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Şifre")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';

            }
        }
        char? none = null;

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Şifre";
                textBox4.ForeColor = Color.DimGray;
                textBox4.PasswordChar = Convert.ToChar(none);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.ShowDialog();
        }
    }
}
