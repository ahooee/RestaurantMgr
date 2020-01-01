using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace restaurantMgr_pnuProj
{
    class sendEmail
    {

        public void sendaemail() {

            try
            {

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("pnu@linuxian.ir");

                mailMessage.To.Add("ahooyee@gmail.com");


                mailMessage.Subject = "ddddddddddddddddddd";

                mailMessage.Body = "ddddd";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "mail.linuxian.ir";
                smtpClient.Port = 25;
                smtpClient.UseDefaultCredentials = false;

                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("pnu@linuxian.ir", "lin@@x206");
                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = false;
                
                smtpClient.Send(mailMessage);
                Console.WriteLine("Sent");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+"nashod ke beshe");
                
            }



        }








    }
}
