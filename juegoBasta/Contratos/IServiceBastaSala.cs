using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    [ServiceContract(CallbackContract = typeof(IBastaSalaCallback), SessionMode = SessionMode.Required)]


  public  interface IServiceBastaSala
    {
        [OperationContract(IsOneWay = true)]
        void crearSalaEspera(ClienteUsuario cliente);

        [OperationContract(IsOneWay = true)]
        void unirseASala(ClienteUsuario cliente);

        [OperationContract]
        List<ClienteUsuario> mostrarClientesConectados();
    }

  public interface IBastaSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void ActualizarClientes(List<ClienteUsuario> clientes);
    }
}
