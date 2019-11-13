using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para CodigoRegistro.xaml
    /// </summary>
    public partial class CodigoRegistro : Window
    {
        public CodigoRegistro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceBastaCodigoClient serviceBastaCodigoClient = null;

            try
            {
                string codigotxt = textBoxCodigo.Text;
                int codigoInt = int.Parse(codigotxt);

                serviceBastaCodigoClient = new ServiceBasta.ServiceBastaCodigoClient();
                bool resultadoCodigo;

                resultadoCodigo = serviceBastaCodigoClient.VerificarCodigoRegistro(codigoInt);

                if (resultadoCodigo == true)
                {
                    CuentaDeUsuario cuentaDeUsuario = new CuentaDeUsuario();
                    cuentaDeUsuario.Show();
                    this.Close();
                }
                else
                {
                    String mensaje = "ups";
                    String titulo = "el código es incorrecto. Intente de nuevo";
                    MessageBoxButton boton = MessageBoxButton.OK;
                    MessageBox.Show(mensaje, titulo, boton);
                }
            }
            catch(TimeoutException excepcion)
            {
                serviceBastaCodigoClient.Abort();
                String mensaje = "Tiempo Excedido: " + excepcion.Message;
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);

            }
            catch (CommunicationException excepcion)
            {
                serviceBastaCodigoClient.Abort();
                String mensaje = "Tiempo Excedido: " + excepcion.Message;
                String titulo = "registro de usuario";
                MessageBoxButton boton = MessageBoxButton.OK;
                MessageBox.Show(mensaje, titulo, boton);
            }
        }

        private void TextBoxCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
