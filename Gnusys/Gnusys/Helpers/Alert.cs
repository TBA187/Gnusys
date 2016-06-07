using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Gnusys.Helpers
{
    public static class Alert
    {

        public static void SendAlert(int average, double delta, int reading)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("systemeksamensprojekt@gmail.com");
                mail.To.Add("klinikereksamensprojekt@gmail.com");
                mail.Subject = "Ureglmæssig måling";
                mail.Body = "En Patient har målt en stor ændring i iltmæætningen. \n Gemmemsnit fra de sidste 20 målinger: " + average + "\n Måling: " + reading + "\n Det er en ændring på " + delta + " procent.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("systemeksamensprojekt@gmail.com", "Gnusys1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                string s = e.ToString();
            }
        }
    }
}