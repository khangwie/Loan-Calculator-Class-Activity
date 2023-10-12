using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mortgage_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
           
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            
             if (!string.IsNullOrEmpty(txtLoanAmount.Text)) 
               loanAmount= Convert.ToDouble(txtLoanAmount.Text);
            
                if (!string.IsNullOrEmpty(txtDownPayment.Text))
                 downPayment= Convert.ToDouble(txtDownPayment.Text);
            
                if (!string .IsNullOrEmpty(txtInterestRate.Text))
                interestRate= Convert.ToDouble(txtInterestRate.Text);
            
              if  (!string.IsNullOrEmpty(txtTermsInYears.Text))
                terms = Convert.ToInt32(txtTermsInYears.Text);

            int TermsInMonths = terms * 12;
            monthlyPayment = (loanAmount - downPayment) * (Math.Pow((1
            + interestRate / 12), TermsInMonths) * interestRate) / (12 * (Math.Pow((1
            + interestRate / 12), TermsInMonths) - 1));
            monthlyPayment = Math.Round(monthlyPayment, 2);

         lblMonthlyPayment.Text = string.Format("Monthly Payment:R{0}", monthlyPayment.ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double downPayment = 0.0;
            double interestRate = 0.0;
            double monthlyPayment = 0.0;
            int terms = 0;

            if (!String.IsNullOrEmpty(txtLoanAmount.Text))
            loanAmount = Convert.ToDouble(txtLoanAmount.Text);

            if (!string.IsNullOrEmpty(txtDownPayment.Text))
                downPayment= Convert.ToDouble(txtDownPayment.Text);

            if (!string.IsNullOrEmpty(txtInterestRate.Text))
                interestRate= Convert.ToDouble(txtInterestRate.Text);

            if (!string.IsNullOrEmpty(txtTermsInYears.Text))
                terms = Convert.ToInt32(txtTermsInYears.Text);


            int termsinMonths = terms * 12;
            interestRate /= 12;
              monthlyPayment =(interestRate*loanAmount)/(1 - Math.Pow(1
                  + interestRate, termsinMonths* - 1));

            monthlyPayment = Math.Round(monthlyPayment, 2);

            lblMonthlyPayment.Text=string.Format("Monthly Payment: R {0}", monthlyPayment.ToString());



        }
    }
}
