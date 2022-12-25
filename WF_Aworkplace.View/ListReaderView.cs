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

namespace WF_Aworkplace.View
{
    public partial class ListReaderView : Form, IReadersView
    {
        public ListReaderView()
        {
            InitializeComponent();
        }

        ReaderListController _controller;

        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IDCard { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Patronymic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DateBirth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IDTYPE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NameType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isModify { set => throw new NotImplementedException(); }

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
            throw new NotImplementedException();
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
                rowToUpdate.SubItems[5].Text = reader.Patronymic.ToString();
                rowToUpdate.SubItems[5].Text = reader.DateBirth.ToShortDateString();
                rowToUpdate.SubItems[5].Text = reader.NameType.ToString();
                rowToUpdate.SubItems[5].Text = reader.PlaceReader.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddReader();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _controller.RemoveReader();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _controller.Save();
        }

        private void grdReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdReaders.SelectedItems.Count > 0)
                this._controller.SelectedReaderChanged(Convert.ToInt32(grdReaders.SelectedItems[0].Text));
        }

    }
}
