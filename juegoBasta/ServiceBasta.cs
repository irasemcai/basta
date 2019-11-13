using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using juegoBasta.Domain;

namespace juegoBasta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    //[ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Reentrant)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceBasta : IServiceBastaCodigo, IServiceLogin , IServiceBastaSala
    {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        public Dictionary<string, int> nuevosUsuarios = new Dictionary<string, int>();


        public bool RegistrarUsuario (string name, string password, string email)
        {
           // IBastaCallback bastaCallback = OperationContext.Current.GetCallbackChannel<IBastaCallback>();
            Usuario usuario = new Usuario();
            user user = new user();
            MensajeCorreo mensajeCorreo = new MensajeCorreo();
            Random random = new Random();
            int codigoRegistro = random.Next(100, 999);

            user.name = name;
            user.password = password;
            user.email = email;
            int resultadoRegistro = usuario.AgregarEntidad(user);
            if (resultadoRegistro == 1)
            {
                bool resultadoCorreo = mensajeCorreo.EnviarCorreo(email, codigoRegistro);
                if (resultadoCorreo==true)
                {
                    nuevosUsuarios.Add(name, codigoRegistro);
                    
                }

                Console.WriteLine($"{email} se ha registrado. Resultado registro: {resultadoRegistro} ,Resultado correo:  {resultadoCorreo}");
                return true;
            }
            else
            {
                Console.WriteLine($"{email} se ha intentó registrarse. Resultado registro: {resultadoRegistro}");
                return false;
            } 
            //bastaCallback.NotificarUsuarioAgregado(resultadoRegistro, resultadoCorreo);
        }


        public Usuario BuscarUsuarioPorNombre(string nombre)
        {
            
            Usuario usuario = new Usuario();
            Usuario user;
            user = usuario.ObtenerUsuarioPorNombre(nombre);
           
            return user;
        }

        public void CrearSalaEspera(int id, int limiteParticipantes, string anfitrion)
        {
            
            IBastaSalaCallback bastaSalaCallbabk = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();
            //SalaDeEspera salaDeEspera = new SalaDeEspera(nombre, limiteParticipantes, anfitrion);
            // bool resultado= salaDeEspera.agregarUsuarioASala(anfitrion);
            Usuario usuarioAnfitrion;
            usuarioAnfitrion = BuscarUsuarioPorNombre(anfitrion);
            ControladorSala controladorSala = new ControladorSala();
            SalaDeEspera salaDeEspera= controladorSala.CrearSalaDeEspera(id, limiteParticipantes, usuarioAnfitrion);
            if(salaDeEspera!= null){
                Console.WriteLine($"{anfitrion} ha creado Sala: {salaDeEspera.ToString()} ");
                
            }
            else
            {
                Console.WriteLine($"{anfitrion} ha INTENTADO crear una Sala: null {salaDeEspera.ToString()} ");
             
            }
           
                bastaSalaCallbabk.NotificarUsuarioEnSalaEspera(salaDeEspera);
        }


        public bool InicioSesion(string nombre, string contrasena)
        {
            Usuario usuario = new Usuario();
            bool resultado = usuario.IniciarSesion(nombre, contrasena);
            if (resultado)
            {
                Console.WriteLine($"{nombre} se ha conectado");
                return true;
            }
            else
            {
                return false;
            }
        }


        public void UnirseASala(string nombreUsuario)
        {
            Dictionary<IBastaSalaCallback, string> usuarios = new Dictionary<IBastaSalaCallback, string>();
            var conexion = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();
          //  SalaDeEspera salaDeEspera = new SalaDeEspera();
           // bool resultado = salaDeEspera.agregarUsuarioASala(nombreUsuario);
            usuarios[conexion] = nombreUsuario;

            Console.WriteLine($"{nombreUsuario} se ha unido a sala");

           // conexion.NotificarUsuarioEnSalaEspera(nombreUsuario, resultado);
        }

        public bool VerificarCodigoRegistro(int codigo)
        {
           
            foreach (string usuario in nuevosUsuarios.Keys)
                {
                    if (nuevosUsuarios[usuario].Equals(codigo))
                    {
                        return true;
                    }
                }
                return true;
            }
           
        }
    }

        /*
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }*/


