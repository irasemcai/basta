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

        public bool IniciarSesion(string nombreUsuario, string contrasena)
        {
            bool resultado = entidades.users.Any(x => x.name == nombreUsuario && x.password == contrasena);
            if (resultado)
            {

                return resultado;
            }
            else
            {
                return false;
            }
        }
    }
}
