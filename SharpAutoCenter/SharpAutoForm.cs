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
            // Declare some variables
            double _stereoCheckedValue;
            double _holdValue;
            double _stereoSystemValue = 450;

            // If conditions for check StereoSystemCheckBox is checked or not
            if (StereoSystemCheckBox.Checked == true)
            {
                // Another If condition for check AdditionalTextBox value for adding the value
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _stereoSystemValue.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _stereoCheckedValue = _stereoSystemValue + _holdValue;
                    AdditionalOptionsTextBox.Text = _stereoCheckedValue.ToString("C2");
                }
            }

            // result for when user unchecked textbox 
            else
            {
                _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                _stereoCheckedValue = _holdValue - _stereoSystemValue;
                AdditionalOptionsTextBox.Text = _stereoCheckedValue.ToString("C2");
            }
        }

        /// <summary>
        /// Handelr for add LeatherInteriro Value to additional text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Declare some variables
            double _leatherInteriorCheckedValue;
            double _holdValue;
            double _leatherInteriorValue = 980.54;

            // If conditions for check LeatherInteriroCheckBox is checked or not
            if (LeatherInteriorCheckBox.Checked == true)
            {
                // Another If condition for check AdditionalTextBox value for adding the value
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _leatherInteriorValue.ToString("C2");
                }

                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _leatherInteriorCheckedValue = _leatherInteriorValue + _holdValue;
                    AdditionalOptionsTextBox.Text = _leatherInteriorCheckedValue.ToString("C2");
                }
            }

            // result for when user unchecked textbox 
            else
            {
                _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                _leatherInteriorCheckedValue = _holdValue - _leatherInteriorValue;
                AdditionalOptionsTextBox.Text = _leatherInteriorCheckedValue.ToString("C2");
            }
        }

        /// <summary>
        /// computer navigation check box checked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Declare some variables
            double _navigationCheckedValue;
            double _holdValue;
            double _navigationValue = 980.54;

            // If conditions for check ComputerNavigationCheckBox is checked or not
            if (ComputerNavigationCheckBox.Checked == true)
            {
                // Another If condition for check AdditionalTextBox value for adding the value
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _navigationValue.ToString("C2");
                }

                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _navigationCheckedValue = _navigationValue + _holdValue;
                    AdditionalOptionsTextBox.Text = _navigationCheckedValue.ToString("C2");
                }
            }

            // result for when user unchecked textbox 
            else
            {
                _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                _navigationCheckedValue = _holdValue - _navigationValue;
                AdditionalOptionsTextBox.Text = _navigationCheckedValue.ToString("C2");
            }
        }

        /// <summary>
        /// Private method for calculate all additional and base value  
        /// </summary>
       
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
            double _holdValue;
            double _standardAddedValue;
            double _custAddedValue;
            double _pearAddedValue;
            double _standardCarPrice = 0;
            double _pearlizedCarPrice = 560.80;
            double _customizedCarPrice = 1012.23;
            
            // If condition for set value when deefault
            if (StandardRadioButton.Checked == true)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _standardCarPrice.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _standardAddedValue = _standardCarPrice + _holdValue;
                    AdditionalOptionsTextBox.Text = _standardAddedValue.ToString("C2");
                }
                else
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _standardAddedValue = _holdValue - _standardCarPrice;
                    AdditionalOptionsTextBox.Text = _standardAddedValue.ToString("C2");
                }
                
            }
            //when pearlized radio button checked 
            else if (PearlizedRadioButton.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _pearlizedCarPrice.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _pearAddedValue = _standardCarPrice + _holdValue;
                    AdditionalOptionsTextBox.Text = _pearAddedValue.ToString("C2");
                }
                else
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _pearAddedValue = _holdValue - _standardCarPrice;
                    AdditionalOptionsTextBox.Text = _pearAddedValue.ToString("C2");
                }
            }
            //when customized radio button checked
            else if (CustomizedDetailingRadioButton.Checked)
            {

                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = _customizedCarPrice.ToString("C2");
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _custAddedValue = _standardCarPrice + _holdValue;
                    AdditionalOptionsTextBox.Text = _custAddedValue.ToString("C2");
                }
                else
                {
                    _holdValue = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    _custAddedValue = _holdValue - _standardCarPrice;
                    AdditionalOptionsTextBox.Text = _custAddedValue.ToString("C2");
                }
            }
            else StandardRadioButton.Select();
        }

        /// <summary>
        /// Calculate button handler for gives total and sales tax
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculateButton_Click(object sender, EventArgs e)
        {
              
        }

        /// <summary>
        /// private method for validate enter number is correct or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool _numberPositive(String value)
        {
            double _value = 0.0;
            if (Double.TryParse(value, out _value))
            {
                if (_value >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}