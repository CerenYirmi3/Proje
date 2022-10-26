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
    public partial class KayitEkrani : Form
    {
        ProjeSQLEntities db = new ProjeSQLEntities();

        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string constring = "Data Source=DESKTOP-UKN5J7T;Initial Catalog=ProjeSQL;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                if (textBox1.Text == "İsim" || textBox2.Text == "Soyisim" || textBox3.Text == "Telefon Numarası" || textBox4.Text == "Mail Adresi" || textBox5.Text == "Şifre" )
                {
                    KayitBos kb = new KayitBos();
                    kb.ShowDialog();
                }
                else
                {
                    string kayit = "insert into KayitBİlgileri (FirstName,LastName,PhoneNumber,MailAdress,Password) values(@ad,@soyad,@tel,@mail,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit,connect);
                      komut.Parameters.AddWithValue("@ad", textBox1.Text);
                      komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                      komut.Parameters.AddWithValue("@tel", textBox3.Text);
                      komut.Parameters.AddWithValue("@mail", textBox4.Text);
                      komut.Parameters.AddWithValue("@sifre", textBox5.Text);
                      komut.ExecuteNonQuery();
                      connect.Close();

                      KayitBasarili kb = new KayitBasarili();
                      kb.ShowDialog();
                }
                

            }
            catch (Exception hata)
            {
                MessageBox.Show("Kayıt Esnasında Hata Meydana Geldi!" + hata.Message);
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GirisEkrani ge = new GirisEkrani();
            ge.ShowDialog();
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {

        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void KayitEkrani_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void KayitEkrani_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void KayitEkrani_MouseMove(object sender, MouseEventArgs e)
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
            if (textBox3.Text == "Telefon Numarası")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;

            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Telefon Numarası";
                textBox3.ForeColor = Color.DimGray;

            }
        }


        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Mail Adresi")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;

            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Mail Adresi";
                textBox4.ForeColor = Color.DimGray;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        char? none = null;

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Şifre")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                textBox5.PasswordChar = '*';

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Şifre";
                textBox5.ForeColor = Color.DimGray;
                textBox5.PasswordChar = Convert.ToChar(none);

            }
        }
    }
}
