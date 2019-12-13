using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicioDeChat;


namespace UnitTestProject1
{
    [TestClass]
    public class TestChat
    {
        
        ServicioDeChat.ServiceChat serviceChat = null;
       [TestMethod]
        public void TestConectar()
        {
            int idUsuarioEsperado = 1;
            string nombreUsuario = "irasema";
            TestIServiceChatCallback testIServiceChatCallback = new TestIServiceChatCallback();
            serviceChat = new ServicioDeChat.ServiceChat(() => testIServiceChatCallback);
            serviceChat.Conectar(nombreUsuario);
            Assert.AreEqual<int>(idUsuarioEsperado, testIServiceChatCallback.idUsuario, "Test conectar- Chat");
        }
        
        [TestMethod]
        public void TestEnviarMensaje()
        {
            string esperado = "Hola n?";
            TestIServiceChatCallback testIServiceChat = new TestIServiceChatCallback();

           serviceChat = new ServicioDeChat.ServiceChat(()=> testIServiceChat);

            serviceChat.EnviarMensaje("Hola", 1);

            Assert.AreEqual<string>(esperado,
                testIServiceChat.mensaje, "Test Envío de Mensaje- Chat");
        }
    }

    internal class TestIServiceChatCallback : IServiceChatCallback
    {
        private string Mensaje;
        private int IdUsuario;

        internal TestIServiceChatCallback()
        {
            this.Mensaje = " ";
            this.IdUsuario = 0;
        }

        internal string mensaje
        {
            get { return Mensaje; }
        }
        internal int idUsuario
        {
            get { return IdUsuario; }
        }

        public void RecibirMensaje(string Mensaje)
        {
            this.Mensaje = Mensaje;
        }
    }
}
