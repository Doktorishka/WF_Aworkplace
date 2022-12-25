using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Aworkplace.Model
{
    public abstract class Literature
    {
        internal protected int id { get; protected set; }
        public int ID {
            get => id;
            set {
                if (!GetType().Equals(typeof(int))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
                if (value < 0) throw new ArgumentException("Введено отрицательное число, что не приемлемо для Идентификатора!");
                if (value > Int32.MaxValue) throw new ArgumentException("Введено число, переполняющее 4 байта!");
                id = value;
            }
        }
        internal protected string author { get; protected set; }
        public string Author
        {
            get => author;
            set
            {
                if (!GetType().Equals(typeof(string))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                author = value;
            }
        }
        internal protected string title { get; protected set; }
        public string Title
        {
            get => title;
            set
            {
                if (!GetType().Equals(typeof(string))) throw new ArgumentException($"Не соответсвие типов данных! Вместо String - введено {GetType()}");
                if (value == "" || value == String.Empty) throw new ArgumentException("Введено пустое поле!");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                title = value;
            }
        }
        internal protected int numInstance { get; protected set; }
        public int NumInstance
        {
            get => numInstance;
            set
            {
                if (!GetType().Equals(typeof(int))) throw new ArgumentException($"Не соответсвие типов данных! Вместо Int32 - введено {GetType()}");
                if (value < 0) throw new ArgumentException("Введено отрицательное число, что не приемлемо для Идентификатора!");
                if (value > Int32.MaxValue) throw new ArgumentException("Введено число, переполняющее 4 байта!");
                numInstance = value;
            }
        }
        internal protected DateTime dateOutputLiterature { get; protected set; }
        public DateTime DateOutputLiterature
        {
            get => dateOutputLiterature;
            set
            {
                if (!GetType().Equals(typeof(DateTime))) throw new ArgumentException($"Не соответсвие типов данных! Вместо DateTime - введено {GetType()}");
                if (value == null) throw new ArgumentNullException("Введено нулевое значения поля!");
                dateOutputLiterature = value;
            }
        }
        public Literature() { }
        public Literature(int id, string author, string title,int numInstance, DateTime dateOutputLiterature)
        {
            ID = id;
            Author = author;
            Title = title;
            NumInstance = numInstance;
            DateOutputLiterature = dateOutputLiterature;
        }

        ~Literature() { }

    }
}
