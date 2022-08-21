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
    public partial class Search_Inventorycs : Form
    {
        public Search_Inventorycs()
        {
            InitializeComponent();
        }

        private void inventorySearch_Click(object sender, EventArgs e)
        {
            AddInventory addInventory = new AddInventory();

            string searchProduct = "";
            string searchItem = "";

            productName.Text = searchProduct;
            productNumber.Text = searchItem;

           
        }
    }
}
