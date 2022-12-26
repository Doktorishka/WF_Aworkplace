using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Model
{
    public class TypeLiterature : Literature
    {
        internal protected int idType { get; protected set; }
        public int IDTYPE
        {
            get => idType;
            set
            {
                if (!GetType().Equals(typeof(int))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
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
                if (!GetType().Equals(typeof(string))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                nameType = value;
            }
        }

        public TypeLiterature():base() { }
        ~TypeLiterature() { }

        public TypeLiterature(int idType, string nameType) : base()
        {
            IDTYPE = idType;
            NameType = nameType;
        }

        public TypeLiterature(int id, string author, string title,int numInstance, DateTime dateoutput,int idType, string nameType) : base(id, author, title, numInstance, dateoutput)
        {
            IDTYPE = idType;
            NameType = nameType;
        }

        public static string pathTypeLiterature = "../../../WF_Aworkplace.Data/Files/TypeLiterature.txt";
    }
}
