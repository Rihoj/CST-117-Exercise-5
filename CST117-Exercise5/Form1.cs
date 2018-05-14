using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST117_Exercise5
{
    public partial class calcPiForm : Form
    {
        public calcPiForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int terms;
            bool result = Int32.TryParse(termsTextBox.Text, out terms);
            if (result)
            {
                decimal pi = 0;
                decimal denominator = 1;
                for(int i = 1; i <= terms; i++)
                {
                    if(i % 2 != 0)
                    {
                        pi = pi + (4 / denominator);
                    }else
                    {
                        pi = pi - (4 / denominator);
                    }
                    denominator += 2;
                }
                resultTitleLabel.Text = "Approximate value of PI after " + terms + " terms";
                resultLabel.Text = "= " + pi;
            }
            else
            {
                MessageBox.Show("Please enter an integer.", "Terms Error");
            }
        }
    }
}
