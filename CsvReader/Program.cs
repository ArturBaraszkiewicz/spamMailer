using System;
using System.IO;
using CsvReader.Model;
using System.Collections.Generic;
using CsvReader.Settings;
using CsvHelper;

namespace CsvReader
{
    class Program
    {
        private static int _currentIndex = 0;

        public List<MailModel> Read() {
            List<MailModel> users;
            using (var streamReader = File.OpenText(Config.Path)) {
                
            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
