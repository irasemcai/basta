using System.ServiceModel;

namespace juegoBasta
{
   [ServiceContract]
    interface IServiceBastaCodigo
    {
        [OperationContract]
        bool VerificarCodigoRegistro(int codigo);

    }
    
    /*
    interface IBastaCallbackCodigo
    {
       
        [OperationContract(IsOneWay = true)]
        void NotificarUsuarioAgregado(int codigo);
        
        

        [OperationContract(IsOneWay = true)]
        void NotificarSesionIniciada(bool resultado);*/

    }

  
