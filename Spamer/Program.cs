using System;
using Topshelf;
using CsvReader.Model;

namespace Spamer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            HostFactory.Run(x =>
            {
                x.SetServiceName("Spamer");
                x.SetDescription("Service for sending emails");

                x.Service<IMailModel>( service =>
                {
                        
                });

            });
            Console.WriteLine("End");
        }
    }
}
