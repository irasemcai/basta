using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioDeChat
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
   [ServiceContract(CallbackContract = typeof(IServiceChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        int Conectar(string Nombre);

        [OperationContract]
        void Desconectar(int Id);

        [OperationContract(IsOneWay = true)]
        void EnviarMensaje(string Mensaje, int Id);

    }

    public interface IServiceChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void RecibirMensaje(string Mensaje);            
    }

}
