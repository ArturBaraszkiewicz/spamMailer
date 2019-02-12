using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvReader.Model;
using CsvReader.Settings;

namespace CsvReader.Loader
{
    public class MailReader
    {
        private static int _currentIndex = 0;

        public List<MailModel> Read()
        {
            List<MailModel> users;
            using (var streamReader = File.OpenText(Config.Path))
            {
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
