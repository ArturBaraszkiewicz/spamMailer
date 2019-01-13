using System;
using System.Collections.Generic;
using System.Text;

namespace CsvReader.Model
{
    public class MailModel
    {
        public string Address { get; set; }
        public string Head { get; set; }
        public string Content { get; set; }

        //public string mailToString() {
        //    return Address + ", " + Head + ", " + Content;
        //}
    }
}
