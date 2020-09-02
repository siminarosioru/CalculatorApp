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
            decimal termen1 = Convert.ToDecimal(numericUpDownTermen1.Text);
            decimal termen2 = Convert.ToDecimal(numericUpDownTermen2.Text);

            //creare obiect(= e instantierea clasei(= e schita obiectului))
            CalculatorHelper obiectCalculatorHelper = new CalculatorHelper(termen1, termen2);

            //afisarea informatiei
            MessageBox.Show("Termen 1: " + obiectCalculatorHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalculatorHelper.getTermen2() + Environment.NewLine
                + "Calcul adunare: " + obiectCalculatorHelper.calculAdunare());
        }

        //definirea functiei pentru scadere
        private void butonScadere_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = Convert.ToDecimal(numericUpDownTermen1.Text);
            decimal termen2 = Convert.ToDecimal(numericUpDownTermen2.Text);

            //creare obiect(= e instantierea clasei(= e schita obiectului))
            CalculatorHelper obiectCalculatorHelper = new CalculatorHelper(termen1, termen2);

            //afisarea informatiei
            MessageBox.Show("Termen 1: " + obiectCalculatorHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalculatorHelper.getTermen2() + Environment.NewLine
                + "Calcul scadere: " + obiectCalculatorHelper.calculScadere());
        }

        //definirea functiei pentru inmultire
        private void butonInmultire_Click(object sender, EventArgs e)
        {
            //declararea variabilei locale + initializare
            decimal termen1 = Convert.ToDecimal(numericUpDownTermen1.Text);
            decimal termen2 = Convert.ToDecimal(numericUpDownTermen2.Text);

            //creare obiect(= e instantierea clasei(= e schita obiectului))
            CalculatorHelper obiectCalculatorHelper = new CalculatorHelper(termen1, termen2);

            //afisarea informatiei
            MessageBox.Show("Termen 1: " + obiectCalculatorHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalculatorHelper.getTermen2() + Environment.NewLine
                + "Calcul inmultire: " + obiectCalculatorHelper.calculInmultire());
        }

        //definirea functiei pentru impartire
        private void butonImpartire_Click(object sender, EventArgs e)
        {
            decimal termen1 = Convert.ToDecimal(numericUpDownTermen1.Text);
            decimal termen2 = Convert.ToDecimal(numericUpDownTermen2.Text);

            //cream obiectul(= instantierea unei clase(= schita unui obiect))
            CalculatorHelper obiectCalcHelper = new CalculatorHelper(termen1, termen2);

            if (termen2 != 0)
            {
                MessageBox.Show("Termen 1: " + obiectCalcHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalcHelper.getTermen2() + Environment.NewLine
                + "Rezultat impartire: " + obiectCalcHelper.calculImpartire());
            }
            else
            {
                MessageBox.Show("Termen 1: " + obiectCalcHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalcHelper.getTermen2() + Environment.NewLine
                + "Error, do not divide by 0");
            }
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
        }
    }
}
