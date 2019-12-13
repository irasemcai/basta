using System;
using System.Net.Sockets;
using System.ServiceModel;
using Host = System.ServiceModel.ServiceHost;
using ServiceHost = juegoBasta.ServiceHost;

namespace HostServiceBasta
{
    internal static class Program
    {

        static void Main(string[] args)
        {

            using (var host = new Host(typeof(ServiceHost)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine($"ServerBasta is running now {host.Description.Name}");
                    Console.ReadLine();
                }
                catch (CommunicationException e)
                {
                    Console.WriteLine("ServerBasta error"+ e.Message);
                }
            }


        }
    }
}

