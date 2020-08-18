﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormHomepage : Form
    {
        //adaugam variabila
        FormAbout formAbout;
        FormCalculator formCalculator;

        //constructor
        public FormHomepage()
        {
            InitializeComponent();
            formAbout = new FormAbout();
            formCalculator = new FormCalculator();
            formAbout.Visible = false;
            formCalculator.Visible = false;        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCalculatorForm_Click(object sender, EventArgs e)
        {
            if (formCalculator.Visible == true)
                formCalculator.Visible = false;
            else
                formCalculator.Visible = true;
        }

        //legam primul form (de homepage) de al doilea form(FormAbout.cs)
        private void ButtonAboutForm_Click(object sender, EventArgs e)
        {
            //Codul functioneaza de genul: 
            //se initializeaza formul de homepage, ne pregatim si formul 2 (de about), 
            //ii spunem ca nu e vizibil, iar de fiecare data cand apasam butonul de about, 
            //il facem vizibil sau nu in functie de statusul curent (daca e vizibil, 
            //il inchidem, daca e invizibil il redeschidem)
            if (formAbout.Visible == true)
                formAbout.Visible = false;
            else
                formAbout.Visible = true;
        }
    }
}
