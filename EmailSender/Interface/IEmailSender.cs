using EmailSender.Model;
using CsvReader.Model;

namespace EmailSender.Interface
{
    public interface IEmailSender
    {
        SendingResult SendEmailAsync(MailModel mailData);
    }
}
