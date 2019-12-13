using System;
using System.Windows;
using System.ServiceModel;
using cliente.ventanasExcepcion;
using cliente.validacion;
using cliente.ServiceBasta;

namespace cliente
{
 
    public partial class InicioSesion : Window, ServiceBasta.IServiceLoginCallback
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
                InstanceContext instanceContext = new InstanceContext(this);          
                ServiceInicioSesion = new ServiceLoginClient(instanceContext);

                string NombreDeUsuario = textBoxNombreDeUsuario.Text;
                string Contrasena = textBoxContrasena.Password;

                ServiceInicioSesion.Open();
                bool ResultadoInicioSesion = ServiceInicioSesion.iniciarSesion(NombreDeUsuario, Contrasena);

                if (ResultadoInicioSesion == true)
                {
                    ClienteUsuario clienteUsuario = new ClienteUsuario();
                    clienteUsuario.nombre = NombreDeUsuario;

                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario(clienteUsuario);
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
            String Mensaje = "Verifica tu nombre o contraseña o puedes registrarte. ";
            MessageBoxButton Boton = MessageBoxButton.OK;
            MessageBox.Show(Mensaje, Titulo, Boton);
        }

        private void TextBoxNombreDeUsuario_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Validador Validacion = new Validador();
            bool resultadoValidacion = Validacion.validarLetrasYNumeros(e.Text);
            if (resultadoValidacion == false)
            {
                e.Handled = true;
            }   
        }

        private void TextBoxContrasena_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Validador Validacion = new Validador();
            bool resultadoValidacion = Validacion.validarLetrasYNumeros(e.Text);
            if (resultadoValidacion == false)
            {
                e.Handled = true;
            }
        }

        private void TextBoxNombreDeUsuario_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void TextBoxContrasena_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        public void enviarNotificacionANuevoUsuario(string notificacion)
        {
            throw new NotImplementedException();
        }

        public void enviarUsuarioRegistrado(ClienteUsuario clienteUsuario)
        {
            throw new NotImplementedException();
        }
    }
}

