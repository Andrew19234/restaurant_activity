using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public class Masa : IClonable, IComparable, IEnumerable
    {
        private int numar;
        private string locatie;
        private int capacitate;

        public int Numar
        {
            get { return numar; }
            set { numar = value; }
        }

        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public int Capacitate
        {
            get { return capacitate; }
            set { capacitate = value; }
        }

        // Constructor
        public Masa(int numar, string locatie, int capacitate)
        {
            this.numar = numar;
            this.locatie = locatie;
            this.capacitate = capacitate;
        }

        // Implementare interfață ICloneable
        public object Clone()
        {
            return new Masa(numar, locatie, capacitate);
        }

        // Implementare interfață IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Masa otherMasa = obj as Masa;
            if (otherMasa != null)
            {
                return this.capacitate.CompareTo(otherMasa.capacitate);
            }
            else
            {
                throw new ArgumentException("Obiectul nu este de tipul Masa");
            }
        }

        // Operatorul "-" supra.
        public static Masa operator -(Masa masa1, Masa masa2)
        {
            return new Masa(masa1.numar - masa2.numar, "Locație comună", masa1.capacitate + masa2.capacitate);
        }

        private int[,] masivBidimensional = new int[3, 3];

        // Indexer
        public int this[int index1, int index2]
        {
            get { return masivBidimensional[index1, index2]; }
            set { masivBidimensional[index1, index2] = value; }
        }

        // Implementare interfață IEnumerable
        public IEnumerator GetEnumerator()
        {
            return masivBidimensional.GetEnumerator();
        }

        // Salvare obiect în fișier XML
        public void SaveToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Masa));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }

        // Încărcare obiect din fișier XML
        public static Masa LoadFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Masa));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Masa)serializer.Deserialize(reader);
            }
        }

        // Salvare obiect în fișier TXT
        public void SaveToTxt(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Numar: {numar}");
                writer.WriteLine($"Locatie: {locatie}");
                writer.WriteLine($"Capacitate: {capacitate}");
            }
        }

        // Încărcare obiect din fișier TXT
        public static Masa LoadFromTxt(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int numar = 0;
                int capacitate = 0;
                string locatie = "";

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Numar:"))
                    {
                        int.TryParse(line.Split(':')[1].Trim(), out numar);
                    }
                    else if (line.StartsWith("Locatie:"))
                    {
                        locatie = line.Split(':')[1].Trim();
                    }
                    else if (line.StartsWith("Capacitate:"))
                    {
                        int.TryParse(line.Split(':')[1].Trim(), out capacitate);
                    }
                }

                return new Masa(numar, locatie, capacitate);
            }
        }
    }
}
