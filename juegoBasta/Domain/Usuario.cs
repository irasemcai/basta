using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juegoBasta.Domain
{
    public class Usuario : ClaseAbstracta<user>
    {
        private user user;
        

        public Usuario()
        {
        }

        public Usuario(user user)
        {
            this.user = user;
        }

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

        public Usuario ObtenerUsuarioPorNombre(string nombre)
        {
            bool resultado = entidades.users.Any(x => x.name == nombre);
            if (resultado)
            {
              user user= entidades.users.Find(nombre);
                Usuario usuario = new Usuario(user);
                return usuario;
            }
            else
            {
                return null;
            }
           
        }
    }
}
