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
using cliente.ServiceBasta;


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

        public void NotificarUsuarioEnSalaEspera(SalaDeEspera salaDeEspera)
        {
            //Object[] jugadores = salaDeEspera.JugadoresEnEspera;
            if(salaDeEspera != null)
            {
                foreach (Usuario u in salaDeEspera.JugadoresEnEspera)
                {

                    this.Dispatcher.BeginInvoke(new ThreadStart(() => textboxCajaParticipantes.Text = u.ToString()));
                }

                String mensaje = "¡Bienvenido! Esta es una sala que has creado";
                String titulo = "sala nueva";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);

            }
            else
            {
                String mensaje = "hubo algun error";
                String titulo = "sala nueva";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);
            }
            

        }

        private void ButtonAgregarSala_Click(object sender, RoutedEventArgs e)
        {           
            ServiceBasta.ServiceBastaSalaClient serviceBastaClient = null;
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                serviceBastaClient = new ServiceBasta.ServiceBastaSalaClient(instanceContext);

                string id= textboxIdSala.Text;
                int idSala = int.Parse(id);
                string limite = textboxNumParticipantes.Text;
                string nombreAnfitrion = textboxNombreUsuario.Text;

                
                int numParticipantes = int.Parse(limite);
               
                serviceBastaClient.CrearSalaEspera(idSala, numParticipantes, nombreAnfitrion);
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
