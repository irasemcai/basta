using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ServiceModel;
using cliente.ServiceBasta;
using System.Collections;

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para NuevaSalaEspera.xaml
    /// </summary>
    // [CallbackBehavior(UseSynchronizationContext = false)]
   [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public partial class NuevaSalaEspera : Window, ServiceBasta.IServiceBastaSalaCallback
    {
        ServiceBasta.ClienteUsuario clienteUsuario = null;
        ServiceBasta.ServiceBastaSalaClient serviceBastaClient = null;

        public NuevaSalaEspera(ClienteUsuario cliente)
        {
            InitializeComponent();
            
            textboxNombreUsuario.Text = cliente.nombre;
            clienteUsuario = cliente;

            InstanceContext instanceContext = new InstanceContext(this);
            serviceBastaClient = new ServiceBastaSalaClient(instanceContext);
            ClienteUsuario[] ClientesConectados  = serviceBastaClient.mostrarClientesConectados();
           
            ActualizarClientes(ClientesConectados);
        }
        
        public void ActualizarClientes(ClienteUsuario[] clientes)  //hacer el lock()
        {                                                           //el revo si se conecto pero sucedió una ezcepacion para el callback del revo : no se puede usar para la comunicación porque se anuló.
            ArrayList arrayList = new ArrayList();                  //hacer método: obtener lista de jugadores ya conectados a la sala
            if(clientes!= null)
            {
                foreach (ClienteUsuario c in clientes)
                {
                    arrayList.Add(c.nombre);
                }
            }      
            ListBoxUsuariosEnLaSala.ItemsSource = arrayList;
        }

       
      
        private void ButtonUnirSala_Click(object sender, RoutedEventArgs e)
        {                     
            try
            {
                InstanceContext instanceContext = new InstanceContext(this);
                serviceBastaClient = new ServiceBasta.ServiceBastaSalaClient(instanceContext);

                serviceBastaClient.unirseASala(clienteUsuario);
            }
            catch (CommunicationException excepcion)
            {
                serviceBastaClient.Abort();
                MessageBox.Show("ocurrio  " + excepcion.Message);
            }
            catch (TimeoutException excepcion)
            {
                serviceBastaClient.Abort();
                MessageBox.Show("ocurrio  " + excepcion.Message);
            }
            finally
            {
                if (serviceBastaClient.InnerChannel.State == CommunicationState.Faulted)
                {
                    serviceBastaClient.InnerChannel.Open();
                    serviceBastaClient.unirseASala(clienteUsuario);
                }                
               } 
        }

        private void ButtonCrearSala_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



