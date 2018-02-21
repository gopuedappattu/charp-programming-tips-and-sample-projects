using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleInterestExample
{
    public partial class FormSimpleInterest : Form
    {
        public FormSimpleInterest()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Calculate()
        {
            //Calculates the total by retrieving values from the ctrls
            double dTotal = Convert.ToDouble(textBoxPrincipal.Text) + Convert.ToDouble(textBoxPrincipal.Text) * Convert.ToDouble(textBoxNoOfMonths.Text) * Convert.ToDouble(textBoxInterest.Text) / 100;
            textBoxTotal.Text = dTotal.ToString();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
