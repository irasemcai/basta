using System;
using System.Net.Sockets;
using System.ServiceModel;

namespace HostServiceBasta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(juegoBasta.ServiceBasta)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("ServerBasta is running");
                    Console.ReadLine();
                }
                catch (SocketException)
                {
                    Console.WriteLine("ServerBasta error");
                }
            }


        }
    }
}
