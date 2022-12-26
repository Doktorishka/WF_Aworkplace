using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Data
{
    public interface IReleaseData
    {
        IList getReaders();
        void RegisterData(ListView lw, string path);
        int getNextId(string path);
        int getNextIdCard(string path);
        IList getLiterature(string path);
        Dictionary<int, string> getType(string path);
    }
}
