using System;
using Logger;
using CsvReader.Model;
using EmailSender.Model;
using EmailSender.Interface;


namespace EmailSender
{
    public class EmailSender : IEmailSender
    {
        public SendingResult SendEmailAsync(MailModel mailData)
        {
            try
            {
                Logger.Logger.LoggEmailData(mailData);
                Logger.Logger.LoggMessage("The email Email has been sent successfully");
            }
            catch (Exception ep)
            {
                Logger.Logger.LoggMessage("Ups");
                return SendingResult.Fail;
            }
            return SendingResult.Success;
        }
    }
}
