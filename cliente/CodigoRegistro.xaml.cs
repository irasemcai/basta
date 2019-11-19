using cliente.ventanasExcepcion;
using System;
using System.ServiceModel;
using System.Windows;
using System.Windows.Controls;

namespace cliente
{
    public partial class CodigoRegistro : Window
    {
        public CodigoRegistro()
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
                bool ResultadoCodigo = ServiceBastaCodigoClient.VerificarCodigoRegistro(codigoInt);

                if (ResultadoCodigo == true)
                {
                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario();
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
    }
}
