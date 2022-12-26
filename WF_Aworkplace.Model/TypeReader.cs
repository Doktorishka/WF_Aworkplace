using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Model
{
    public class TypeReader : Reader
    {
        internal protected int idType { get; protected set; }
        public int IDTYPE
        {
            get => idType;
            set
            {
                if (!value.GetType().Equals(typeof(Int32))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
                if (value < 0) throw new ArgumentException("Введено отрицательное число, что не приемлемо для Идентификатора!");
                if (value > Int32.MaxValue) throw new ArgumentException("Введено число, переполняющее 4 байта!");
                idType = value;
            }
        }
        internal protected string nameType { get; protected set; }
        public string NameType
        {
            get => nameType;
            set
            {
                if (!value.GetType().Equals(typeof(String))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                nameType = value;
            }
        }
        internal protected string placeReader { get; protected set; }
        public string PlaceReader
        {
            get => placeReader;
            set
            {
                if (!value.GetType().Equals(typeof(string))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                placeReader = value;
            }
        }


        public TypeReader():base() { }
        public TypeReader(int id, int idCard, string lastName, string firstName, string patronymic, DateTime dateBirth, int iDTYPE, string nameType, string placeReader): base(id, idCard, lastName, firstName, patronymic, dateBirth)
        {
            IDTYPE = iDTYPE;
            NameType = nameType;
            PlaceReader = placeReader;
        }
        public static string pathTypeReader = "../../../WF_Aworkplace.Data/Files/TypeReader.txt";

        ~TypeReader() { }
    }
}
