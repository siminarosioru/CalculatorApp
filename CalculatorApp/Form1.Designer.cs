namespace CalculatorApp
{
    partial class FormHomepage
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
            System.Windows.Forms.Button ButtonAboutForm;
            this.ButtonCalculatorForm = new System.Windows.Forms.Button();
            ButtonAboutForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCalculatorForm
            // 
            this.ButtonCalculatorForm.Location = new System.Drawing.Point(154, 82);
            this.ButtonCalculatorForm.Name = "ButtonCalculatorForm";
            this.ButtonCalculatorForm.Size = new System.Drawing.Size(154, 87);
            this.ButtonCalculatorForm.TabIndex = 8;
            this.ButtonCalculatorForm.Text = "Calculator";
            this.ButtonCalculatorForm.UseVisualStyleBackColor = true;
            this.ButtonCalculatorForm.Click += new System.EventHandler(this.ButtonCalculatorForm_Click);
            // 
            // ButtonAboutForm
            // 
            ButtonAboutForm.Location = new System.Drawing.Point(142, 223);
            ButtonAboutForm.Name = "ButtonAboutForm";
            ButtonAboutForm.Size = new System.Drawing.Size(166, 89);
            ButtonAboutForm.TabIndex = 9;
            ButtonAboutForm.Text = "About";
            ButtonAboutForm.UseVisualStyleBackColor = true;
            ButtonAboutForm.Click += new System.EventHandler(this.ButtonAboutForm_Click);
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 373);
            this.Controls.Add(ButtonAboutForm);
            this.Controls.Add(this.ButtonCalculatorForm);
            this.Name = "FormHomepage";
            this.Text = "Homepage ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonCalculatorForm;
    }
}

