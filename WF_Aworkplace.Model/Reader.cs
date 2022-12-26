using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Model
{
    public class Reader
    {
        internal protected int id { get; protected set; }
        public int ID {
            get => id;
            set {
                if (!value.GetType().Equals(typeof(Int32))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
                if (value < 0) throw new ArgumentException("Введено отрицательное число, что не приемлемо для Идентификатора!");
                if (value > Int32.MaxValue) throw new ArgumentException("Введено число, переполняющее 4 байта!");
                id = value;
            }
        }
        internal protected int idCard { get; protected set; }
        public int IDCARD
        {
            get => idCard;
            set
            {
                if (!value.GetType().Equals(typeof(Int32))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
                if (value < 0) throw new ArgumentException("Введено отрицательное число, что не приемлемо для Идентификатора!");
                if (value > Int32.MaxValue) throw new ArgumentException("Введено число, переполняющее 4 байта!");
                idCard = value;
            }
        }
        internal protected string lastName { get;  protected set; }
        public string LastName {
            get=>lastName;
            set {
                if (!value.GetType().Equals(typeof(String))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                lastName = value;  
            }
        }
        internal protected string firstName { get; protected set; }
        public string FirstName
        {
            get => firstName;
            set
            {
                if (!value.GetType().Equals(typeof(String))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                firstName = value;
            }
        }
        internal protected string patronymic { get; protected set; }
        public string Patronymic
        {
            get => patronymic;
            set
            {
                if (!value.GetType().Equals(typeof(String))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                patronymic = value;
            }
        }
        internal protected DateTime dateBirth { get; protected set; }
        public DateTime DateBirth { 
            get => dateBirth;
            set {
                if (!value.GetType().Equals(typeof(DateTime))) throw new ArgumentException($"Не соответсвие типов данных! Вместо DateTime - введено {GetType()}");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                dateBirth = value;
            }
        }
        public static string pathFileReaderString = "../../../WF_Aworkplace.Data/Files/Readers.txt";

        public Reader() { }
        public Reader(int id, int idCard, string lastName, string firstName, string patronymic, DateTime dateBirth)
        {
            this.ID = id;
            this.IDCARD = idCard;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Patronymic = patronymic;
            this.DateBirth = dateBirth;
        }
        ~Reader() { }
    }
}
