using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    //[ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Reentrant)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single, InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceBasta : IServiceBastaCodigo, IServiceLogin , IServiceBastaSala
    {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

        private Dictionary<string, int> NUEVOSUSUARIOS = new Dictionary<string, int>();
        ObservableCollection<String> USUARIOSCONECTADOS = new ObservableCollection<string>();
        


        public bool registrarUsuario (string Nombre, string Contrasena, string CorreoElectronico)
        {
           
            Usuario Usuario = new Usuario();
            user User = new user();
            MensajeCorreo MensajeCorreo = new MensajeCorreo();
            Random GeneradorRandom = new Random();

            int CodigoRegistro = GeneradorRandom.Next(100, 999);

            User.name = Nombre;
            User.password = Contrasena;
            User.email = CorreoElectronico;
            int ResultadoRegistro = Usuario.agregarEntidad(User);

            if (ResultadoRegistro == 1)
            {
                bool ResultadoEnvioCorreoVerificacion = MensajeCorreo.enviarCorreo(CorreoElectronico, CodigoRegistro);
                if (ResultadoEnvioCorreoVerificacion == true)
                {
                    NUEVOSUSUARIOS.Add(Nombre, CodigoRegistro);

                }
                Console.WriteLine($"{CorreoElectronico} se ha registrado. Resultado registro: {ResultadoRegistro} ,Resultado correo:  {ResultadoEnvioCorreoVerificacion}");
                return true;
            }
            else
            {
                Console.WriteLine($"{CorreoElectronico} se ha intentó registrarse. Resultado registro: {ResultadoRegistro}");
                return false;
            }          
        }


        public Usuario buscarUsuarioPorNombre(string Nombre)
        {
            
            Usuario Usuario = new Usuario();
            Usuario User;
            User = Usuario.obtenerUsuarioPorNombre(Nombre);
           
            return User;
        }

        public void crearSalaEspera(int id, int limiteParticipantes, string anfitrion)
        {
            
            IBastaSalaCallback bastaSalaCallbabk = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();
            //SalaDeEspera salaDeEspera = new SalaDeEspera(nombre, limiteParticipantes, anfitrion);
            // bool resultado= salaDeEspera.agregarUsuarioASala(anfitrion);
            Usuario usuarioAnfitrion;
            usuarioAnfitrion = buscarUsuarioPorNombre(anfitrion);
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


        public bool iniciarSesion(string Nombre, string Contrasena)
        {
            Usuario Usuario = new Usuario();
            bool ResultadoInicioSesion = Usuario.iniciarSesion(Nombre, Contrasena);
            if (ResultadoInicioSesion)
            {
                Console.WriteLine($"{Nombre} se ha conectado");
                USUARIOSCONECTADOS.Add(Nombre);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void unirseASala(string nombreUsuario)
        {
            Dictionary<IBastaSalaCallback, string> usuarios = new Dictionary<IBastaSalaCallback, string>();
            var conexion = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();
          //  SalaDeEspera salaDeEspera = new SalaDeEspera();
           // bool resultado = salaDeEspera.agregarUsuarioASala(nombreUsuario);
            usuarios[conexion] = nombreUsuario;

            Console.WriteLine($"{nombreUsuario} se ha unido a sala");

           // conexion.NotificarUsuarioEnSalaEspera(nombreUsuario, resultado);
        }

        public bool verificarCodigoRegistro(int Codigo)
        {           
            foreach (string Usuario in NUEVOSUSUARIOS.Keys)
                {
                    if (NUEVOSUSUARIOS[Usuario].Equals(Codigo))
                    {
                        USUARIOSCONECTADOS.Add(Usuario);
                    Console.WriteLine($"{Usuario} ha completado su registro e inició sesión");
                        return true;
                    }
                }
                return false;
            }

        public ObservableCollection<string> obtenerUsuariosConectados()
        {
            Console.WriteLine($"{USUARIOSCONECTADOS} now");
            return USUARIOSCONECTADOS;
        }
    }
}    