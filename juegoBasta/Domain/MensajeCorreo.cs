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
        public string EnviarCorreo(string correoDestinatario)
        {
            MailAddress CorreoBasta = new MailAddress("bastajuego@gmail.com");
            MailAddress CorreoDestino = new MailAddress(correoDestinatario);


            MailMessage mailMessage = new MailMessage();
            mailMessage.From = CorreoBasta;
            mailMessage.To.Add(CorreoDestino);
            mailMessage.Subject = "Prueba de Correo " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss ");
            mailMessage.Body = "esta es una prueba ";
            mailMessage.Priority = MailPriority.Normal;

            //clase protocolo para correo
            SmtpClient stmp = new SmtpClient();
            stmp.Host = "smtp.gmail.com";
            stmp.Port = 587;
            stmp.Credentials = new NetworkCredential("bastajuego@gmail.com", "reginayelsa2019");
            stmp.EnableSsl = true;
            string resultado = null;

            try
            {
                stmp.Send(mailMessage);
                mailMessage.Dispose();
                resultado = "correo enviado correcto ";
                return resultado;
            }catch (Exception excepcion)
            {
                resultado = "error: " + excepcion.Message;
                return resultado;
            }
            
        }

        /**
         * 
        */

    }
}
