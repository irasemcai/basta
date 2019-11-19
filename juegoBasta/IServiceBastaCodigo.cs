using System.ServiceModel;

namespace juegoBasta
{
   [ServiceContract]
    interface IServiceBastaCodigo
    {
        [OperationContract]
        bool verificarCodigoRegistro(int Codigo);

    }
 }

  
