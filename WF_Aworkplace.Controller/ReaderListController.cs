using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_Aworkplace.Controller.Interfaces;
using WF_Aworkplace.Data;
using WF_Aworkplace.Model;

namespace WF_Aworkplace.Controller
{
    public class ReaderListController
    {
        IReadersView _view;
        IList _readers;
        TypeReader _selectedReader;

        public ReaderListController(IReadersView view, IList readers) {
            _view = view;
            _readers = readers;
            view.SetController(this);
        }

        public IList Readers { 
            get { return ArrayList.ReadOnly(_readers); }
        }

        private void updateViewDetailValues(TypeReader reader) {
            _view.ID = reader.ID;
            _view.IDCard = reader.IDCARD;
            _view.LastName = reader.LastName;
            _view.FirstName = reader.FirstName;
            _view.DateBirth = reader.DateBirth;
            _view.Patronymic = reader.Patronymic;
            _view.IDTYPE = reader.IDTYPE;
            _view.NameType = reader.NameType;
            _view.PlaceReader = reader.PlaceReader;

        }

        private void updateReaderWithViewValues(TypeReader reader) {
            reader.ID = _view.ID;
            reader.IDCARD = _view.IDCard;
            reader.LastName = _view.LastName;
            reader.FirstName = _view.FirstName;
            reader.DateBirth = _view.DateBirth;
            reader.Patronymic = _view.Patronymic;
            reader.IDTYPE = _view.IDTYPE;
            reader.NameType = _view.NameType;
            reader.PlaceReader = _view.PlaceReader;
        }

        public void LoadView() {
            _view.ClearGrid();
            foreach (TypeReader reader in _readers)
                _view.AddReaderToGrid(reader);
            _view.SetSelectedReaderInGrid((TypeReader)_readers[0]);
        }

        public void SelectedReaderChanged(int selectedId) {
            foreach (TypeReader reader in _readers) {
                if (reader.ID == selectedId) { 
                    _selectedReader = reader;
                    updateViewDetailValues(reader);
                    _view.SetSelectedReaderInGrid(reader);
                    _view.isModify = false;
                    break;
                }
            }
        }

        public void AddReader() {
            ReleaseData r = new ReleaseData();
            _selectedReader = new TypeReader(r.getNextId(Reader.pathFileReaderString),r.getNextIdCard(Reader.pathFileReaderString),"Введите фамилию","Введите имя","введите отчество",DateTime.Now,1,"Выберите","Выберите");
            updateViewDetailValues(_selectedReader);
            _view.isModify = true;
        }

        public void RemoveReader(){
            int id = _view.GetIdOfSelectedUserInGrid();
            TypeReader removeReader = null;
            if (_view.isIdValidation(id)) {
                foreach (TypeReader reader in _readers)
                    if (reader.ID == id)
                    {
                        removeReader = reader;
                        break;
                    }
            }
            if(removeReader != null)
            {
                int newSelectedIndex = _readers.IndexOf(removeReader);
                _readers.Remove(removeReader);
                _view.RemoveReaderFromGrid(removeReader);

                if (newSelectedIndex > -1 && newSelectedIndex < _readers.Count) {
                    _view.SetSelectedReaderInGrid((TypeReader)_readers[newSelectedIndex]);
                }
            }

        }

        public void Save() { 
            updateReaderWithViewValues(_selectedReader);
            if (!_readers.Contains(_selectedReader)) { 
                _readers.Add(_selectedReader);
                _view.AddReaderToGrid(_selectedReader);
            }
            else{ 
                _view.UpdateGridWithChangedReader(_selectedReader);
            }
            _view.SetSelectedReaderInGrid(_selectedReader);
            this._view.isModify = false;
        }
        
    }
}
