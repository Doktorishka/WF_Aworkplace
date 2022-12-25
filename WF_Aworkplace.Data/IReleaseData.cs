using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Data
{
    public interface IReleaseData
    {
        IList getReaders();
        IList getLiterature(string path);
        Dictionary<int, string> getType(string path);
    }
}
