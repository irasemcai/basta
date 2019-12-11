using cliente.ServiceBasta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace cliente
{
    /// <summary>
    /// Lógica de interacción para CuentaDeUsuario.xaml
    /// </summary>
    public partial class CuentaDeUsuario : Window
    {
        ServiceBasta.ClienteUsuario ClienteUsuario = null;
        public CuentaDeUsuario(ClienteUsuario cliente )
        {
            InitializeComponent();
            textBlockUserName.Text = cliente.nombre;
            ClienteUsuario = cliente;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InicioSesion ventanaInicioSesion = new InicioSesion();
            ventanaInicioSesion.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NuevaSalaEspera ventanaNuevaSalaEspera = new NuevaSalaEspera(ClienteUsuario);
            ventanaNuevaSalaEspera.Show();
            this.Close();
        }

    }
}
