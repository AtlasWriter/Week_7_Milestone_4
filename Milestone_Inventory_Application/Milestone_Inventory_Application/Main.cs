using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Inventory_Application
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Link add inventory form to main
        public void button1_Click(object sender, EventArgs e)
        {
            AddInventory addInventory2 = new AddInventory();

            addInventory2.ShowDialog();

        }

        private void searchInventory_Click(object sender, EventArgs e)
        {
            AddInventory searchInventory = new AddInventory();
            searchInventory.ShowDialog();
        }
    }
}
