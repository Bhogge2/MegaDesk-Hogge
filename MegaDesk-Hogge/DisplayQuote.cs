using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hogge
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();

        }

        private void btnCloseDisplayQuote_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
