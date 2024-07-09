using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Exemplu de utilizare a metodelor SaveToXml și SaveToTxt pentru obiectul Masa
            Masa masa = new Masa(1, "Locație 1", 4);

            // Salvare în fișier XML
            string xmlFilePath = "Masa1.xml";
            masa.SaveToXml(xmlFilePath);

            // Salvare în fișier text
            string txtFilePath = "Masa1.txt";
            masa.SaveToTxt(txtFilePath);
        }
    }
}
