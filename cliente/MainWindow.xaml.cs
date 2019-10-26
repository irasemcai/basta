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
   // [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class MainWindow : Window  //, ServiceBasta.IServiceBastaCallback
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*
        public void NotificarUsuarioAgregado(bool resultado)
        {
            String mensaje = " ";
            String titulo = "registro de usuario";
            MessageBoxButton boton = MessageBoxButton.OK;
            MessageBox.Show(mensaje, titulo, boton);
            this.Dispatcher.BeginInvoke(new ThreadStart(() => mensaje = resultado.ToString()));
        }
        */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceBastaClient serviceBasta = null;

            try
            {
                serviceBasta = new ServiceBasta.ServiceBastaClient();

                string nombre = this.textBoxNombre.Text;
                string contrasena = this.textBoxContraseña.Text;
                string email = this.textBoxEmail.Text;

                serviceBasta.AgregarUsuario(nombre, contrasena, email);
                String mensaje = "Registro exitoso";
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);

                //  serviceBasta.AgregarUsuario();
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
                    valor.Text = "aborto";
                    serviceBasta.Abort();
                }
                else
                {
                    serviceBasta.Close();
                }
            }

            /*using (ServiceBasta.ServiceBastaClient client = new ServiceBasta.ServiceBastaClient())
            {
                                String mensaje = "holo";
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);
                
            }  */
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (ServiceBasta.ServiceBastaClient client = new ServiceBasta.ServiceBastaClient())
            {
                
                valor.Text = client.PruebaConeccion(int.Parse(textBoxPrueba.Text));
            }
        }

        private void TextBoxPrueba_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxContraseña_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    
    }

