using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms.Suite;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;


namespace NTPProje
{
    public partial class GirisEkrani : Form
    {
        //SqlConnection connect =   new SqlConnection("Data Source={SQL Server}; Server= CEREN-AYDIN; Database=ProjeSQL; Uid=ceren; Pwd = 459437;");
         
        public GirisEkrani()
        {
            InitializeComponent();
        }

        IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "br2oq4Y87T57UFS8SXogQ9ionSBg9HB49Vj8u1sm",
            BasePath = "https://dijitalmenager-default-rtdb.firebaseio.com",
        };

        IFirebaseClient client;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }



        private void btnGiris_Click(object sender, EventArgs e)
        {
            //connect.Open();
            //SqlCommand com = new SqlCommand("Select * from KayitBilgileri", connect);
            //SqlDataReader read = com.ExecuteReader();

            //try
            //{
            //    if (txtMailGiris.Text == read["MailAdresi"] && txtSifreGiris.Text == read["Sifre"])
            //    {
            //        AnaEkran an = new AnaEkran();
            //        an.ShowDialog();
            //        this.Close();
            //    }
            //}
            //catch (Exception hata)
            //{
            //    MessageBox.Show("Giriş Esnasında Hata Meydana Geldi!" + hata.Message);

            //}

            AnaEkran an = new AnaEkran();
            an.ShowDialog();
            this.Close();

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {


            //try
            //{
            //    if (connect.State == ConnectionState.Closed)
            //    {
            //        connect.Open();
            //    }

            //    if (txtIsimKayit.Text == "İsim" || txtSoyisimKayit.Text == "Soyisim" || txtTelKayit.Text == "Telefon Numarası(5**********)" || txtMailKayit.Text == "Mail Adresi" || txtSifreKayit.Text == "Şifre" || txtTcNoKayit.Text == "Tc Kimlik Numarası")
            //    {
            //        KayitBos kb = new KayitBos();
            //        kb.ShowDialog();
            //    }
            //    else //if(txtTcNoKayit.Text == read["CalisanTcKimlikNum"] )
            //    {
            //        string kayit = "insert into KayitBİlgileri (Isim,Soyisim,TelefonNum,MailAdresi,Sifre,TcKimlikNum) values (@ad,@soyad,@tel,@mail,@sifre,@tc)";
            //        SqlCommand komut = new SqlCommand(kayit, connect);
            //        komut.Parameters.AddWithValue("@ad", txtIsimKayit.Text);
            //        komut.Parameters.AddWithValue("@soyad", txtSoyisimKayit.Text);
            //        komut.Parameters.AddWithValue("@tel", txtTelKayit.Text);
            //        komut.Parameters.AddWithValue("@mail", txtMailKayit.Text);
            //        komut.Parameters.AddWithValue("@sifre", txtSifreKayit.Text);
            //        komut.Parameters.AddWithValue("@tc", txtTcNoKayit.Text);
            //        komut.ExecuteNonQuery();
            //        connect.Close();

            //        AnaEkran an = new AnaEkran();
            //        an.ShowDialog();
            //        this.Close();
            //    }


            //}
            //catch (Exception hata)
            //{
            //    MessageBox.Show("Kayıt Esnasında Hata Meydana Geldi!" + hata.Message);
            //}

        }

        private void linkSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreYenileme sy = new SifreYenileme();
            sy.ShowDialog();
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Burdan sonrası süslemeler

        private void txtMailGiris_Enter(object sender, EventArgs e)
        {
            if (txtMailGiris.Text == "Mail Adresi")
            {
                txtMailGiris.Text = "";
                txtMailGiris.ForeColor = Color.Black;

            }
        }

        private void txtMailGiris_Leave(object sender, EventArgs e)
        {
            if (txtMailGiris.Text == "")
            {
                txtMailGiris.Text = "Mail Adresi";
                txtMailGiris.ForeColor = Color.DimGray;

            }
        }

        private void txtSifreGiris_Enter(object sender, EventArgs e)
        {
            if (txtSifreGiris.Text == "Şifre")
            {
                txtSifreGiris.Text = "";
                txtSifreGiris.ForeColor = Color.Black;
            }
        }

        private void txtSifreGiris_Leave(object sender, EventArgs e)
        {
            if (txtSifreGiris.Text == "")
            {
                txtSifreGiris.Text = "Şifre";
                txtSifreGiris.ForeColor = Color.DimGray;
            }
        }

        private void txtIsimKayit_Enter(object sender, EventArgs e)
        {
            if (txtIsimKayit.Text == "İsim")
            {
                txtIsimKayit.Text = "";
                txtIsimKayit.ForeColor = Color.Black;
            }
        }

        private void txtIsimKayit_Leave(object sender, EventArgs e)
        {
            if (txtIsimKayit.Text == "")
            {
                txtIsimKayit.Text = "İsim";
                txtIsimKayit.ForeColor = Color.DimGray;

            }
        }

        private void txtSoyisimKayit_Enter(object sender, EventArgs e)
        {
            if (txtSoyisimKayit.Text == "Soyisim")
            {
                txtSoyisimKayit.Text = "";
                txtSoyisimKayit.ForeColor = Color.Black;

            }
        }

        private void txtSoyisimKayit_Leave(object sender, EventArgs e)
        {
            if (txtSoyisimKayit.Text == "")
            {
                txtSoyisimKayit.Text = "Soyisim";
                txtSoyisimKayit.ForeColor = Color.DimGray;

            }
        }

        private void txtTcNoKayit_Enter(object sender, EventArgs e)
        {
            if (txtTcNoKayit.Text == "TC Kimlik Numarası")
            {
                txtTcNoKayit.Text = "";
                txtTcNoKayit.ForeColor = Color.Black;

            }
        }

        private void txtTcNoKayit_Leave(object sender, EventArgs e)
        {
            if (txtTcNoKayit.Text == "")
            {
                txtTcNoKayit.Text = "TC Kimlik Numarası";
                txtTcNoKayit.ForeColor = Color.DimGray;

            }
        }

        private void txtMailKayit_Enter(object sender, EventArgs e)
        {
            if (txtMailKayit.Text == "Mail Adresi")
            {
                txtMailKayit.Text = "";
                txtMailKayit.ForeColor = Color.Black;

            }
        }

        private void txtMailKayit_Leave(object sender, EventArgs e)
        {
            if (txtMailKayit.Text == "")
            {
                txtMailKayit.Text = "Mail Adresi";
                txtMailKayit.ForeColor = Color.DimGray;

            }
        }

        private void txtSifreKayit_Enter(object sender, EventArgs e)
        {
            if (txtSifreKayit.Text == "Şifre")
            {
                txtSifreKayit.Text = "";
                txtSifreKayit.ForeColor = Color.Black;
            }
        }

        private void txtSifreKayit_Leave(object sender, EventArgs e)
        {
            if (txtSifreKayit.Text == "")
            {
                txtSifreKayit.Text = "Şifre";
                txtSifreKayit.ForeColor = Color.DimGray;
            }
        }

        private void txtTelKayit_Enter(object sender, EventArgs e)
        {
            if (txtTelKayit.Text == "Telefon Numarası (5*********)")
            {
                txtTelKayit.Text = "";
                txtTelKayit.ForeColor = Color.Black;
            }
        }

        private void txtTelKayit_Leave(object sender, EventArgs e)
        {
            if (txtTelKayit.Text == "")
            {
                txtTelKayit.Text = "Telefon Numarası (5*********)";
                txtTelKayit.ForeColor = Color.DimGray;
            }
        }

        char? none = null;

        private void imgSifreGizleGiris_Click(object sender, EventArgs e)
        {
            txtSifreGiris.PasswordChar = '*';
            imgSifreGizleGiris.Visible = false;
            imgSifreGosterGiris.Visible = true;
        }

        private void imgSifreGosterGiris_Click(object sender, EventArgs e)
        {
            txtSifreGiris.PasswordChar = Convert.ToChar(none);
            imgSifreGizleGiris.Visible = true;
            imgSifreGosterGiris.Visible = false;
        }

        private void imgSifreGizleKayit_Click(object sender, EventArgs e)
        {
            txtSifreKayit.PasswordChar = '*';
            imgSifreGizleKayit.Visible = false;
            imgSifreGosterKayit.Visible = true;
        }

        private void imgSifreGosterKayit_Click(object sender, EventArgs e)
        {
            txtSifreKayit.PasswordChar = Convert.ToChar(none);
            imgSifreGizleKayit.Visible = true;
            imgSifreGosterKayit.Visible = false;
        }

        //Pencerenin hareket ettirilebilmesi için

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

        
    }
}
