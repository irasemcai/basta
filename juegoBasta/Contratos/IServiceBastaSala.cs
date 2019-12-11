using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    [ServiceContract(CallbackContract = typeof(IBastaSalaCallback), SessionMode = SessionMode.Required)]


    interface IServiceBastaSala
    {
        [OperationContract(IsOneWay = true)]
        void crearSalaEspera(int id, int limiteParticipantes, string anfitrion);

        [OperationContract(IsOneWay = true)]
        void unirseASala(ClienteUsuario cliente);
    }

    interface IBastaSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void ActualizarClientes(List<ClienteUsuario> clientes);
    }
}
