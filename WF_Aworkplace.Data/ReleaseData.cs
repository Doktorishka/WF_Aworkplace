using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Data
{
    public class ReleaseData : IReleaseData
    {
        public int getNextId(string path)
        {
            string[] Reader = File.ReadAllLines(path).Last().Split(';');
            return Convert.ToInt32(Reader[0]) + 1;
        }

        public IList getLiterature(string path)
        {
            IList _literature = new ArrayList();
            Dictionary<int, string> type = getType(TypeLiterature.pathTypeLiterature);
            string[] allLiterature = File.ReadAllLines(Literature.pathLiterature);

            foreach (string literatureString in allLiterature)
            {
                string[] line = literatureString.Split(';');
                if (line.Length == 9) { line.Where(x => x != "").ToArray(); }
                TypeLiterature tl = new TypeLiterature()
                {
                    ID = Convert.ToInt32(line[0]),
                    Author = line[1],
                    Title = line[2],
                    NumInstance = Convert.ToInt32(line[3]),
                    DateOutputLiterature = Convert.ToDateTime(line[4]),
                    IDTYPE = Convert.ToInt32(line[5]),
                    NameType = type.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value,
                    IssuesPublish = line[6]
                };
                _literature.Add(tl);

            }
            return _literature;
        }

        public IList getReaders()
        {
            IList _reader = new ArrayList();
            Dictionary<int, string> type = getType(TypeReader.pathTypeReader);
            string[] allReader = File.ReadAllLines(Reader.pathFileReaderString);

            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(';');
                if (line.Length == 9) { line.Where(x => x != "").ToArray(); }
                TypeReader tr = new TypeReader()
                {
                    ID = Convert.ToInt32(line[0]),
                    IDCARD = Convert.ToInt32(line[1]),
                    LastName = line[2],
                    FirstName = line[3],
                    Patronymic = line[4],
                    DateBirth = Convert.ToDateTime(line[5]),
                    IDTYPE = Convert.ToInt32(line[6]),
                    PlaceReader = line[7],
                    NameType = type.FirstOrDefault(x => x.Key == Convert.ToInt32(line[6])).Value
                };
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

        public int getNextIdCard(string path)
        {
            string s = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + getNextId(path).ToString();
            return Convert.ToInt32(s);
        }

        public void RegisterData(ListView lw, string path)
        {
            string[] strings = new string[lw.Items.Count];
            Dictionary<int, string> type = getType(TypeReader.pathTypeReader);
            foreach (ListViewItem row in lw.Items)
            {
                int key = type.FirstOrDefault(x => x.Value == row.SubItems[6].Text).Key;

                string s = row.Text + ";";
                s += row.SubItems[1].Text + ";";
                s += row.SubItems[2].Text + ";";
                s += row.SubItems[3].Text + ";";
                s += row.SubItems[4].Text + ";";
                s += row.SubItems[5].Text + ";";
                s += key.ToString() + ";";
                s += row.SubItems[7].Text + ";";

                strings[row.Index] = s.Trim();
            }

            File.WriteAllLines(path, strings);
        }

        public void RegisterDataLiterature(ListView lw, string path)
        {
            string[] strings = new string[lw.Items.Count];
            Dictionary<int, string> type = getType(TypeLiterature.pathTypeLiterature);
            foreach (ListViewItem row in lw.Items)
            {
                int key = type.FirstOrDefault(x => x.Value == row.SubItems[5].Text).Key;

                string s = row.Text + ";";
                s += row.SubItems[1].Text + ";";
                s += row.SubItems[2].Text + ";";
                s += row.SubItems[3].Text + ";";
                s += row.SubItems[4].Text + ";";
                s += key.ToString() + ";";
                s += row.SubItems[6].Text + ";";

                strings[row.Index] = s.Trim();
            }

            File.WriteAllLines(path, strings);
        }

        public void RegisterInputLiterature(int idL, int idCard, DateTime date)
        {
            string s = idL.ToString() +";"+idCard.ToString()+";"+date.ToShortDateString();
            File.AppendAllText("../../../WF_Aworkplace.Data/Files/OutputLiterature.txt", s);
        }
    }
}
