using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{



    public class Comenzi : IProcesabil
    {
        public event EventHandler EvenimentExemplu;

        private string denumire;
        private int cantitate;

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public Comenzi(string denumire, int cantitate)
        {
            this.denumire = denumire;
            this.cantitate = cantitate;
        }

        public static Comenzi operator ++(Comenzi comanda)
        {
            comanda.cantitate++;
            return comanda;
        }

        public static Comenzi operator --(Comenzi comanda)
        {
            comanda.cantitate--;
            return comanda;
        }

        public void Proceseaza()
        {
            Console.WriteLine("Procesare date pentru Comenzi");
        }
    }


}
