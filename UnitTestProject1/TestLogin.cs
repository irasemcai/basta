using Microsoft.VisualStudio.TestTools.UnitTesting;
using juegoBasta;
using juegoBasta.Domain;

namespace UnitTestProject1
{
    [TestClass]
   public class TestLogin
    {
        ServiceHost serviceLog = null;

      [TestMethod]
      public void TestRegistrarUsuario()
        {
            ClienteUsuario clienteEsperado = new ClienteUsuario()
            {
                nombre = "Juanito"
            };

            TestILoginCallback loginCallback = new TestILoginCallback();
            serviceLog = new ServiceHost(() => loginCallback);

            serviceLog.registrarUsuario("Juanito","123","caicerouv@gmail.com");

            Assert.AreEqual<object>(clienteEsperado, loginCallback.clienteUsuario, "Test registro-Login");
            
        }

        [TestMethod]
        public void TestVerificarCodigoRegistro()
        {
            ClienteUsuario clienteEsperado = new ClienteUsuario()
            {
                nombre = "Juanito"
            };
            int codigo = 0;
            serviceLog = new ServiceHost();
            ClienteUsuario clienteObtenido = serviceLog.verificarCodigoRegistro(codigo, clienteEsperado.nombre);
            Assert.AreEqual<object>(clienteEsperado, clienteObtenido, "test verificar codigo- Login");
        }

        [TestMethod]
        public void TestIniciarSesion()
        {            
            serviceLog = new ServiceHost();
            Assert.IsTrue(serviceLog.iniciarSesion("demon", "123456789"));
        }
    }

    internal class TestILoginCallback : ILoginCallback
    {
        private string Notificacion;
        private ClienteUsuario Cliente;

        internal TestILoginCallback()
        {
            this.Notificacion = " ";
            this.Cliente = null;
        }

        internal string notificacion
        {
            get { return Notificacion; }
        }
        internal ClienteUsuario clienteUsuario
        {
            
            get { return Cliente; }
        }
        public void enviarNotificacionANuevoUsuario(string notificacion)
        {
            this.Notificacion = notificacion;
        }

        public void enviarUsuarioRegistrado(ClienteUsuario clienteUsuario)
        {
            this.Cliente = clienteUsuario;
        }
    }
}
