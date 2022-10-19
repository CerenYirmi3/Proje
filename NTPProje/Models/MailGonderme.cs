using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NTPProje.Models;
using System.Windows.Forms;

namespace NTPProje.Models
{
    public class MailGonderme
    {
        ProjeSQLEntities db = new ProjeSQLEntities();

        public void Microsoft(string GondericiMail, string GondericiPass, string AliciMail)
        {
            KayitBigileri bilgiler = db.KayitBigileri.FirstOrDefault(x => x.MailAdress == GondericiMail);
            Random rnd = new Random();
            bilgiler.Password = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(GondericiMail, GondericiPass);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(GondericiMail, "Şifre Yenileme maili" );
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Değiştirme Talebi";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre değiştirme talebinde bulundunuz. Yeni şifreniz{bilgiler.Password}";
            //sc.Timeout = 60;
            sc.Send(mail);
        }

        internal void Microsoft(TextBox textBox2, string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }
    }
}
