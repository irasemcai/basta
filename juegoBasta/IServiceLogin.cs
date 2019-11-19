using System.Collections.ObjectModel;
using System.ServiceModel;

namespace juegoBasta
{
    [ServiceContract]
    interface IServiceLogin
    {
        [OperationContract]
        bool iniciarSesion(string Nombre, string Contrasena);

        [OperationContract]
        bool registrarUsuario(string Nombre, string Contrasena, string CorreoElectronico);

        [OperationContract]
        ObservableCollection<string> obtenerUsuariosConectados();

    }

    
}
