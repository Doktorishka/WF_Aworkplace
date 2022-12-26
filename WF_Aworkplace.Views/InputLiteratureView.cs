using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
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
        public InputLiteratureView()
        {
            InitializeComponent();
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
                    int? idReaderCard = allReaders[dataReader.SelectedCells[0].RowIndex].IDReaderCard;

                    if (Convert.ToInt32(line[0]) == idLiterature && Convert.ToInt32(line[1]) == idReaderCard)
                    {
                        findstring = allInputLiterature[i];
                    }
                }
                allInputLiterature = allInputLiterature.Where(x => x != findstring).ToArray();
                File.WriteAllLines("../../../Files/OutputLiterature.txt", allInputLiterature);
                allLiteratures[(int)dataOutputLiterature.Rows[dataOutputLiterature.SelectedCells[0].RowIndex].Cells[0].Value - 1].COUNT++;
                allLiteratures[(int)dataOutputLiterature.Rows[dataOutputLiterature.SelectedCells[0].RowIndex].Cells[0].Value - 1].UpdateLiterature();
                MessageBox.Show("Книга успешно принята!");
                readFromFileForData();
            }
        }
    }
}
