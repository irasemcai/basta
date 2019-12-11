using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    //[ServiceBehavior(ConcurrencyMode= ConcurrencyMode.Reentrant)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceBasta : IServiceBastaCodigo, IServiceLogin,  IServiceBastaSala
    {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);

        private IBastaSalaCallback bastaSalaCallback = null;

        private Dictionary<ClienteUsuario, int> NUEVOSUSUARIOS = new Dictionary<ClienteUsuario, int>();
        List<String> USUARIOSCONECTADOS = new List<string>();

        //prueba pra sala
        Dictionary<string, IBastaSalaCallback> JUGADORESSALA = new Dictionary<string, IBastaSalaCallback>();
        List<ClienteUsuario> LISTAUSUARIOSENLASALA = new List<ClienteUsuario>();

        public bool registrarUsuario(string Nombre, string Contrasena, string CorreoElectronico)
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
                    ClienteUsuario cliente = new ClienteUsuario();
                    cliente.nombre = Nombre;
                    NUEVOSUSUARIOS.Add(cliente, CodigoRegistro);

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

        public bool iniciarSesion(string Nombre, string Contrasena)
        {
            Usuario Usuario = new Usuario();
            bool ResultadoInicioSesion = Usuario.iniciarSesion(Nombre, Contrasena);
            if (ResultadoInicioSesion)
            {
                USUARIOSCONECTADOS.Add(Nombre);

                Console.WriteLine($"{Nombre} se ha conectado");

                return true;
            }
            else
            {
                return false;
            }
        }

        public ClienteUsuario verificarCodigoRegistro(int Codigo, ClienteUsuario cliente)
        {
            foreach (ClienteUsuario Usuario in NUEVOSUSUARIOS.Keys)
            {
                if (NUEVOSUSUARIOS[cliente].Equals(Codigo))
                {
                    USUARIOSCONECTADOS.Add(Usuario.nombre);
                    Console.WriteLine($"{Usuario} ha completado su registro e inició sesión");
                    return Usuario;
                }
            }
            return null;
        }

        public void crearSalaEspera(int id, int limiteParticipantes, string anfitrion)
        {
            throw new NotImplementedException();
        }

        public void unirseASala(ClienteUsuario cliente)
        {
            bastaSalaCallback = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();

            Console.WriteLine(":(");
            if (bastaSalaCallback != null)
            {
                Console.WriteLine(":((");
                if (JUGADORESSALA.ContainsKey(cliente.nombre))
                {
                    Console.WriteLine("usuario ya en lista");
                    return;
                }
                else
                {
                    JUGADORESSALA.Add(cliente.nombre, bastaSalaCallback);
                    LISTAUSUARIOSENLASALA.Add(cliente);
                    Console.WriteLine(":(((");
                    try
                    {
                        var jugadoresQueNoSonYo = JUGADORESSALA.Where(j => j.Key != cliente.nombre);
                        foreach (var jugador in jugadoresQueNoSonYo)
                        {
                            var callback = jugador.Value;
                            callback.ActualizarClientes(LISTAUSUARIOSENLASALA);
                        }
                        Console.WriteLine(":((((");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message}" + $"{e.InnerException}");
                    }

                }

            }
            Console.WriteLine(":D");
        }
    }
        
}

