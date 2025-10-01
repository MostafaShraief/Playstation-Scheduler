using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playstation_Scheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double val;
            if (double.TryParse(textBox1.Text, out val))
            {
                ucStopwatch1.feePerHour = ucStopwatch2.feePerHour =
                    ucStopwatch3.feePerHour = ucStopwatch4.feePerHour = val;
            }
        }
    }
}
