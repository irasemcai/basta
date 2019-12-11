using Microsoft.VisualStudio.TestTools.UnitTesting;
using juegoBasta;

namespace PruebasJuegoBasta
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegistrarUsuario()
        {
            bool esperado = true;

            string nombreUsuario = "demon";
            string contrasena = "123456789";
            string correo = "caicerouv@gmail.com";

            juegoBasta.ServiceBasta serviceBasta = new ServiceBasta();
            bool obtenido = serviceBasta.registrarUsuario(nombreUsuario, contrasena, correo);

            Assert.AreEqual<bool>(esperado, obtenido, "prueba registro");
        }
    }
}
