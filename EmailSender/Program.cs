using System;
using Serilog;
using Logger.Settings;
using CsvReader.Model;
using EmailSender.Model;
using EmailSender.Interface;
using Serilog.Events;

namespace EmailSender
{
    public class EmailSender : IEmailSender
    {
        public SendingResult SendEmailAsync(MailModel mailData)
        {
            using (var log = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(Logger.Settings.Config.FilePath)
                .CreateLogger())
            {
                try {
                    log.Information("Message was successfully sent!");
                    log.Information(mailData.ToString());

                }
                catch (Exception ep) {
                    log.Information(mailData.ToString());
                    log.Warning("Ups!");
                    return SendingResult.Fail;
                }
            }

            return SendingResult.Success;
        }
    }
}
