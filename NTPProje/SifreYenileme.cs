using System;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NTPProje
{
    public partial class SifreYenileme : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-UKN5J7T;Initial Catalog=ProjeSQL;Integrated Security=True");

        public SifreYenileme()
        {
             InitializeComponent();
        }

        int kod;

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                kod = rnd.Next(1000, 9999);
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("projeicinmailadresi@gmail.com", "zcfddwozoukuycpr");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("projeicinmailadresi@gmail.com");
                mail.To.Add(txtMail.Text);
                mail.Subject = "Şifre Değiştirme Talebi";
                mail.IsBodyHtml = true;
                mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre değiştirme talebinde bulundunuz. Aktivasyon kodunuz: " + kod;

                sc.Send(mail);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                throw;
            }
            

        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            connect.Open();

            try
            {
                if (txtKod.Text == kod.ToString())
                {
                    SqlCommand cmd = new SqlCommand("update KayitBilgileri set Sifre = '" + txtSifre.Text + "' where MailAdresi '" + txtMail.Text , connect );
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            
        }

        //Süslemeler

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.Text == "Mail Adresi")
            {
                txtMail.Text = "";
                txtMail.ForeColor = Color.Black;

            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            if (txtMail.Text == "")
            {
                txtMail.Text = "Mail Adresi";
                txtMail.ForeColor = Color.DimGray;

            }
        }

        private void txtKod_Enter(object sender, EventArgs e)
        {
            if (txtKod.Text == "Aktivasyon Kodu")
            {
                txtKod.Text = "";
                txtKod.ForeColor = Color.Black;

            }
        }

        private void txtKod_Leave(object sender, EventArgs e)
        {
            if (txtKod.Text == "")
            {
                txtKod.Text = "Aktivasyon Kodu";
                txtKod.ForeColor = Color.DimGray;

            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.Black;

            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.DimGray;

            }
        }

        private void pictureGizle_Click(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            pictureGizle.Visible = false;
            pictureGoster.Visible = true;

        }

        char? none = null;

        private void pictureGoster_Click(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = Convert.ToChar(none);
            pictureGizle.Visible = true;
            pictureGoster.Visible = false;

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
