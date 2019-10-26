using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    class Usuario : ClaseAbstracta<user>
    {
        public override int AgregarEntidad (user entidad)
        {
            int resultado;
            entidades.users.Add(entidad);
            resultado = entidades.SaveChanges();
            return resultado;
        }
    }
}
