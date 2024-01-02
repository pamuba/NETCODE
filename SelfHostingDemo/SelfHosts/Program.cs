using MathServiceLibrary;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace SelfHosts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(MathService))) {
                
                ServiceEndpoint BasicHttpEndPoint1 = serviceHost.AddServiceEndpoint(
                        typeof(IMathService),
                        new BasicHttpBinding(),
                        "http://localhost:4444/MathService"
                );
                ServiceEndpoint BasicHttpEndPoint2 = serviceHost.AddServiceEndpoint(
                        typeof(IMathService),
                        new BasicHttpBinding(),
                        "http://localhost:5555/MathService"
                );
                ServiceEndpoint NettctEndPoint = serviceHost.AddServiceEndpoint(
                        typeof(IMathService),
                        new NetTcpBinding(),
                        "net.tcp://localhost:666/MathService"
                );

                foreach (ServiceEndpoint endpoint in serviceHost.Description.Endpoints) {
                    Console.WriteLine("Address: {0} Binding Name: {1}", endpoint.Address.ToString(),
                        endpoint.Binding.Name);
                }

                serviceHost.Open();
                Console.ReadKey();
                serviceHost.Close();
            }
        }
    }
}
