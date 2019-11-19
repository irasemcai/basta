
using System.Windows;

namespace cliente.ventanasExcepcion
{
    class NotificadorDeExcepcion
    {
        private string Titulo = "Ha ocurrido un fallo";

        public void NotificarErrorComunicacion(System.ServiceModel.CommunicationException CommunicationException)
        {                  
            string Mensaje = "La conexion con el servidor no está disponible en este momento: " + CommunicationException.Message;
            MessageBoxButton BotonOk = MessageBoxButton.OK;
            MessageBox.Show(Mensaje, Titulo, BotonOk);
        }

        public void NotificarErrorTiempo(System.TimeoutException TimeoutException)
        {           
            string mensaje = "Tiempo Excedido: " + TimeoutException.Message;          
            MessageBoxButton BotonOk = MessageBoxButton.OK;
            MessageBox.Show(mensaje, Titulo, BotonOk);
        }
    }
}
