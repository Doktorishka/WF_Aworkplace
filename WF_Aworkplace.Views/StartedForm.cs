using System;
using System.Collections;
using System.Windows.Forms;
using WF_Aworkplace.Controller;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;
using WF_Aworkplace.Views;

namespace WF_Aworkplace.View
{
    public partial class StartedForm : Form
    {
        public StartedForm()
        {
            InitializeComponent();
        }

        private void buttonListReader_Click(object sender, EventArgs e)
        {
            ListReaderView view = new ListReaderView();
            ReleaseData releaseData= new ReleaseData();
            IList _readers = releaseData.getReaders();
            view.Visible= false;

            ReaderListController controller = new ReaderListController(view, _readers);
            controller.LoadView();
            view.ShowDialog();
        }

        private void btnListLiterature_Click(object sender, EventArgs e)
        {
            ListLiteratureView view = new ListLiteratureView();
            ReleaseData releaseData = new ReleaseData();
            IList _literature = releaseData.getLiterature(TypeLiterature.pathTypeLiterature);
            view.Visible = false;

            LiteratureListController controller = new LiteratureListController(view, _literature);
            controller.LoadView();
            view.ShowDialog();
        }
    }
}
