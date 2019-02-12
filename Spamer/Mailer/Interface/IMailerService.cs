using System;
using System.Collections.Generic;
using System.Text;

namespace Spamer.Mailer.Interface
{
    public interface IMailerService {
        void Start();
        void Stop();
    }
}
