using System;
using System.Windows;
using System.ServiceModel;
using cliente.ventanasExcepcion;

namespace cliente
{
 
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            ServiceBasta.ServiceLoginClient ServiceInicioSesion = null;          
            try
            {
               // InstanceContext instanceContext = new InstanceContext(this);
                ServiceInicioSesion = new ServiceBasta.ServiceLoginClient();
                string NombreDeUsuario = textBoxNombreDeUsuario.Text;
                string Contrasena = textBoxContrasena.Text;
                bool ResultadoInicioSesion = ServiceInicioSesion.InicioSesion(NombreDeUsuario, Contrasena);

                if (ResultadoInicioSesion == true)
                {
                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario();
                    cuentaDeUsuario.Show();
                    this.Close();
                }
                else
                {
                    NotificarUsuarioIncorrecto();
                }              
            }
            catch (CommunicationException Excepcion)         
            {
                ServiceInicioSesion.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorComunicacion(Excepcion);

            }
            catch(TimeoutException Excepcion)
            {
                ServiceInicioSesion.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorTiempo(Excepcion);
            }
            finally
            {
                ServiceInicioSesion.Close();
            }
            
        }

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaRegistro = new MainWindow();
            ventanaRegistro.Show();
            this.Close();
        }

        public void NotificarUsuarioIncorrecto()
        {
            String Titulo = "Usuario Incorrecto";
            String Mensaje = "El usuario es incorrecto. Verifica tu nombre o contraseña";
            MessageBoxButton Boton = MessageBoxButton.OK;
            MessageBox.Show(Mensaje, Titulo, Boton);
        }
    }
}

