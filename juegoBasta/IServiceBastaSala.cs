using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    [ServiceContract(CallbackContract = typeof(IBastaSalaCallback))]
    interface IServiceBastaSala
    {
        [OperationContract(IsOneWay = true)]
        void crearSalaEspera(int id, int limiteParticipantes, string anfitrion);

        [OperationContract(IsOneWay = true)]
        void unirseASala(string nombreUsuario);

        [OperationContract]
        Usuario buscarUsuarioPorNombre(string nombre);


    }

    interface IBastaSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarUsuarioEnSalaEspera(SalaDeEspera salaDeEspera);

        [OperationContract(IsOneWay = true)]
        void ImprimirUsuarioAgregadoSala(string nombreUsuario);
    }
}
