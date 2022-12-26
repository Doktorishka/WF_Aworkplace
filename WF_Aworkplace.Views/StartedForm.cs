using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Controller;
using WF_Aworkplace.Data;

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
    }
}
