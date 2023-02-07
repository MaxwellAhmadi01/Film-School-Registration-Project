using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmadi_4
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // Handles the click event for the form's Close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form, returning executional control to the original form*
        }
    }
}
