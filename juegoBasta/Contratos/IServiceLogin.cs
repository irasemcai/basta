using juegoBasta.Domain;
using System.ServiceModel;

namespace juegoBasta
{
   

    [ServiceContract(CallbackContract = typeof(ILoginCallback), SessionMode = SessionMode.Required)]
   public interface IServiceLogin
    {
        [OperationContract(IsOneWay = true)]
        void registrarUsuario(string Nombre, string Contrasena, string CorreoElectronico);
        
        [OperationContract]
        bool iniciarSesion(string Nombre, string Contrasena);

        [OperationContract]
        ClienteUsuario verificarCodigoRegistro(int Codigo, string cliente);

    }

   public interface ILoginCallback
    {
        [OperationContract(IsOneWay = true)]
        void enviarNotificacionANuevoUsuario(string notificacion);

        [OperationContract(IsOneWay = true)]
        void enviarUsuarioRegistrado(ClienteUsuario clienteUsuario);
    }

    
}
