using System;
using System.IO;
using CsvHelper;
using System.Linq;
using CsvReader.Model;
using CsvReader.Settings;
using System.Collections.Generic;

namespace CsvReader
{
    class Program
    {
        private int _currentIndex = 0;

        public List<MailModel> Read() {
            List<MailModel> users;
            using (var streamReader = File.OpenText(Config.Path)) {
                //TODO: change namespace
                var reader = new CsvHelper.CsvReader(streamReader);
                reader.Configuration.Delimiter = Config.Delimiter;
                users = reader.GetRecords<MailModel>().Skip(_currentIndex).Take(Config.Count).ToList();
                _currentIndex += Config.Count;
            }
            return users;
        }
    }
}
