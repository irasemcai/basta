using juegoBasta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace juegoBasta
{
    [ServiceContract(CallbackContract = typeof(IBastaCallback))]
    interface IServiceBasta
    {
        [OperationContract (IsOneWay = true)]
        void PruebaConeccion(int valor);

        [OperationContract (IsOneWay =true)]
        void AgregarUsuario(string name, string password, string email);

        [OperationContract (IsOneWay =true)]
        void IniciarSesion(string nombre, string contrasena);

       
        /*
[OperationContract]
void UnirseASalaEspera(Usuario usuario);
*/
    }
    
    interface IBastaCallback
    {
        [OperationContract(IsOneWay = true)]
        void ContestarPrueba(int valor);

        [OperationContract(IsOneWay = true)]
        void NotificarUsuarioAgregado(int resultado, string resultadoCorreo);

        [OperationContract(IsOneWay = true)]
        void NotificarSesionIniciada(bool resultado);

    }

    
}
