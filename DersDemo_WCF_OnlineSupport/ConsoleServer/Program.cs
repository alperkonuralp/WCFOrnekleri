using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using OnlineSupportServiceLibrary;

namespace ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineSupportService obj =
                new OnlineSupportService();

            using (ServiceHost host = new ServiceHost(obj))
            {
                host.Open();

                Console.WriteLine("Çıkış için enter'a basınız.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
