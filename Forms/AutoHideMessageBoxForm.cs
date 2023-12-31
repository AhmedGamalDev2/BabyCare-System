using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarAlArqamForm.Forms
{
    public partial class AutoHideMessageBoxForm : Form
    {
        private Timer timer;
        public AutoHideMessageBoxForm(string message, int displayTimeMilliseconds)
        {
            InitializeComponent();

            labelMessage.Text = message;

            // Set up the timer
            timer = new Timer();
            timer.Interval = displayTimeMilliseconds;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Close the form when the timer ticks
            Close();
        }
        private void AutoHideMessageBoxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
