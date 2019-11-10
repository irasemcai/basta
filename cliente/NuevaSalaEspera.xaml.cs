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
using System.Threading;

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para NuevaSalaEspera.xaml
    /// </summary>
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class NuevaSalaEspera : Window, ServiceBasta.IServiceBastaSalaCallback
    {
        public NuevaSalaEspera()
        {
            InitializeComponent();
        }

        public void ImprimirUsuarioAgregadoSala(string nombreUsuario)
        {
            throw new NotImplementedException();
        }

        public void NotificarUsuarioEnSalaEspera(string nombreUsuario, bool resultado)
        {
           this.Dispatcher.BeginInvoke(new ThreadStart(() => textboxCajaParticipantes.Text = nombreUsuario.ToString()));
           String mensaje = "¡Bienvenido!";
            String titulo = "sala nueva"+ resultado;
            MessageBoxButton boton = MessageBoxButton.OK;
            MessageBox.Show(mensaje, titulo, boton);
        }

       

        private void ButtonAgregarSala_Click(object sender, RoutedEventArgs e)
        {           
            ServiceBasta.ServiceBastaSalaClient serviceBastaClient = null;
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                serviceBastaClient = new ServiceBasta.ServiceBastaSalaClient(instanceContext);

                string nombreSala = textboxNombreSala.Text;
                string limite = textboxNumParticipantes.Text;
                string nombreAnfitrion = textboxNombreUsuario.Text;
                int numParticipantes = int.Parse(limite);
               
                serviceBastaClient.CrearSalaEspera(nombreSala, numParticipantes, nombreAnfitrion);
            }
            catch (CommunicationException excepcion)
            {
                serviceBastaClient.Abort();
                MessageBox.Show("ocurrio  " + excepcion.Message);
            }
            catch(TimeoutException excepcion)
            {
                serviceBastaClient.Abort();
                MessageBox.Show("ocurrio  " + excepcion.Message);
            }
            finally
            {
                if (serviceBastaClient != null)
                {
                    if (serviceBastaClient.State == CommunicationState.Faulted)
                        //valor.Text = "aborto";
                        serviceBastaClient.Abort();
                }
                else
                {
                    serviceBastaClient.Close();
                }
            }
        }
    }
}
