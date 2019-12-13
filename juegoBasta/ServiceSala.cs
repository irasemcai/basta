using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using juegoBasta.Domain;

namespace juegoBasta
{
    public partial class ServiceHost : IServiceBastaSala
    {
        private IBastaSalaCallback bastaSalaCallback = null;

        Dictionary<string, IBastaSalaCallback> JUGADORESSALA = new Dictionary<string, IBastaSalaCallback>();
        List<ClienteUsuario> LISTAUSUARIOSENLASALA;

        public void crearSalaEspera(ClienteUsuario usuario)
        {
           
        }

        public List<ClienteUsuario> mostrarClientesConectados()
        {
            return LISTAUSUARIOSENLASALA;
        }

        public void unirseASala(ClienteUsuario cliente)
        {
            bastaSalaCallback = OperationContext.Current.GetCallbackChannel<IBastaSalaCallback>();

            Console.WriteLine(":(");
            if (bastaSalaCallback != null)
            {
                Console.WriteLine(":((");
                if (JUGADORESSALA.ContainsKey(cliente.nombre))
                {
                    Console.WriteLine("usuario ya en lista");
                    return;
                }
                else
                {
                    JUGADORESSALA.Add(cliente.nombre, bastaSalaCallback);
                    LISTAUSUARIOSENLASALA.Add(cliente);
                    Console.WriteLine(":(((");
                    try
                    {
                       // var jugadoresQueNoSonYo = JUGADORESSALA.Where(j => j.Key != cliente.nombre);
                        foreach (var jugador in JUGADORESSALA)
                        {
                            var callback = jugador.Value;
                            callback.ActualizarClientes(LISTAUSUARIOSENLASALA);
                        }
                        Console.WriteLine(":((((");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message}" + $"{e.InnerException}");
                    }

                }

            }
            Console.WriteLine(":D");
        }
    }
}
