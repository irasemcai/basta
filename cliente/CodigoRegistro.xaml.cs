using cliente.ServiceBasta;
using cliente.validacion;
using cliente.ventanasExcepcion;
using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;

namespace cliente
{
    public partial class CodigoRegistro : Window
    {
        public CodigoRegistro(ClienteUsuario clienteUsuario)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceBastaCodigoClient ServiceBastaCodigoClient = null;
            try
            {
                string Codigotxt = textBoxCodigo.Text;
                int codigoInt = int.Parse(Codigotxt);

                ServiceBastaCodigoClient = new ServiceBasta.ServiceBastaCodigoClient();
                ClienteUsuario clienteUsuario = new ClienteUsuario();
                clienteUsuario = ServiceBastaCodigoClient.verificarCodigoRegistro(codigoInt);

                if (clienteUsuario != null)
                {
                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario(clienteUsuario);
                    cuentaDeUsuario.Show();
                    this.Close();
                }
                else
                {
                    NotificarCodigoIncorrecto();
                }
            }
            catch(TimeoutException Excepcion)
            {
                ServiceBastaCodigoClient.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorTiempo(Excepcion);

            }
            catch (CommunicationException Excepcion)
            {
                ServiceBastaCodigoClient.Abort();
                NotificadorDeExcepcion Notificador = new NotificadorDeExcepcion();
                Notificador.NotificarErrorComunicacion(Excepcion);
            }
        }

        private void TextBoxCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void NotificarCodigoIncorrecto()
        {
            String Titulo = "Código Incorrecto";
            String Mensaje = "El código es incorrecto. Inténtalo de nuevo.";
            MessageBoxButton Boton = MessageBoxButton.OK;
            MessageBox.Show(Mensaje, Titulo, Boton);
        }

        private void TextBoxCodigo_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Validador Validacion = new Validador();
            bool EntradaValidada = Validacion.validarSoloNumeros(e.Text);
            if(EntradaValidada== false)
            {
                e.Handled = true;
            }

        }
    }
}
