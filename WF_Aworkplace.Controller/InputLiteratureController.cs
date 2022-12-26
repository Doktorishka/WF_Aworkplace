using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller.Interfaces
{
    public class InputLiteratureController
    {
        IReadersView _viewReader;
        ILiteraturesView _viewLiterature;
        IList _literatures;
        IList _readers;
        TypeLiterature _selectedLiterature;
        TypeReader _selectedReader;

        public InputLiteratureController(IReadersView viewReader, ILiteraturesView viewLiteratures, IList readers, IList literatures) {

            ReaderListController rc = new ReaderListController(viewReader, _readers);
            LiteratureListController lc = new LiteratureListController(viewLiteratures, _literatures);

            _viewLiterature = viewLiteratures;
            _viewReader = viewReader;
            _readers = readers;
            _literatures = literatures;
            viewReader.SetController(rc);
            viewLiteratures.SetController(lc);
        }

        public IList Readers
        {
            get { return ArrayList.ReadOnly(_readers); }
        }

        public IList Literatures
        {
            get { return ArrayList.ReadOnly(_literatures); }
        }

        public void LoadView()
        {
            _viewLiterature.ClearGrid();
            _viewReader.ClearGrid();
            foreach (TypeReader reader in _readers)
                _viewReader.AddReaderToGrid(reader);
            _viewReader.SetSelectedReaderInGrid((TypeReader)_readers[0]);

            foreach (TypeLiterature literature in _literatures)
                _viewLiterature.AddLiteratureToGrid(literature);
            _viewLiterature.SetSelectedLiteratureInGrid((TypeLiterature)_literatures[0]);
        }


        public void SelectedLiteratureChanged(int selectedId)
        {
            foreach (TypeLiterature literature in _literatures)
            {
                if (literature.ID == selectedId)
                {
                    _selectedLiterature = literature;
                    _viewLiterature.SetSelectedLiteratureInGrid(literature);
                    _viewLiterature.isModify = false;
                    break;
                }
            }
        }
    }
}
