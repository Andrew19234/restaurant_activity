using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
  
        public class Restaurant
        {
            private List<Masa> mese;

            public Restaurant()
            {
                mese = new List<Masa>();
            }

            public List<Masa> Mese
            {
                get { return mese; }
            }

            public void AdaugaMasa(Masa masa)
            {
                mese.Add(masa);
            }

            public void StergeMasa(Masa masa)
            {
                mese.Remove(masa);
            }

            public void AfiseazaMese()
            {
                Console.WriteLine("Mesele disponibile in restaurant:");
                foreach (Masa masa in mese)
                {
                    Console.WriteLine("Numar masa: {0}, Capacitate: {1}", masa.Numar, masa.Capacitate);
                }
            }

            public void PreiaComanda(Masa masa, Comenzi comanda)
            {
                // Procesează comanda pentru masa specificată
                Console.WriteLine("Comanda '{0}' a fost preluată pentru masa cu numărul {1}", comanda.Denumire, masa.Numar);
            }
        }
    }


