using System;
using System.ServiceModel;

namespace juegoBasta
{
    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "juegoBasta.ContractType".
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public partial class ServiceHost
    {
        /**
         * pruebas
         */
        private Func<ILoginCallback> callbackLoginChannel;

        /*
         * pruebas
         */
        public ServiceHost(Func<ILoginCallback> loginCallback)
        {
            this.callbackLoginChannel = loginCallback ?? throw new ArgumentNullException("callback Creator");
        }

        public ServiceHost()
        {
        }
    }
}

