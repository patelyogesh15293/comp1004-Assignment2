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
            
        }

        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!! It's a small app for calculate total amount for new or old vehicle");
        }
    }
}
