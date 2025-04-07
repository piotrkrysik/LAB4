using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Student : IWyświetl
    {
        public string Imię { get; }
        public string Nazwisko { get; }

        public Student(string imię, string nazwisko)
        {
            Imię = imię;
            Nazwisko = nazwisko;
        }

        public string PobierzIdentyfikator()
        {
            return $"Imię: {Imię}, Nazwisko: {Nazwisko}";
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            Student? otherStudent = obj as Student;
            if (otherStudent != null)
            {
                return this.Nazwisko.CompareTo(otherStudent.Nazwisko);
            }

            Bryła? otherBryła = obj as Bryła;
            if (otherBryła != null)
            {
                return -1;
            }

            return 0;
        }
    }
}
