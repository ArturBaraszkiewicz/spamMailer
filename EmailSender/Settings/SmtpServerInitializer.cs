using EASendMail;

namespace EmailSender.Settings
{
    public class SmtpServerInitializer
    {
        public static SmtpServer GetSmtpServer()
        {
            var smtpServer = new SmtpServer("smtp.gmail.com")
            {
                //removed because the code is in a public repository
                User = "",
                Password = "",
                ConnectType = SmtpConnectType.ConnectSSLAuto,
                Port = 465
            };
            return smtpServer;
        }
    }
}
