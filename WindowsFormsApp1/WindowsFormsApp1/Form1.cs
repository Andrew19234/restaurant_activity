using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Restaurant restaurant;

        public Form1()
        {
            InitializeComponent();
            restaurant = new Restaurant();
        }

        private void btnAdaugaMasa_Click(object sender, EventArgs e)
        {
            int numarMasa = int.Parse(txtNumarMasa.Text);
            string locatieMasa = txtLocatieMasa.Text;
            int capacitateMasa = int.Parse(txtCapacitateMasa.Text);

            Masa masa = new Masa(numarMasa, locatieMasa, capacitateMasa);
            restaurant.AdaugaMasa(masa);

            lstMese.Items.Add(masa);
        }

        private void btnStergeMasa_Click(object sender, EventArgs e)
        {
            if (lstMese.SelectedItem != null)
            {
                Masa masa = (Masa)lstMese.SelectedItem;
                restaurant.StergeMasa(masa);
                lstMese.Items.Remove(masa);
            }
        }

        private void btnAfiseazaMese_Click(object sender, EventArgs e)
        {
            lstMese.Items.Clear();
            foreach (Masa masa in restaurant.Mese)
            {
                lstMese.Items.Add(masa);
            }
        }
    }
}
