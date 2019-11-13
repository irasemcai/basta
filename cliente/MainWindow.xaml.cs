using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using System.Threading;
using Aspose.Cells.Drawing;


namespace cliente
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    [CallbackBehavior(UseSynchronizationContext = false)]

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceLoginClient serviceBasta = null;

            try
            {
                //InstanceContext context = new InstanceContext(this);
                serviceBasta = new ServiceBasta.ServiceLoginClient();

                string nombre = this.textBoxNombre.Text;
                string contrasena = this.textBoxContraseña.Text;
                string email = this.textBoxEmail.Text;

                bool resultadoRegistro= serviceBasta.RegistrarUsuario(nombre, contrasena, email);
                if (resultadoRegistro == true)
                {
                    CodigoRegistro ventanaCodigoRegistro = new CodigoRegistro();
                    ventanaCodigoRegistro.Show();
                    this.Close();
                    /*
               CuentaDeUsuario ventanaCuentaDeUsuario = new CuentaDeUsuario();
               ventanaCuentaDeUsuario.Show();*/
                }
                else
                {
                    NotificarUsuarioAgregado();
                }
            }
            catch (CommunicationException exception)
            {
                serviceBasta.Abort();
                String mensaje = "Error de conexión con el servidor: " + exception.Message;
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);
            }
            catch (TimeoutException exception)
            {
                serviceBasta.Abort();
                String mensaje = "Tiempo Excedido: "+ exception.Message;
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);
            }
            finally
            {
                if(serviceBasta != null)
                {
                    if(serviceBasta.State == CommunicationState.Faulted)                 
                    serviceBasta.Abort();
                }
                else
                {
                    serviceBasta.Close();
                }
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
            InicioSesion ventanaInicioSesion = new InicioSesion();
            ventanaInicioSesion.Show();
            this.Close();

        }

        public void NotificarUsuarioAgregado()
        {
            String mensaje = "Falló el registro, porfavor intenta más tarde";
            String titulo = "¡ups!";
            MessageBoxButton boton = MessageBoxButton.OK;
            MessageBox.Show(mensaje, titulo, boton);
        }
    }

    
    }

