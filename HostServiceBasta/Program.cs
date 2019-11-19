using System;
using System.ServiceModel;

namespace HostServiceBasta
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(juegoBasta.ServiceBasta)))
            {

                host.Open();
                Console.WriteLine("Server is running");
                Console.ReadLine();
            }
        }
    }
}
