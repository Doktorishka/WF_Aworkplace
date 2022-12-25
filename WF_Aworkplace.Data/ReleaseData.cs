using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Data
{
    public class ReleaseData : IReleaseData
    {
        public IList getLiterature(string path)
        {
            throw new NotImplementedException();
        }

        public IList getReaders()
        {
            IList _reader = null;
            Dictionary<int, string> type = getType(TypeLiterature.pathTypeLiterature);
            string[] allReader = File.ReadAllLines(Reader.pathFileString);

            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(';');
                TypeReader tr = new TypeReader(Convert.ToInt32(line[0]), Convert.ToInt32(line[1]), line[2], line[3], line[4], Convert.ToDateTime(line[5]), Convert.ToInt32(line[6]), type.FirstOrDefault(x => x.Key == Convert.ToInt32(line[6])).Value, line[7]);

                _reader.Add(tr);

            }
            return _reader;
        }

        public Dictionary<int, string> getType(string path)
        {
            Dictionary<int, String> type = new Dictionary<int, string>();
            string[] allType = File.ReadAllLines(path);
            foreach (string t in allType)
            {
                string[] objectType = t.Split(';');
                type.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }
            return type;
        }
    }
}
