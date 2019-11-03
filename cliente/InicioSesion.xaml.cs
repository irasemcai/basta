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
using System.Windows.Shapes;
using System.ServiceModel;

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            /*
            ServiceBasta.ServiceBastaClient serviceBastaClient = null;
            string nombreDeUsuario = textBoxNombreDeUsuario.Text;
            string contrasena = textBoxContrasena.Text;
            

            try
            {
                serviceBastaClient = new ServiceBasta.ServiceBastaClient();
               bool resultado = serviceBastaClient.IniciarSesion(nombreDeUsuario, contrasena);

                if (resultado)
                {
                    CuentaDeUsuario ventanaCuentaDeUsuario = new CuentaDeUsuario();
                    ventanaCuentaDeUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no válido o contraseña incorrecta");
                }

                
            }
            catch (CommunicationException exception)
            {
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor" + exception);
            }
            catch(TimeoutException exception)
            {
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor "+ exception);
            }
            */
        }

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaRegistro = new MainWindow();
            ventanaRegistro.Show();
            this.Close();
        }
    }
    }

