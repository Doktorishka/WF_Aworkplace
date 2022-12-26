using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Controller;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Views
{
    public partial class InputLiteratureView : Form
    {
        List<TypeLiterature> allLiteratures = new List<TypeLiterature>();
        Dictionary<Int32, String> typeLiterature = new Dictionary<Int32, String>();
        List<TypeReader> allReaders = new List<TypeReader>();
        List<List<string>> outputLiteratures = new List<List<string>>();

        public InputLiteratureView()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataReader.ColumnCount = 1;
            dataReader.Columns[0].HeaderText = "ФИО";

            dataOutputLiterature.ColumnCount = 3;
            dataOutputLiterature.Columns[0].HeaderText = "Идентификатор";
            dataOutputLiterature.Columns[1].HeaderText = "Наименование экземпляра";
            dataOutputLiterature.Columns[2].HeaderText = "Дата сдачи";

            string[] allType = File.ReadAllLines(TypeLiterature.pathTypeLiterature);
            foreach (string type in allType)
            {
                string[] objectType = type.Split(';');
                typeLiterature.Add(Convert.ToInt32(objectType[0]), objectType[1]);
            }

            readFromFileForData();
        }

        private void readFromFileForData()
        {
            allLiteratures.Clear();
            allReaders.Clear();
            dataReader.Rows.Clear();

            string[] allLiterature = File.ReadAllLines(Literature.pathLiterature);
            foreach (string literString in allLiterature)
            {
                string[] line = literString.Split(';');

                TypeLiterature tl = new TypeLiterature();

                tl.ID = int.Parse(line[0]);
                tl.Title = line[1];
                tl.Author = line[2];
                tl.NumInstance = Convert.ToInt32(line[3]);
                tl.DateOutputLiterature = Convert.ToDateTime(line[4]);
                tl.IDTYPE = Convert.ToInt32(line[5]);
                tl.NameType = typeLiterature.FirstOrDefault(x => x.Key == Convert.ToInt32(line[5])).Value;
                tl.IssuesPublish = line[6];

                allLiteratures.Add(tl);
            }


            string[] allReader = File.ReadAllLines(Reader.pathFileReaderString);
            foreach (string readerString in allReader)
            {
                string[] line = readerString.Split(';');

                TypeReader tr = new TypeReader();

                tr.ID = Convert.ToInt32(line[0]);
                tr.IDCARD = Convert.ToInt32(line[1]);
                tr.LastName = line[2];
                tr.FirstName = line[3];
                tr.Patronymic = line[4];
                tr.PlaceReader = line[7];

                allReaders.Add(tr);
            }

            dataReader.RowCount = allReaders.Count;

            for (int i = 0; i < dataReader.RowCount; i++)
            {
                string fio = allReaders[i].LastName + ";" + allReaders[i].FirstName + ";" + allReaders[i].Patronymic;
                dataReader.Rows[i].Cells[0].Value = fio;
                dataReader.Rows[i].HeaderCell.Value = allReaders[i].IDCARD.ToString();
            }

            string[] allOutputLiterature = File.ReadAllLines("../../../WF_Aworkplace.Data/Files/OutputLiterature.txt");

            foreach (var all in allOutputLiterature)
            {

                string[] line = all.Split(';');

                List<string> lineCol = new List<string>();

                foreach (var l in line)
                {
                    lineCol.Add(l);
                }
                outputLiteratures.Add(lineCol);
            }
        }

        private void dataReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataOutputLiterature.Rows.Clear();
            if (dataReader.SelectedCells[0].RowIndex != -1)
            {
                foreach (var output in outputLiteratures)
                {
                    if (Convert.ToInt32(output[1]) == allReaders[dataReader.SelectedCells[0].RowIndex].IDCARD)
                    {
                        dataOutputLiterature.RowCount++;
                        dataOutputLiterature.Rows[dataOutputLiterature.RowCount - 1].Cells[0].Value = findLiterature(Convert.ToInt32(output[0])).ID;
                        dataOutputLiterature.Rows[dataOutputLiterature.RowCount - 1].Cells[1].Value = findLiterature(Convert.ToInt32(output[0])).Title;
                        dataOutputLiterature.Rows[dataOutputLiterature.RowCount - 1].Cells[2].Value = output[2];
                    }
                }
            }
        }

        private TypeLiterature findLiterature(int id)
        {
            TypeLiterature type = new TypeLiterature();
            foreach (var find in allLiteratures)
            {
                if (id == find.ID) type = find;
            }
            return type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataReader.SelectedCells[0].RowIndex != -1 && dataOutputLiterature.SelectedCells[0].RowIndex != -1)
            {
                string findstring = "";
                string[] allInputLiterature = File.ReadAllLines("../../../Files/OutputLiterature.txt");

                for (int i = 0; i < allInputLiterature.Length; i++)
                {
                    string[] line = allInputLiterature[i].Split(';');

                    int io = (int)dataOutputLiterature.Rows[dataOutputLiterature.SelectedCells[0].RowIndex].Cells[0].Value - 1;

                    int? idLiterature = allLiteratures[io].ID;
                    int? idReaderCard = allReaders[dataReader.SelectedCells[0].RowIndex].IDCARD;

                    if (Convert.ToInt32(line[0]) == idLiterature && Convert.ToInt32(line[1]) == idReaderCard)
                    {
                        findstring = allInputLiterature[i];
                    }
                }
                allInputLiterature = allInputLiterature.Where(x => x != findstring).ToArray();
                File.WriteAllLines("../../../Files/OutputLiterature.txt", allInputLiterature);
                allLiteratures[(int)dataOutputLiterature.Rows[dataOutputLiterature.SelectedCells[0].RowIndex].Cells[0].Value - 1].NumInstance++;
                //allLiteratures[(int)dataOutputLiterature.Rows[dataOutputLiterature.SelectedCells[0].RowIndex].Cells[0].Value - 1].UpdateLiterature();
                MessageBox.Show("Книга успешно принята!");
                readFromFileForData();
            }
        }
    }
}
