using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
   public class MensajeCorreo
    {
       
        public bool EnviarCorreo(string correoDestinatario, int codigo)
        {
            MailAddress CorreoBasta = new MailAddress("bastajuego@gmail.com");
            MailAddress CorreoDestino = new MailAddress(correoDestinatario);
           

            MailMessage mailMessage = new MailMessage();
            

            mailMessage.From = CorreoBasta;
            mailMessage.To.Add(CorreoDestino);
            mailMessage.Subject = "Completa tu registro en BastaGame" + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss ");
            mailMessage.Body = "El código de registro es: "+ codigo;
            mailMessage.Priority = MailPriority.Normal;

            //clase protocolo para correo
            SmtpClient stmp = new SmtpClient();
            stmp.Host = "smtp.gmail.com";
            stmp.Port = 587;
            stmp.Credentials = new NetworkCredential("bastajuego@gmail.com", "reginayelsa2019");
            stmp.EnableSsl = true;
            

            try
            {
                stmp.Send(mailMessage);
                mailMessage.Dispose();
               
                
                return true;
            }catch (Exception excepcion)
            {
               string resultado = "error: " + excepcion.Message;
                return false;
            }
            
        }

        /**
         * 
        */

    }
}
