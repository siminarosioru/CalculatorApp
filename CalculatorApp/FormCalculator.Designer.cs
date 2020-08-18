namespace CalculatorApp
{
    partial class FormCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCalculator = new System.Windows.Forms.Label();
            this.numericUpDownTermen1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTermen2 = new System.Windows.Forms.NumericUpDown();
            this.butonAdunare = new System.Windows.Forms.Button();
            this.butonScadere = new System.Windows.Forms.Button();
            this.butonInmultire = new System.Windows.Forms.Button();
            this.butonImpartire = new System.Windows.Forms.Button();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCalculator
            // 
            this.labelCalculator.AutoSize = true;
            this.labelCalculator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCalculator.Location = new System.Drawing.Point(67, 24);
            this.labelCalculator.Name = "labelCalculator";
            this.labelCalculator.Size = new System.Drawing.Size(512, 40);
            this.labelCalculator.TabIndex = 1;
            this.labelCalculator.Text = "afisarea informatiilor pentru utilizator: \r\nactivarea butonului Calculator e in m" +
    "omentul in care utilizatorul  il  apasa\r\n";
            // 
            // numericUpDownTermen1
            // 
            this.numericUpDownTermen1.Location = new System.Drawing.Point(126, 152);
            this.numericUpDownTermen1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen1.Name = "numericUpDownTermen1";
            this.numericUpDownTermen1.Size = new System.Drawing.Size(162, 26);
            this.numericUpDownTermen1.TabIndex = 2;
            // 
            // numericUpDownTermen2
            // 
            this.numericUpDownTermen2.Location = new System.Drawing.Point(405, 152);
            this.numericUpDownTermen2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTermen2.Name = "numericUpDownTermen2";
            this.numericUpDownTermen2.Size = new System.Drawing.Size(162, 26);
            this.numericUpDownTermen2.TabIndex = 3;
            // 
            // butonAdunare
            // 
            this.butonAdunare.Location = new System.Drawing.Point(53, 281);
            this.butonAdunare.Name = "butonAdunare";
            this.butonAdunare.Size = new System.Drawing.Size(150, 45);
            this.butonAdunare.TabIndex = 4;
            this.butonAdunare.Text = "adunare";
            this.butonAdunare.UseVisualStyleBackColor = true;
            this.butonAdunare.Click += new System.EventHandler(this.butonAdunare_Click);
            // 
            // butonScadere
            // 
            this.butonScadere.Location = new System.Drawing.Point(243, 281);
            this.butonScadere.Name = "butonScadere";
            this.butonScadere.Size = new System.Drawing.Size(150, 45);
            this.butonScadere.TabIndex = 5;
            this.butonScadere.Text = "scadere";
            this.butonScadere.UseVisualStyleBackColor = true;
            this.butonScadere.Click += new System.EventHandler(this.butonScadere_Click);
            // 
            // butonInmultire
            // 
            this.butonInmultire.Location = new System.Drawing.Point(417, 281);
            this.butonInmultire.Name = "butonInmultire";
            this.butonInmultire.Size = new System.Drawing.Size(150, 45);
            this.butonInmultire.TabIndex = 6;
            this.butonInmultire.Text = "inmultire";
            this.butonInmultire.UseVisualStyleBackColor = true;
            this.butonInmultire.Click += new System.EventHandler(this.butonInmultire_Click);
            // 
            // butonImpartire
            // 
            this.butonImpartire.Location = new System.Drawing.Point(601, 281);
            this.butonImpartire.Name = "butonImpartire";
            this.butonImpartire.Size = new System.Drawing.Size(150, 45);
            this.butonImpartire.TabIndex = 7;
            this.butonImpartire.Text = "impartire";
            this.butonImpartire.UseVisualStyleBackColor = true;
            this.butonImpartire.Click += new System.EventHandler(this.butonImpartire_Click);
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Enabled = false;
            this.textBoxRezultat.Location = new System.Drawing.Point(281, 397);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(243, 26);
            this.textBoxRezultat.TabIndex = 8;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.butonImpartire);
            this.Controls.Add(this.butonInmultire);
            this.Controls.Add(this.butonScadere);
            this.Controls.Add(this.butonAdunare);
            this.Controls.Add(this.numericUpDownTermen2);
            this.Controls.Add(this.numericUpDownTermen1);
            this.Controls.Add(this.labelCalculator);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTermen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalculator;
        private System.Windows.Forms.NumericUpDown numericUpDownTermen1;
        private System.Windows.Forms.NumericUpDown numericUpDownTermen2;
        private System.Windows.Forms.Button butonAdunare;
        private System.Windows.Forms.Button butonScadere;
        private System.Windows.Forms.Button butonInmultire;
        private System.Windows.Forms.Button butonImpartire;
        private System.Windows.Forms.TextBox textBoxRezultat;
    }
}