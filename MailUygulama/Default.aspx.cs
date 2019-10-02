using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailUygulama
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailGonder();
        }

        public void MailGonder()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("nursahdagli8@gmail.com"); // epostanın kime gönderilecegi bilgisini tutar.
            msg.From = new System.Net.Mail.MailAddress(TextBox2.Text, "Mail Baslik", System.Text.Encoding.UTF8);  // epostanın kimden gönderilecegi bilgisini tutar.
            msg.Subject = TextBox3.Text; // epostanın konu bilgisini tutar.
            msg.Body = TextBox4.Text; //epostanın icerik bilgisini tutar.
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();// E-Posta'nin gönderilecegi SMTP sunucu ve gönderen kullanicinin bilgilerinin yazilip, MailMessage türünde olusturulan mailin gönderildigi siniftir.
            client.Credentials = new System.Net.NetworkCredential("nursahdagli8@gmail.com", "TsMnA5862+");// epostayı gönderen kullanıcının bilgileri
            client.Port = 587; //veya 25
            client.Host = "smtp.gmail.com"; //smtp sunucusunun isim bilgisini tutar
            client.EnableSsl = true; // sunucu ssl istiyorsa bunu true yapıcaz
            client.Send(msg);
            Label1.Text = "Mailiniz Başarı İle Gönderildi";
        }
    }
}