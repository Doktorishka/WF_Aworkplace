using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller.Interfaces
{
    public interface IReadersView
    {
        void ClearGrid();
        void AddReaderToGrid(TypeReader reader);
        void UpdateGridWithChangedReader(TypeReader reader);
        void RemoveReaderFromGrid(TypeReader reader);
        void SetSelectedReaderInGrid(TypeReader reader);
        void SetController(ReaderListController controller);
        int GetIdOfSelectedUserInGrid();
        bool isIdValidation(int id);

        int ID { get; set; }
        int IDCard { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Patronymic { get; set; }
        DateTime DateBirth { get; set; }
        int IDTYPE { get; set; }
        string NameType { get; set; }
        string PlaceReader { get; set; }
        bool isModify { set; }

        Dictionary<int, string> getType(string path);
    }
}
