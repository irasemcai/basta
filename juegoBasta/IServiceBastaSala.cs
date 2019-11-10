using System.ServiceModel;

namespace juegoBasta
{
    [ServiceContract(CallbackContract = typeof(IBastaSalaCallback))]
    interface IServiceBastaSala
    {
        [OperationContract(IsOneWay = true)]
        void CrearSalaEspera(string nombre, int limiteParticipantes, string anfitrion);

        [OperationContract(IsOneWay = true)]
        void UnirseASala();

    }

    interface IBastaSalaCallback
    {
        [OperationContract(IsOneWay = true)]
        void NotificarUsuarioEnSalaEspera(string nombreUsuario, bool resultado);

        [OperationContract(IsOneWay = true)]
        void ImprimirUsuarioAgregadoSala(string nombreUsuario);
    }
}
