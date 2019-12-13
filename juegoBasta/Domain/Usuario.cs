using System.Linq;
using System.Runtime.Serialization;

namespace juegoBasta.Domain
{
    public class Usuario : Entidad<user>
    {
        private user User;
        public Usuario()
        {
        }

        public Usuario(user user)
        {
            this.User = user;
        }

        public override int agregarEntidad(user Entidad)
        {

            int Resultado;
            Entidades.users.Add(Entidad);
            Resultado = Entidades.SaveChanges();
            return Resultado;
        }

        public bool iniciarSesion(string nombreUsuario, string contrasena)
        {
            bool Resultado = Entidades.users.Any(x => x.name == nombreUsuario && x.password == contrasena);
            if (Resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario obtenerUsuarioPorNombre(string Nombre)
        {
            bool Resultado = Entidades.users.Any(x => x.name == Nombre);
            if (Resultado)
            {
                user User = Entidades.users.Find(Nombre);
                Usuario Usuario = new Usuario(User);
                return Usuario;
            }
            else
            {
                return null;
            }

        }
    }

    [DataContract]
    public class ClienteUsuario
    {
        [DataMember]
        public string nombre { get; set; }
    }
}
