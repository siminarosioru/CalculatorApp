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
            /*//declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 + termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();*/

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
            /*//declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 - termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();*/

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
            /*//declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;

            //declararea variabilei locale + calcul
            decimal rezultat = termen1 * termen2;
            //afisarea rezultatului
            textBoxRezultat.Text = rezultat.ToString();*/

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
            /*//declararea variabilei locale + initializare
            decimal termen1 = numericUpDownTermen1.Value;
            decimal termen2 = numericUpDownTermen2.Value;*/

            ////declararea variabilei locale + calcul
            //decimal rezultat = termen1 / termen2;
            ////afisarea rezultatului
            //textBoxRezultat.Text = rezultat.ToString();

            /* termen1 / 0 = eroare
             * pentru ca impartirea la 0 nu are sens,
             * in mod normal noi ar trebui sa ne gandim astfel:
             * 0(termen2) * ? = termen1 => eroare
             * dar 0(termen1) / termen2 = corect
             */
            /*//varianta if...else
            if (termen2 == 0)
            {
                string message = "do not divide by 0";
                string title = "divide by 0";
                //afisarea + fixarea exceptiei
                MessageBox.Show(message, title);
                //MessageBox.Show(message);
            }
            else
            {
                //declararea variabilei locale + calcul
                decimal rezultat = termen1 / termen2;
                //afisarea rezultatului
                textBoxRezultat.Text = rezultat.ToString();
            }*/
            //sau varianta try ... catch
            /* Exception e , e un fel de "root" (mama tuturor exceptiilor). 
             * Se pot face mai multe catch-uri, cu diferite nivele de exceptie 
             * (de la unul specific la cel mai larg)
             * se poate face de genul try { .... } catch (DivideByZeroException e)
             * {...} catch (Exception e)
             */
            //try
            //{
            //    //declararea variabilei locale + calcul
            //    decimal rezultat = termen1 / termen2;
            //    //afisarea rezultatului
            //    textBoxRezultat.Text = rezultat.ToString();
            //}
            //catch
            //{
            //    string message = "do not divide by 0";
            //    string title = "divide by 0";
            //    //afisarea + fixarea exceptiei
            //    MessageBox.Show(message, title);
            //    //fixarea exceptiei
            //    //MessageBox.Show(message);
            //}

            //declararea variabilei locale + initializare
            decimal termen1 = Convert.ToDecimal(numericUpDownTermen1.Text);
            decimal termen2 = Convert.ToDecimal(numericUpDownTermen2.Text);

            //creare obiect(= e instantierea clasei(= e schita obiectului))
            CalculatorHelper obiectCalculatorHelper = new CalculatorHelper(termen1, termen2);

            //afisarea informatiei
            MessageBox.Show("Termen 1: " + obiectCalculatorHelper.getTermen1() + Environment.NewLine
                + "Termen 2: " + obiectCalculatorHelper.getTermen2() + Environment.NewLine
                + "Calcul impartire: " + obiectCalculatorHelper.calculImpartire());
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
