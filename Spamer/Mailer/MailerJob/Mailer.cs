using Quartz;
using CsvReader.Model;
using Spamer.Mailer.Interface;
using EmailSender.Interface;
using System.Threading.Tasks;
using Serilog;

namespace Spamer.Mailer.MailerJob
{
    public class Mailer {
        private readonly IMailModel _reader;
        private readonly IEmailSender _sender;

        public Mailer() {
            _reader = new CsvReader.Loader.MailReader();
            _sender = new EmailSender.EmailSender();
        }

        public void Execute(IJobExecutionContext context)
        {
            using (var log = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(Logger.Settings.Config.FilePath)
                .CreateLogger())
            {
                log.Information("The Email Job has been started");
                var data = _reader.Read();
                Parallel.ForEach(data,
                    currentElement =>
                    {
                        _sender.SendEmailAsync(currentElement);
                    });
                log.Information("The Email Job has been ended");
            }
        }
    }
}
