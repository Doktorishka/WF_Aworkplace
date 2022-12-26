using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller.Interfaces
{
    public interface IInputLiteratureView
    {
        void ClearGrid();
        void AddLiteratureToGrid(TypeLiterature literature);
        void AddReaderToGrid(TypeReader reader);
        void SetSelectedLiteratureInGrid(TypeLiterature reader);
        void SetSelectedReaderInGrid(TypeReader reader);
        void SetController(InputLiteratureController controller);
        int GetIdOfSelectedLiteratureInGrid();
        int GetIdOfSelectedReaderInGrid();
        bool isIdValidation(int id);
        Dictionary<int, string> getType(string path);
    }
}
