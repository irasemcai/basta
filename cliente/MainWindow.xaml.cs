using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ServiceModel;
using cliente.ventanasExcepcion;
using cliente.validacion;
using cliente.ServiceBasta;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace cliente
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class MainWindow : Window, ServiceBasta.IServiceLoginCallback
    {

        public MainWindow()
        {
            InitializeComponent();
            List<string> idiomas = new List<string>();
            idiomas.Add("English");
            idiomas.Add("Español");
            comboBoxIdiomas.ItemsSource = idiomas;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceLoginClient ServiceLogin = null;
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                ServiceLogin = new ServiceBasta.ServiceLoginClient(instanceContext);

                string Nombre = this.textBoxNombre.Text;
                string Contrasena = this.textBoxContrasena.Password;
                string CorreoElectronico = this.textBoxEmail.Text;

                Validador Validador = new Validador();

                bool correoValido = Validador.ValidarCorreo(CorreoElectronico);
                if (correoValido == false)
                {
                    MessageBox.Show("correo no valido");

                }

                ServiceLogin.registrarUsuario(Nombre, Contrasena, CorreoElectronico);
            }
            catch (CommunicationException Exception)
            {
                ServiceLogin.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorComunicacion(Exception);
            }
            catch (TimeoutException Exception)
            {
                ServiceLogin.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorTiempo(Exception);
            }          
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }


        private void TextBoxContraseña_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InicioSesion VentanaInicioSesion = new InicioSesion();
            VentanaInicioSesion.Show();
            this.Close();
        }


        private void TextBoxNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Validador Validador = new Validador();
            bool entrada = Validador.validarLetrasYNumeros(e.Text);
            if (entrada == false)
            {
                e.Handled = true;
            }
        }

        private void PasswordBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void TextBoxContrasena_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Validador Validador = new Validador();
            bool entrada = Validador.validarLetrasYNumeros(e.Text);

            if (entrada == false)
            {
                e.Handled = true;
            }
        }

        public void enviarNotificacionANuevoUsuario(string notificacion)
        {
            String Titulo = "Registro Fallido";
            String Mensaje = " ";
            MessageBoxButton boton = MessageBoxButton.OK;
            
            this.Dispatcher.BeginInvoke(new ThreadStart(() => Mensaje = notificacion)
           );
            MessageBox.Show(Mensaje, Titulo, boton);

        }

        public void enviarUsuarioRegistrado(ClienteUsuario clienteUsuario)
        {
            this.Dispatcher.Invoke(() =>
            {
                CodigoRegistro ventanaCodigo = new CodigoRegistro(clienteUsuario);
                DesplegarVentana(ventanaCodigo);

            });
        }

        private void DesplegarVentana(Window ventana)
        {
            ventana.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string valor = comboBox.SelectedItem as string;

            if (valor.Equals( "Español"))
            {
                CambiarIdioma("idioma_es-MX.xaml");
            }
            if (valor.Equals("English"))
            {
                CambiarIdiomaIngles("idioma_en-US.xaml");
            }
            
        }

        private void CambiarIdiomaIngles(string nombreDiccionario)
        {
            var resources = new ResourceDictionary();
            resources.Source = new Uri("pack://application:,,,/Idiomas/" + nombreDiccionario);

            var currentResource = Application.Current.Resources.MergedDictionaries.FirstOrDefault(
                            resource => resource.Source.OriginalString.EndsWith("idioma_es-MX.xaml"));


            if (currentResource != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(currentResource);
            }
            Application.Current.Resources.MergedDictionaries.Add(resources);
        }

        private void CambiarIdioma(string nombreDiccionario)
        {
            var resources = new ResourceDictionary();
            resources.Source = new Uri("pack://application:,,,/Idiomas/"+nombreDiccionario);

            Application.Current.Resources.MergedDictionaries.Add(resources);
        }
    }    
}

