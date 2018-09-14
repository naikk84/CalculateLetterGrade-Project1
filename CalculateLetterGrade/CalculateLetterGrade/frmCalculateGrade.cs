using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }
        /* this program helps us convert the number grade to a letter grade.*/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal NumberGrade = Convert.ToDecimal(txtNumberGrade.Text); //to get the number grade user enters.
            string lettergrade = ""; // String that holds lettergrade.
            
            /* condition that defines the conversion of number grade to letter grade*/
           if (NumberGrade > 100)
            {
                MessageBox.Show("Enter number between 0 to 100");
            }
            else if (NumberGrade >= 88 && NumberGrade <= 100)
            {
                lettergrade = "A";
            }

           else if(NumberGrade >=80 && NumberGrade <= 87)
            {
                lettergrade = "B";
            }
           else if(NumberGrade >= 68 && NumberGrade <=79)
            {
                lettergrade = "C";
            }
           else if(NumberGrade >= 60 && NumberGrade <=67)
            {
                lettergrade = "D";
            }
            else
            {
                lettergrade = "F";
            }
            txtLetterGrade.Text = lettergrade; //to display letter grade in letter grade text box.
            txtNumberGrade.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //to exit the application.
        }
    }
}
