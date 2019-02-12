using System;
using Quartz;
using Topshelf;
using Topshelf.Quartz;
using CsvReader.Model;
using Spamer.Mailer.Service;
using Spamer.Mailer.Interface;


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

                x.Service<IMailerService>(service =>
               {
                   service.ConstructUsing(srv => new MailerService());

                   service.WhenStarted(srv => srv.Start());
                   service.WhenStopped(srv => srv.Stop());

                   service.ScheduleQuartzJob(q =>
                        q.WithJob(() =>
                        JobBuilder.Create<Mailer.MailerJob.Mailer>().Build())
                        .AddTrigger(() => TriggerBuilder.Create()
                        .WithSimpleSchedule(b => b
                        .WithIntervalInSeconds(60)
                        .RepeatForever())
                        .Build()));
               });

            });
            Console.WriteLine("End");
        }
    }
}
