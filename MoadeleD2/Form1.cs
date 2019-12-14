using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoadeleD2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void TxtboxInput_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }
        private void BtnCalculation_Click(object sender, EventArgs e)
        {

            Between btw = new Between();
            double A = 0;
            double B = 0;
            double C = 0;
            double Result1=0;
            double Result2=0;
            int n;

            string XX = txtboxInput.Text;
            string aa = XX.Substring(0, 1);
            if (aa == "-")
            {
                A = Convert.ToDouble(XX.Substring(0, 2));
                n = 10;
            }
            else
            {
                A = Convert.ToDouble(aa);
                n = 9;
            }


            B = Convert.ToDouble(btw.BetweenStrings(XX, "*x^2", "*x"));
            C = Convert.ToDouble(btw.BetweenStrings(XX, XX.Substring(0, n), "=0"));

            if ((Math.Pow(B, 2) - (4 * A * C)) > 0) 
            {
                Result1 = (Math.Pow((Math.Pow(B, 2) - (4 * A * C)), 1 / 2) - B) / (2 * A);
                Result2 = (-Math.Pow((Math.Pow(B, 2) - (4 * A * C)), 1 / 2) - B) / (2 * A);
                lblResult.Text = $"Result1 = {Result1.ToString()}\nResult2 = {Result2.ToString()}";
            }
            if ((Math.Pow(B, 2) - (4 * A * C)) == 0)
            {
                Result1 = (Math.Pow((Math.Pow(B, 2) - (4 * A * C)), 1 / 2) - B) / (2 * A);
                lblResult.Text = $"Result = {Result1.ToString()}";
            }
            if ((Math.Pow(B, 2) - (4 * A * C)) < 0)
            {
                lblResult.Text = "No Result!";
            }
        }

    }
}
