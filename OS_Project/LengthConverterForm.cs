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
    public partial class LengthConverterForm : Form
    {
        public LengthConverterForm()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(input.Text, out double inputValue))
            {
                double meters = inputValue;
                double feet = meters * 3.28084;
                double inches = meters * 39.3701;
                double centimeters = meters * 100;
                double yards = meters * 1.09361;

                lblFeet.Text = $"Feet: {feet:F2}";
                lblInches.Text = $"Inches: {inches:F2}";
                lblCentimeters.Text = $"Centimeters: {centimeters:F1}";
                lblYards.Text = $"Yards: {yards:F2}";
            }
        }
    }
}
