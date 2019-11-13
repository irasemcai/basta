using System.ServiceModel;

namespace juegoBasta
{
    [ServiceContract]
    interface IServiceLogin
    {
        [OperationContract]
        bool InicioSesion(string nombre, string contrasena);

        [OperationContract]
        bool RegistrarUsuario(string name, string password, string email);

    }

    
}
