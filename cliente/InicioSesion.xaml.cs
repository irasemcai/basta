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
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class InicioSesion : Window, ServiceBasta.IServiceBastaCallback
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {          
            ServiceBasta.ServiceBastaClient serviceBastaClient = null;          
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                serviceBastaClient = new ServiceBasta.ServiceBastaClient(instanceContext);
                string nombreDeUsuario = textBoxNombreDeUsuario.Text;
                string contrasena = textBoxContrasena.Text;
                serviceBastaClient.IniciarSesion(nombreDeUsuario, contrasena);
                CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario();
                cuentaDeUsuario.Show();
                this.Close();
            }
            catch (CommunicationException exception)         
            {
                serviceBastaClient.Abort();
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor" + exception);
            }
            catch(TimeoutException exception)
            {
                serviceBastaClient.Abort();
                MessageBox.Show("Ha ocurrido un error de comunicacion con el servidor "+ exception);
            }
            finally
            {
                serviceBastaClient.Close();
            }
            
        }

        private void ButtonRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaRegistro = new MainWindow();
            ventanaRegistro.Show();
            this.Close();
        }

        public void ContestarPrueba(int valor)
        {
            throw new NotImplementedException();
        }

        public void NotificarSesionIniciada(bool resultado)
        {
            if (resultado==true)
            {               
               MessageBox.Show("Sesión Iniciada" + resultado);
               // AbrirVentanaUsuario();
                
            }
            else
            {
                MessageBox.Show("Usuario no existe" + resultado);
            }
        }

        public void AbrirVentanaUsuario()
        {
            
        }

        public void NotificarUsuarioAgregado(int resultado, string resultadoCorreo)
        {
            throw new NotImplementedException();
        }
    }
    }

