using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using juegoBasta.Domain;

namespace juegoBasta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    //[ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Reentrant)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceBasta : IServiceBasta
    {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
       // IServiceBastaCallback serviceBastaCallback = null;

        public void AgregarUsuario (string name, string password, string email)
        {
            IBastaCallback bastaCallback = OperationContext.Current.GetCallbackChannel<IBastaCallback>();
            Usuario usuario = new Usuario();
            user user = new user();

            user.name = name;
            user.password = password;
            user.email = email;
            int resultado = usuario.AgregarEntidad(user);
            bastaCallback.NotificarUsuarioAgregado(resultado);
        }

        public bool IniciarSesion(string nombre, string contrasena)
        {
            Usuario usuario = new Usuario();
            bool resultado = usuario.IniciarSesion(nombre, contrasena);
            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PruebaConeccion(int valor)
        {
            // return "regresó valor " + valor + "en srvidor";
            IBastaCallback bastaCallback = OperationContext.Current.GetCallbackChannel<IBastaCallback>();
            int resultado = valor + 2;
            bastaCallback.ContestarPrueba(resultado);
        }


        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/
    }
    /*
    public static class WcfExtensions
    {
        public static void Using<T>(this T client, Action<T> work)
            where T : ICommunicationObject
        {
            try
            {
                work(client);
                client.Close();
            }
            catch (CommunicationException e)
            {
                client.Abort();
            }
            catch (TimeoutException e)
            {
                client.Abort();
            }
            catch (Exception e)
            {
                client.Abort();
                throw;
            }
        }
    }*/
}
