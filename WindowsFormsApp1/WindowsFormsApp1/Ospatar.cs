using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Ospatar : IClonable, IComparable, IEnumerable
    {
        private string nume;
        private int varsta;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }

        public Ospatar(string nume, int varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }

        public object Clone()
        {
            return new Ospatar(nume, varsta);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Ospatar otherOspatar = obj as Ospatar;
            if (otherOspatar != null)
            {
                return this.varsta.CompareTo(otherOspatar.varsta);
            }
            else
            {
                throw new ArgumentException("Obiectul nu este de tipul Ospatar");
            }
        }

        public static Ospatar operator +(Ospatar ospatar1, Ospatar ospatar2)
        {
            return new Ospatar(ospatar1.nume + " și " + ospatar2.nume, (ospatar1.varsta + ospatar2.varsta) / 2);
        }

        public void Proceseaza()
        {
            Console.WriteLine("Procesare date pentru Ospatar");
        }

        public IEnumerator GetEnumerator()
        {
            yield return nume;
            yield return varsta;
        }

        // Suprascrierea operatorului de indexare []
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return nume;
                else if (index == 1)
                    return varsta;
                else
                    throw new IndexOutOfRangeException("Index invalid");
            }
            set
            {
                if (index == 0)
                    nume = value.ToString();
                else if (index == 1)
                    int.TryParse(value.ToString(), out varsta);
                else
                    throw new IndexOutOfRangeException("Index invalid");
            }
        }
    }
}
