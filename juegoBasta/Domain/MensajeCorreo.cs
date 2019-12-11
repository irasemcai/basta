using System;
using System.Net.Mail;
using System.Net;

namespace juegoBasta.Domain
{
   public class MensajeCorreo
    {
       
        public bool enviarCorreo(string CorreoUsuario, int Codigo)
        {
            MailAddress CorreoJuegoBasta = new MailAddress("bastajuego@gmail.com");
            MailAddress CorreoDestino = new MailAddress(CorreoUsuario);
            

            MailMessage MensajeCorreo = new MailMessage();
            

            MensajeCorreo.From = CorreoJuegoBasta;
            MensajeCorreo.To.Add(CorreoDestino);
            MensajeCorreo.Subject = "Completa tu registro en BastaGame " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss ");
            MensajeCorreo.Body = "Tu código de registro es: "+ Codigo;
            MensajeCorreo.Priority = MailPriority.Normal;
            
            
            SmtpClient ProtocoloSMTP = new SmtpClient(); //clase protocolo para correo
            ProtocoloSMTP.Host = "smtp.gmail.com";
            ProtocoloSMTP.Port = 587;
            ProtocoloSMTP.Credentials = new NetworkCredential("bastajuego@gmail.com", "reginayelsa2019");
            ProtocoloSMTP.EnableSsl = true;
            

            try
            {
                ProtocoloSMTP.Send(MensajeCorreo);
                MensajeCorreo.Dispose();
                            
                return true;
            }catch (FormatException excepcion)
            {
               string Resultado = "error: formato de correo no válido " + excepcion.Message;
                return false;
            }
            
        }
    }
}
