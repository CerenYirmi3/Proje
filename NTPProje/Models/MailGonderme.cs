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

        public void Microsoft(string AliciMail)
        {
            KayitBilgileri bilgiler = db.KayitBilgileri.FirstOrDefault(x => x.MailAdress == AliciMail);
           /* Random rnd = new Random();
            bilgiler.Password = rnd.Next(1000, 10000).ToString();
            db.SaveChanges();*/
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential("projeicinmailadresi@gmail.com", "zcfddwozoukuycpr");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("projeicinmailadresi@gmail.com" );
            mail.To.Add(AliciMail);
            mail.Subject = "Şifre Değiştirme Talebi";
            mail.IsBodyHtml = true;
            mail.Body = $@"{DateTime.Now.ToString()} Tarihinde şifre değiştirme talebinde bulundunuz. Güncel Şifreniz : {bilgiler.Password}";
            sc.Send(mail);
        }

    }
}
