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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote()
        {
            InitializeComponent();

            List<Desk.DesktopMaterial> DesktopMaterial =
                Enum.GetValues(typeof(Desk.DesktopMaterial))
                .Cast<Desk.DesktopMaterial>()
                .ToList();

            cbMaterialType.DataSource = DesktopMaterial;

            cbMaterialType.SelectedIndex = -1;


            List<DeskQuote.Delivery> delivery =
                Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();

            cbDelivery.DataSource = delivery;
            cbDelivery.SelectedIndex = -1;
        }

        private void btnCloseAddQuote_Click(object sender, EventArgs e)
        {
            ((Form)this.Tag).Show();
            Close();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            var displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
