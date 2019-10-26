using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using juegoBasta.Domain;

namespace BastaServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Reentrant)]
    public class ServiceBasta : IServiceBasta
    {
        IServiceBastaCallback serviceBastaCallback = null;

        public void AgregarUsuario (string name, string password, string email)
        {
            
            Usuario usuario = new Usuario();
            user user = new user();

            user.name = name;
            user.password = password;
            user.email = email;
            bool resultado = usuario.agregarEntidad(user);

            OperationContext.Current.GetCallbackChannel<IServiceBastaCallback>().NotificarUsuarioAgregado(resultado);
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
}
