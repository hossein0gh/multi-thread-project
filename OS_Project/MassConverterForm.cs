using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Project
{
    public partial class MassConverterForm : Form
    {
        public MassConverterForm()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double inputValue))
            {
                // Perform mass conversions
                double kilograms = inputValue;
                double pounds = kilograms * 2.20462;
                double ounces = kilograms * 35.274;
                double grams = kilograms * 1000;

                // Display the results
                lblPounds.Text = $"Pounds: {pounds:F2}";
                lblOunces.Text = $"Ounces: {ounces:F2}";
                lblGrams.Text = $"Grams: {grams:F1}";
            }
        }
    }
}
