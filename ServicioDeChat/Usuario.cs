using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeChat
{
    public class Usuario
    {
        public int ID { get; set; }

        public string NombreUsuario { get; set; }

        public OperationContext operationContext { get; set; }
    }
}
