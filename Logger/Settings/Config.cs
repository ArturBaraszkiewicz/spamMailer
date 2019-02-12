using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Settings
{
    public static class Config
    {
        public const string FileFormat = "{Message}{NewLine}";
        public const string FileNameFormat = "EMAIL_{Date}.csv";
        public const string FileHeaderFormat = "ID;DATE;ADDRESS;HEADER;CONTENT";
    }
}
