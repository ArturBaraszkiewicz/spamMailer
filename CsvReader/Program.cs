using System;
using System.IO;
using CsvReader.Model;
using System.Linq;
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
                //TODO: change namespace
                var reader = new CsvHelper.CsvReader(streamReader);
                reader.Configuration.Delimiter = Config.Delimiter;
                users = reader.GetRecord<MailModel>().Skip(_currentIndex).Take(Config.Count).ToList();
                _currentIndex += Config.Count;

            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
