using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioDeChat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        List<Usuario> usuarios = new List<Usuario>();
        int SiguienteId = 1;

        public int Conectar(string Nombre)
        {

            Usuario usuario = new Usuario()
            {
                ID = SiguienteId,
                NombreUsuario = Nombre,
                operationContext = OperationContext.Current
            };
            SiguienteId++;

            EnviarMensaje(": " + usuario.NombreUsuario + " Se ha conectado!", 0);
            usuarios.Add(usuario);
            return usuario.ID;
        }

        public void Desconectar(int Id)
        {
            var user = usuarios.FirstOrDefault(i => i.ID == Id);
            if (user != null)
            {
                usuarios.Remove(user);
                EnviarMensaje(": " + user.NombreUsuario + " Se ha desconectado!", 0);
            }
        }

        public void EnviarMensaje(string Mensaje, int Id)
        {
            foreach (var item in usuarios)
            {
                string MensajeCompleto = DateTime.Now.ToShortTimeString();

                var user = usuarios.FirstOrDefault(i => i.ID == Id);
                if (user != null)
                {
                    MensajeCompleto += ": " + user.NombreUsuario + " ";
                }
                MensajeCompleto += Mensaje;
                item.operationContext.GetCallbackChannel<IServiceChatCallback>().RecibirMensaje(MensajeCompleto);
            }
        }
    }
}
