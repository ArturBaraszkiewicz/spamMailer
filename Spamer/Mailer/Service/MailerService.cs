using System;
using System.Text;
using Spamer.Mailer.Interface;
using System.Collections.Generic;

namespace Spamer.Mailer.Service
{
    public class MailerService : IMailerService
    {
        public void Start()
        {
            Console.WriteLine("Service start!");
        }
        public void Stop()
        {
            Console.WriteLine("Service stop!");
        }
    }
}
