/*********************************************************************************************************
 * ProgramL: travelExpensesByCar
 * Programmer: Danny Jackson
 * Purpose: Calculate travel expenses by car.
 * Description: Enter gas price, select kind of car, select city or freeway, and total travel expenses by
 * car will be calculated when you press the calc button. Press Quit to exit application.
 * Date: November 10, 2017
 * ******************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelExpensesByCar
{
    public partial class Form1 : Form
    {
        // Constants
        const int CITY_DRIVING_DISTANCE = 21;
        const int FREEWAY_DRIVING_DISTANCE = 33;
        const float BUICK_FREEWAY_MPG = 23.7F;
        const float BUICK_CITY_MPG = 15.5F;
        const float CHEVY_FREEWAY_MPG = 29.3F;
        const float CHEVY_CITY_MPG = 19.8F;
        const float DEFAULT_GAS_PRICE = 1.09F;
        const string DEFAULT_TOTAL = "$1.48";

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        // Initialize all variables on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMileage.Text = BUICK_CITY_MPG.ToString();
            lblTotalMiles.Text = CITY_DRIVING_DISTANCE.ToString();
            rdoCity.Checked = true;
            txtBxGasPrice.Text = DEFAULT_GAS_PRICE.ToString();
            lblTotalCost.Text = "answer";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // Calculate travel expenses
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Am I supposed to use TryParse here? I don't see where there could be an error
            try
            {

                float mpg = float.Parse(lblMileage.Text);
                float drivingDistance = float.Parse(lblTotalMiles.Text);
                float gasPrice = float.Parse(txtBxGasPrice.Text);

                lblTotalCost.Text = ((float)drivingDistance / (float)mpg * (float)gasPrice).ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rdoBuick_CheckedChanged(object sender, EventArgs e)
        {
            // City checked
            if (rdoCity.Checked)
            {
                lblMileage.Text = BUICK_CITY_MPG.ToString();
                lblTotalMiles.Text = CITY_DRIVING_DISTANCE.ToString();
            }
            // Freeway checked
            else if (rdoFreeway.Checked)
            {
                lblMileage.Text = BUICK_FREEWAY_MPG.ToString();
                lblTotalMiles.Text = FREEWAY_DRIVING_DISTANCE.ToString();
            }
        }

        private void rdoChevy_CheckedChanged(object sender, EventArgs e)
        {
            // City checked
            if (rdoCity.Checked)
            {
                lblMileage.Text = CHEVY_FREEWAY_MPG.ToString();
                lblTotalMiles.Text = CITY_DRIVING_DISTANCE.ToString();
            }
            // Freeway checked
            else if (rdoFreeway.Checked)
            {
                lblMileage.Text = CHEVY_CITY_MPG.ToString();
                lblTotalMiles.Text = FREEWAY_DRIVING_DISTANCE.ToString();
            }
        }

        private void rdoFreeway_CheckedChanged(object sender, EventArgs e)
        {
            // Set freeway driving distance
            lblTotalMiles.Text = FREEWAY_DRIVING_DISTANCE.ToString();
        }

        private void rdoCity_CheckedChanged(object sender, EventArgs e)
        {
            // Set city driving distance
            lblTotalMiles.Text = CITY_DRIVING_DISTANCE.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close(); // Close the application
        }

        private void txtBxGasPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBxGasPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            int pointCount = 0;

            // Check if KeyChar is anything but numeric or decimal point
            if (!char.IsControl(e.KeyChar))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    if (e.KeyChar != '.') // It's not a dot
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if (txtBxGasPrice.Text.IndexOf(".") != -1) // Make sure dot is only allowed once
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
    }
}
