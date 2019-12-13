using juegoBasta.Domain;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace juegoBasta

{
    public partial class ServiceHost : IServiceLogin
    {
        Type providerService = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        private Dictionary<string, int> NUEVOSUSUARIOS = new Dictionary<string, int>();
        List<String> USUARIOSCONECTADOS = new List<string>();

        private ILoginCallback loginCallback = null;

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

       public void registrarUsuario(string Nombre, string Contrasena, string CorreoElectronico)
        {
            loginCallback = OperationContext.Current.GetCallbackChannel<ILoginCallback>();               

            if(loginCallback != null){
                MensajeCorreo MensajeCorreo = new MensajeCorreo();
                Random GeneradorRandom = new Random();
                int CodigoRegistro = GeneradorRandom.Next(100, 999);

                bool ResultadoEnvioCorreoVerificacion = MensajeCorreo.enviarCorreo(CorreoElectronico, CodigoRegistro);

                if (ResultadoEnvioCorreoVerificacion == true)
                {                   
                    user User = new user()
                    {
                        name = Nombre,
                        password = Contrasena,
                        email = CorreoElectronico
                    };

                    Usuario Usuario = new Usuario();
                    int ResultadoRegistro = Usuario.agregarEntidad(User);
                    if (ResultadoRegistro == 1)
                    {
                        Console.WriteLine($"{User.name} se ha registrado");
                        NUEVOSUSUARIOS.Add(User.name, CodigoRegistro);
                        ClienteUsuario clienteUsuario = new ClienteUsuario()
                        {
                            nombre = Nombre
                        };
                        loginCallback.enviarUsuarioRegistrado(clienteUsuario);
                        Console.WriteLine(" :(");
                    }
                    else
                    {
                        string notificacion = "El registro no pudo realizarse. Intenta más tarde";
                        loginCallback.enviarNotificacionANuevoUsuario(notificacion);
                    }
                }
                else
                {
                    string notificacion = "El correo no existe";
                    loginCallback.enviarNotificacionANuevoUsuario(notificacion);
                }
            }
            
        }

        public ClienteUsuario verificarCodigoRegistro(int Codigo, string cliente)
        {
            foreach (string Usuario in NUEVOSUSUARIOS.Keys)
            {
                if (NUEVOSUSUARIOS[cliente].Equals(Codigo))
                {
                    USUARIOSCONECTADOS.Add(cliente);
                    NUEVOSUSUARIOS.Remove(cliente);

                    Console.WriteLine($"{Usuario} ha completado su registro e inició sesión");
                    ClienteUsuario clienteUsuario = new ClienteUsuario()
                    {
                        nombre = cliente
                    };
                    return clienteUsuario;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}