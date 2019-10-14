using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    class Usuario : ClaseAbstracta<user>
    {
        public override bool agregarEntidad (user entidad)
        {
            bool resultado = true; ;
            entidades.users.Add(entidad);
            entidades.SaveChanges();
            return resultado;
        }
    }
}
