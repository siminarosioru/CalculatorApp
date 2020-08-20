using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormCalculator : Form
    {
        //constructor
        public FormCalculator()
        {
            InitializeComponent();
        }

        //definirea functiei pentru adunare
        private void butonAdunare_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 + termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();
        }

        //definirea functiei pentru scadere
        private void butonScadere_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 - termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();
        }

        //definirea functiei pentru inmultire
        private void butonInmultire_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 * termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();
        }

        //definirea functiei pentru impartire
        private void butonImpartire_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            try
            {
                //declararea variabilei locale + calcul
                decimal rezultat = termen1 / termen2;
                //afisarea rezultatului
                textBoxRezultat.Text = rezultat.ToString();
            }
            catch
            {
                string message = "do not divide by 0";
                string title = "divide by 0";
                //afisarea + fixarea exceptiei
                MessageBox.Show(message, title);
            }
        }
    }
}
