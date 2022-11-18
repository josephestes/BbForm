using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Program by Joseph Estes
 * This program is a windows form for a Bed and Breakfast.
 * 
 * User selects the a room and the program displays another window with the descrption and price.
 * Also on the main form is a breakfast option button which opens another window that contains
 * radiobuttons for each food choice and displays the selected choices price.
 * 
 */

namespace Joseph.Estes.Ch12.You.Do.It
{
    public partial class JosephsForm : Form
    {
        public JosephsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Open the castleGatehouseForm when its checkbox is ticked and uncheck the box when the window is closed
        private void CastleGatehouseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (castleGatehouseCheckBox.Checked)
            {
                CastleGatehouseForm castleGatehouseForm = new CastleGatehouseForm();
                castleGatehouseForm.ShowDialog();
                castleGatehouseCheckBox.Checked = false;
            }
        }

        //Open the hallHouseForm when its checkbox is ticked and uncheck the box when the window is closed
        private void HallHouseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hallHouseCheckBox.Checked)
            {
                HallHouseForm hallHouseForm = new HallHouseForm();
                hallHouseForm.ShowDialog();
                hallHouseCheckBox.Checked = false;
            }
        }

        //Open the BreakfastOptionForm when its button is clicked
        private void MealButton_Click(object sender, EventArgs e)
        {
            BreakfastOptionForm breakfastForm = new
                BreakfastOptionForm();
            breakfastForm.ShowDialog();
        }
    }
}
