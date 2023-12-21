using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using MathServiceLibrary;

namespace SelfHostN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var serviceHost = new ServiceHost(typeof(MathService))) {

                ServiceEndpoint BasicHttpEndPoint1 = serviceHost.AddServiceEndpoint(
                   typeof(IMathService),
                   new BasicHttpBinding(),
                   "http://localhost:4444/MathService");

                ServiceEndpoint BasicHttpEndPoint2 = serviceHost.AddServiceEndpoint(
                   typeof(IMathService),
                   new BasicHttpBinding(),
                   "http://localhost:5555/MathService");

                ServiceEndpoint NettcpEndPoint = serviceHost.AddServiceEndpoint(
                   typeof(IMathService),
                   new NetTcpBinding(),
                   "net.tcp://localhost:6666/MathService");

                serviceHost.Open();

                foreach (ServiceEndpoint endPoint in serviceHost.Description.Endpoints) {
                    Console.WriteLine("Address: {0} Binding Name: {1}", endPoint.Address.ToString(),
                        endPoint.Binding.Name);
                }

                Console.WriteLine("Press any Key to STOP the WCF Math Service");
                Console.ReadKey();

                serviceHost.Close();
            }
        }
    }
}
