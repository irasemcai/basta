using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace juegoBasta
{
    [ServiceContract]
    interface IServiceBasta
    {
        [OperationContract]
        string PruebaConeccion(int valor);

        [OperationContract]
        void AgregarUsuario(string name, string password, string email);

    }
    /*
    interface IServiceBastaCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarUsuarioAgregado(bool resultado);
    }*/
}
