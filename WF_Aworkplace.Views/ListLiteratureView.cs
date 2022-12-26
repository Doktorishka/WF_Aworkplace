using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Views
{
    public partial class ListLiteratureView : Form, ILiteraturesView
    {
        LiteratureListController _controller;

        public int ID { get => Convert.ToInt32(this.txtID.Text); set => Convert.ToInt32(this.txtID.Text = value.ToString()); }
        public string Author { get => txtAuthor.Text; set => txtAuthor.Text = value; }
        public string Title { get => txtTitle.Text; set => txtTitle.Text = value; }
        public int NumInstance { get => Convert.ToInt32(this.txtNum.Text); set => Convert.ToInt32(this.txtNum.Text = value.ToString()); }
        public DateTime DateOutput { get => Convert.ToDateTime(dateTimeOut.Text); set => dateTimeOut.Text = value.ToString(); }
        public bool isModify { set => txtID.Enabled = value; }
        public int IDTYPE { get => Convert.ToInt32(this.cbType.SelectedIndex); set => Convert.ToInt32(label1.Text = value.ToString()); }
        public string NameType { get => this.cbType.SelectedItem.ToString(); set => cbType.SelectedItem = value; }
        public string IssuesPublish { get => txtPublish.Text; set => txtPublish.Text = value; }

        public ListLiteratureView()
        {
            InitializeComponent();
            Dictionary<int, string> type = getType(TypeLiterature.pathTypeLiterature);
            foreach (var t in type)
            {
                cbType.Items.Add(t.Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddLiterature();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _controller.RemoveLiterature();
            ReleaseData r = new ReleaseData();
            r.RegisterDataLiterature(grdLiterature, Literature.pathLiterature);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _controller.Save();
            ReleaseData r = new ReleaseData();
            r.RegisterDataLiterature(grdLiterature, Literature.pathLiterature);
        }

        public void ClearGrid()
        {

            grdLiterature.Columns.Clear();
            grdLiterature.Columns.Add("ИД", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("Автор", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("Заголовок", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("В наличии", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("Дата выпуска", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("Тип", 150, HorizontalAlignment.Left);
            grdLiterature.Columns.Add("Издатель", 150, HorizontalAlignment.Left);

            grdLiterature.Items.Clear();
        }

        public void AddLiteratureToGrid(TypeLiterature literature)
        {
            ListViewItem item;
            item = grdLiterature.Items.Add(literature.ID.ToString());
            item.SubItems.Add(literature.Author.ToString());
            item.SubItems.Add(literature.Title.ToString());
            item.SubItems.Add(literature.NumInstance.ToString());
            item.SubItems.Add(literature.DateOutputLiterature.ToShortDateString());
            item.SubItems.Add(literature.NameType);
            item.SubItems.Add(literature.IssuesPublish);
        }

        public void UpdateGridWithChangedReader(TypeLiterature literature)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in grdLiterature.Items)
            {
                if (Convert.ToInt32(row.Text) == literature.ID)
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = literature.ID.ToString();
                rowToUpdate.SubItems[1].Text = literature.Author.ToString();
                rowToUpdate.SubItems[2].Text = literature.Title.ToString();
                rowToUpdate.SubItems[3].Text = literature.NumInstance.ToString();
                rowToUpdate.SubItems[4].Text = literature.DateOutputLiterature.ToShortDateString();
                rowToUpdate.SubItems[5].Text = literature.NameType.ToString();
                rowToUpdate.SubItems[6].Text = literature.IssuesPublish.ToString();
            }
        }

        public void RemoveLiteratureFromGrid(TypeLiterature literature)
        {
            ListViewItem rowToRemove = null;
            foreach (ListViewItem row in grdLiterature.Items)
            {
                if (Convert.ToInt32(row.Text) == literature.ID)
                {
                    rowToRemove = row;
                }
            }
            if (rowToRemove != null)
            {
                grdLiterature.Items.Remove(rowToRemove);
                grdLiterature.Focus();
            }
        }

        public void SetSelectedLiteratureInGrid(TypeLiterature literature)
        {
            foreach (ListViewItem row in grdLiterature.Items)
            {
                if (Convert.ToInt32(row.Text) == literature.ID)
                {
                    row.Selected = true;
                }
            }
        }

        public void SetController(LiteratureListController controller)
        {
            _controller = controller;
        }

        public int GetIdOfSelectedLiteratureInGrid()
        {
            throw new NotImplementedException();
        }

        public bool isIdValidation(int id)
        {
            bool rule = true;

            if (id == 0 || id == -1) rule = false;

            return rule;
        }

        public Dictionary<int, string> getType(string path)
        {
            ReleaseData r = new ReleaseData();
            return r.getType(path);
        }

        private void grdLiterature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdLiterature.SelectedItems.Count > 0)
                this._controller.SelectedLiteratureChanged(Convert.ToInt32(grdLiterature.SelectedItems[0].Text));
        }
    }
}
