using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Joseph.Estes.Ch12.You.Do.It
{
    public partial class BreakfastOptionForm : Form
    {
        private const double CONT_BREAKFAST_PRICE = 7.99;
        private const double FULL_BREAKFAST_PRICE = 10.99;
        private const double DELUXE_BREAKFAST_PRICE = 17.99;
        public BreakfastOptionForm()
        {
            InitializeComponent();
        }

        //Display the price for the continental breakfast as default
        private void BreakfastOptionForm_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + 
                CONT_BREAKFAST_PRICE.ToString("C");
        }

        //Display the price for the continental breakfast when selected
        private void contRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
                CONT_BREAKFAST_PRICE.ToString("C");
        }

        //Display the price for the full breakfast when selected
        private void fullRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
                FULL_BREAKFAST_PRICE.ToString("C");
        }

        //Display the price for the deluxe breakfast when selected
        private void deluxeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " +
                DELUXE_BREAKFAST_PRICE.ToString("C");
        }
    }
}
