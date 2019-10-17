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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;

namespace cliente
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceBasta.ServiceBastaClient bastaClient = new ServiceBasta.ServiceBastaClient();
            

            string nombre = this.textBoxNombre.Text;
            string contrasena = this.textBoxContraseña.Text;
            string email = this.textBoxEmail.Text;

            bastaClient.AgregarUsuario(nombre, contrasena, email);
            /*
            MessageService.User user = new MessageService.User();

            MessageService.UserManagerClient client = new MessageService.UserManagerClient();

            user.UserName = "Pedro";
            user.LastName = "Sanchez";
            Console.WriteLine("Response from server: {0}", client.AddUser(user));

            */
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

