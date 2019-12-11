using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using juegoBasta;
using juegoBasta.Domain;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestRegistroUsuario()
        {
            bool esperado = true;

            string nombreUsuario = "mg";
            string contrasena = "123456789";
            string correo = "caicerouv@gmail.com";

            juegoBasta.ServiceBasta serviceBasta = new ServiceBasta();
            bool obtenido = serviceBasta.registrarUsuario(nombreUsuario, contrasena, correo);

            Assert.AreEqual<bool>(esperado, obtenido, "prueba registro");
        } 

        [TestMethod]
        public void TestInicioSesion()
        {
            bool esperado = true;

            string nombreUsuario = "demon";
            string contrasena = "123456789";

            juegoBasta.ServiceBasta serviceBasta = new ServiceBasta();
            bool resultado = serviceBasta.iniciarSesion(nombreUsuario, contrasena);

            Assert.AreEqual<bool>(esperado, resultado, "prueba inicio sesión");
        }

       
        [TestMethod]
        public void TestCodigoVerificacion()
        {
            ClienteUsuario clienteEsperado = new ClienteUsuario();
            clienteEsperado.nombre = "mg";
            

            int codigo = 170;

            juegoBasta.ServiceBasta serviceBasta = new ServiceBasta();
            ClienteUsuario clienteObtenido = serviceBasta.verificarCodigoRegistro(codigo, clienteEsperado);
          
            Assert.AreEqual<ClienteUsuario>(clienteEsperado, clienteObtenido, "prueba codigo" );
        } 
    } 
    }

