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
   // [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            ServiceBasta.ServiceLoginClient serviceInicioSesion = null;          
            try
            {
               // InstanceContext instanceContext = new InstanceContext(this);
                serviceInicioSesion = new ServiceBasta.ServiceLoginClient();

                string nombreDeUsuario = textBoxNombreDeUsuario.Text;
                string contrasena = textBoxContrasena.Text;
                bool resultadoInicioSesion;

                resultadoInicioSesion= serviceInicioSesion.InicioSesion(nombreDeUsuario, contrasena);

                if (resultadoInicioSesion == true)
                {
                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario();
                    cuentaDeUsuario.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no existe" + resultadoInicioSesion);
                }
                
            }
            catch (CommunicationException exception)         
            {
                serviceInicioSesion.Abort();
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor" + exception);
            }
            catch(TimeoutException exception)
            {
                serviceInicioSesion.Abort();
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor "+ exception);
            }
            finally
            {
                serviceInicioSesion.Close();
            }
            
        }

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaRegistro = new MainWindow();
            ventanaRegistro.Show();
            this.Close();
        }

      
    }
    }

