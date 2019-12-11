using juegoBasta.Domain;
using System.ServiceModel;

namespace juegoBasta
{
   [ServiceContract]
    interface IServiceBastaCodigo
    {
      
        [OperationContract]
        ClienteUsuario verificarCodigoRegistro(int Codigo, ClienteUsuario cliente);

    }
 }

  
