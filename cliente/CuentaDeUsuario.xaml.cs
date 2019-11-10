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

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para CuentaDeUsuario.xaml
    /// </summary>
    public partial class CuentaDeUsuario : Window
    {
        public CuentaDeUsuario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InicioSesion ventanaInicioSesion = new InicioSesion();
            ventanaInicioSesion.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NuevaSalaEspera ventanaNuevaSalaEspera = new NuevaSalaEspera();
            ventanaNuevaSalaEspera.Show();
            this.Close();
        }
    }
}
