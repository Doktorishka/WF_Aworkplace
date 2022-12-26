using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller.Interfaces
{
    public class LiteratureListController
    {
        ILiteraturesView _view;
        IList _literatures;
        TypeLiterature _selectedLiterature;

        public LiteratureListController(ILiteraturesView view, IList literatures)
        {
            _view = view;
            _literatures = literatures;
            view.SetController(this);
        }

        public IList Literatures {
            get { return ArrayList.ReadOnly(_literatures); }
        }

        private void updateViewDetailValues(TypeLiterature literature) { 
            _view.ID = literature.ID;
            _view.Author = literature.Author;
            _view.Title = literature.Title;
            _view.DateOutput = literature.DateOutputLiterature;
            _view.IDTYPE = literature.IDTYPE;
            _view.NameType = literature.NameType;
            _view.IssuesPublish = literature.IssuesPublish;
        }

        private void updateReaderWithViewValues(TypeLiterature literature)
        {
            literature.ID = _view.ID;
            literature.Author = _view.Author;
            literature.Title = _view.Title;
            literature.DateOutputLiterature = _view.DateOutput;
            literature.IDTYPE = _view.IDTYPE;
            literature.NameType = _view.NameType;
            literature.IssuesPublish = _view.IssuesPublish;
        }

        public void LoadView()
        {
            _view.ClearGrid();
            foreach (TypeLiterature literature in _literatures)
                _view.AddLiteratureToGrid(literature);
            _view.SetSelectedLiteratureInGrid((TypeLiterature)_literatures[0]);
        }

        public void SelectedLiteratureChanged(int selectedId)
        {
            foreach (TypeLiterature literature in _literatures)
            {
                if (literature.ID == selectedId)
                {
                    _selectedLiterature = literature;
                    updateViewDetailValues(literature);
                    _view.SetSelectedLiteratureInGrid(literature);
                    _view.isModify = false;
                    break;
                }
            }
        }

        public void RemoveLiterature()
        {
            int id = _view.GetIdOfSelectedLiteratureInGrid();
            TypeLiterature removeLiterature = null;
            if (_view.isIdValidation(id))
            {
                foreach (TypeLiterature literature in _literatures)
                    if (literature.ID == id)
                    {
                        removeLiterature = literature;
                        break;
                    }
            }
            if (removeLiterature != null)
            {
                int newSelectedIndex = _literatures.IndexOf(removeLiterature);
                _literatures.Remove(removeLiterature);
                _view.RemoveLiteratureFromGrid(removeLiterature);

                if (newSelectedIndex > -1 && newSelectedIndex < _literatures.Count)
                {
                    _view.SetSelectedLiteratureInGrid((TypeLiterature)_literatures[newSelectedIndex]);
                }
            }

        }

        public void Save()
        {
            updateReaderWithViewValues(_selectedLiterature);
            if (!_literatures.Contains(_selectedLiterature))
            {
                _literatures.Add(_selectedLiterature);
                _view.AddLiteratureToGrid(_selectedLiterature);
            }
            else
            {
                _view.UpdateGridWithChangedReader(_selectedLiterature);
            }
            _view.SetSelectedLiteratureInGrid(_selectedLiterature);
            this._view.isModify = false;
        }


        public void AddLiterature()
        {
            ReleaseData r = new ReleaseData();
            _selectedLiterature = new TypeLiterature(r.getNextId(Literature.pathLiterature),"Введите автора", "Введите заголовок", 1, DateTime.Now, 1,"enter","enter");
            updateViewDetailValues(_selectedLiterature);
            _view.isModify = true;
        }

    }
}
