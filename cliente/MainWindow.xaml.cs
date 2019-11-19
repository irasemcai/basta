using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.ServiceModel;
using System.Text.RegularExpressions;
using cliente.ventanasExcepcion;

namespace cliente
{
    [CallbackBehavior(UseSynchronizationContext = false)]

    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceLoginClient ServiceLogin = null;
            try
            {
                ServiceLogin = new ServiceBasta.ServiceLoginClient();
                string Nombre = this.textBoxNombre.Text;
                string Contrasena = this.textBoxContraseña.Text;
                string CorreoElectronico = this.textBoxEmail.Text;
                bool ResultadoRegistro= ServiceLogin.RegistrarUsuario(Nombre, Contrasena, CorreoElectronico); //probar que devuelva el nombre del usuario !null
                if (ResultadoRegistro == true)
                {
                    CodigoRegistro VentanaCodigoRegistro = new CodigoRegistro();
                    VentanaCodigoRegistro.Show();
                    this.Close();                   
                }
                else
                {
                    NotificarUsuarioNoAgregado();
                }
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
            finally
            {               
                    ServiceLogin.Close();              
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

        public void NotificarUsuarioNoAgregado()
        {
            String Titulo = "Registro Fallido";
            String Mensaje = "Lo sentimos, no te pudimos registrar. Corregiremos lo más pronto posible. Porfavor intenta más tarde";
            MessageBoxButton boton = MessageBoxButton.OK;
            MessageBox.Show(Mensaje, Titulo, boton);
        }

        private void TextBoxNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {          
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

    
    }

