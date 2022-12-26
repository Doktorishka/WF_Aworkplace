using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Controller;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.View
{
    public partial class ListReaderView : Form, IReadersView
    {
        public ListReaderView()
        {
            InitializeComponent();
            Dictionary<int, string> type = getType(TypeReader.pathTypeReader);
            foreach (var t in type) {
                cbType.Items.Add(t.Value);
            }
                
        }

        ReaderListController _controller;

        public int ID { get => Convert.ToInt32(this.txtID.Text); set => Convert.ToInt32(this.txtID.Text = value.ToString()); }
        public int IDCard { get => Convert.ToInt32(this.txtIdCard.Text); set => Convert.ToInt32(this.txtIdCard.Text = value.ToString()); }
        public string FirstName { get => txtFirstName.Text; set => txtFirstName.Text = value; }
        public string LastName { get => txtLastName.Text; set => txtLastName.Text = value; }
        public string Patronymic { get => txtPatronymic.Text; set => txtPatronymic.Text = value; }
        public DateTime DateBirth { get => Convert.ToDateTime(dateTimeBirth.Text); set => dateTimeBirth.Text = value.ToString(); }
        public int IDTYPE { get => Convert.ToInt32(this.cbType.SelectedIndex); set => Convert.ToInt32(label1.Text = value.ToString()); }
        public string NameType { get => this.cbType.SelectedItem.ToString(); set => cbType.SelectedItem = value; }
        public bool isModify { set => txtID.Enabled = value; }
        public string PlaceReader { get => txtPlace.Text; set => txtPlace.Text = value; }

        public void AddReaderToGrid(WF_Aworkplace.Model.TypeReader reader)
        {
            ListViewItem item;
            item = grdReaders.Items.Add(reader.ID.ToString());
            item.SubItems.Add(reader.IDCARD.ToString());
            item.SubItems.Add(reader.LastName.ToString());
            item.SubItems.Add(reader.FirstName.ToString());
            item.SubItems.Add(reader.Patronymic.ToString());
            item.SubItems.Add(reader.DateBirth.ToShortDateString());
            item.SubItems.Add(reader.NameType);
            item.SubItems.Add(reader.PlaceReader);
            
        }

        public void ClearGrid()
        {
            grdReaders.Columns.Clear();
            grdReaders.Columns.Add("ИД", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Номер билета", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Фамилия", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Имя", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Отчество", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Дата рождения", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Тип читателя", 150, HorizontalAlignment.Left);
            grdReaders.Columns.Add("Место", 150, HorizontalAlignment.Left);

            grdReaders.Items.Clear();
        }

        public int GetIdOfSelectedUserInGrid()
        {
            if (grdReaders.SelectedItems.Count > 0)
                return Convert.ToInt32(grdReaders.SelectedItems[0].Text);
            else return -1;
        }

        public bool isIdValidation(int id)
        {
            bool rule = true;

            if (id == 0 || id == -1) rule = false;

            return rule;
        }

        public void RemoveReaderFromGrid(WF_Aworkplace.Model.TypeReader reader)
        {
            ListViewItem rowToRemove = null;
            foreach (ListViewItem row in grdReaders.Items) {
                if (Convert.ToInt32(row.Text) == reader.ID) {
                    rowToRemove = row;
                }
            }
            if (rowToRemove != null) {
                grdReaders.Items.Remove(rowToRemove);
                grdReaders.Focus();
            }
            string[] strings;
            foreach (ListViewItem row in grdReaders.Items)
            { 
                string s = row.Text+";";
            }

        }

        public void SetController(ReaderListController controller)
        {
            _controller = controller;
        }

        public void SetSelectedReaderInGrid(WF_Aworkplace.Model.TypeReader reader)
        {
            foreach (ListViewItem row in grdReaders.Items)
            {
                if (Convert.ToInt32(row.Text) == reader.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public void UpdateGridWithChangedReader(WF_Aworkplace.Model.TypeReader reader)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in grdReaders.Items)
            {
                if (Convert.ToInt32(row.Text) == reader.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = reader.ID.ToString();
                rowToUpdate.SubItems[1].Text = reader.IDCARD.ToString();
                rowToUpdate.SubItems[2].Text = reader.LastName.ToString();
                rowToUpdate.SubItems[3].Text = reader.FirstName.ToString();
                rowToUpdate.SubItems[4].Text = reader.Patronymic.ToString();
                rowToUpdate.SubItems[5].Text = reader.DateBirth.ToShortDateString();
                rowToUpdate.SubItems[6].Text = reader.NameType.ToString();
                rowToUpdate.SubItems[7].Text = reader.PlaceReader.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddReader();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _controller.RemoveReader();
            ReleaseData r = new ReleaseData();
            r.RegisterData(grdReaders, Reader.pathFileReaderString);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _controller.Save();
            ReleaseData r = new ReleaseData();
            r.RegisterData(grdReaders, Reader.pathFileReaderString);
        }

        private void grdReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdReaders.SelectedItems.Count > 0)
                this._controller.SelectedReaderChanged(Convert.ToInt32(grdReaders.SelectedItems[0].Text));
        }

        public Dictionary<int, string> getType(string path)
        {
           ReleaseData r = new ReleaseData();
            return r.getType(path);
        }
    }
}
