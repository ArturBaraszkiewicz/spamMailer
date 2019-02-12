using Quartz;
using CsvReader.Model;
using Spamer.Mailer.Interface;

namespace Spamer.Mailer.MailerJob
{
    public class Mailer : IMailer {
        private readonly IMailModel _reader;

        public Mailer() {

        }

        public void Execute(IJobExecutionContext context)
        {

        }
    }
}
