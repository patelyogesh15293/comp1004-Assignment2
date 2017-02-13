using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpAutoCenter
{
    
    public partial class SharpAutoForm : Form
    {
        public SharpAutoForm()
        {
            InitializeComponent();
        }
        

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialogBox.ShowDialog();
            AmountDueTextBox.BackColor = ColorDialogBox.Color;
            BasePriceTextBox.BackColor = ColorDialogBox.Color;           
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialogBox.ShowDialog();
            AmountDueTextBox.Font = FontDialogBox.Font;
            BasePriceTextBox.Font = FontDialogBox.Font;
           
        }


        /// <summary>
        /// Handler for show a messagge when use click on about menustrip 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!! It's a small app for calculate total amount for new or old vehicle");
        }

        /// <summary>
        /// Checkbox handler for add additional price to base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handelr for add LeatherInteriro Value to additional text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {  
            
        }

        /// <summary>
        /// computer navigation check box checked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Reste all text box values
            BasePriceTextBox.Text = "";
            AdditionalOptionsTextBox.Text = "";
            SubTotalTextBox.Text = "";
            SalesTaxTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeInAllowanceTextBox.Text = "$0";
            AmountDueTextBox.Text = "";

            //set all checkbox/radiobuttons to defaults
            LeatherInteriorCheckBox.Checked = false;
            StereoSystemCheckBox.Checked = false;
            ComputerNavigationCheckBox.Checked = false;
            StandardRadioButton.Checked = true;

            // Reset color and font properties
            AmountDueTextBox.BackColor = Color.White;
            BasePriceTextBox.BackColor = Color.White;            
        }

        /// <summary>
        /// handler for exit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Event handler for Radio button checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _featureCarPrices();
        }

        /// <summary>
        /// Radio button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _featureCarPrices();
        }

        /// <summary>
        /// Radio button event handler for add customized car price in base price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CustomizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _featureCarPrices();
        }
        
        /// <summary>
        /// private method for get value for base car price
        /// </summary>

        private void _featureCarPrices()
        {
            double _standardCarPrice = 0;
            double _pearlizedCarPrice = 560.80;
            double _customizedCarPrice = 1012.23;
            
            // If condition for set value when deefault
            if (StandardRadioButton.Checked)
            {
                AdditionalOptionsTextBox.Text = _standardCarPrice.ToString("C2");
            }
            //when pearlized radio button checked 
            else if (PearlizedRadioButton.Checked)
            {
                AdditionalOptionsTextBox.Text = _pearlizedCarPrice.ToString("C2");
            }
            //when customized radio button checked
            else if (CustomizedDetailingRadioButton.Checked)
            {
                AdditionalOptionsTextBox.Text = _customizedCarPrice.ToString("C2");
            }
            else StandardRadioButton.Select();
        }

    }
}