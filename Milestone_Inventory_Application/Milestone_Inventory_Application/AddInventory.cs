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
    public partial class AddInventory : Form

    {
        // Create an List to store inventory.
        List<AddInventory> InventoryList = new List<AddInventory>();

      
        // Constructor 
        public AddInventory()
        {
            InitializeComponent();

        }
        // Fields for the Inventorys items and details:
        // ProductName Property
        public new string ProductName { get; set; } = "";
        // ProductDescription Property
        public string ProductDescription { get; set; } = "";
        // QuanityOnHand Property
        public double QuanityOnHand { get; set; } = 0;
        // CostOfGoods Property
        public double CostOfGoods { get; set; } = 0.0;
        // Profit Property
        public double Profit { get; set; } = 0.0;
        // SalePrice Property
        public decimal SalePrice { get; set; } = 0;
        // TotalSalesOfProduct Property
        public double TotalSalesOfProduct { get; set; } = 0.0;
        // ProductNumberFromSupplier Property
        public int ProductNumberFromSupplier { get; set; } = 0;
        // SupplierName Property
        public string SupplierName { get; set; } = "";
        // SupplierCountry Property
        public string SupplierCountry { get; set; } = "";
        // SupplierPhoneContact Property
        public double SupplierPhoneContact { get; set; } = 0;
        // PlatformListed Property
        public string PlatformListed { get; set; } = "";
        // Tag Property
        public string Tag { get; set; } = "";
        // ProductNumber Property
        public int ProductNumber { get; set; } = 0;

        // Method on getItemDetails with List
        public void getItemDetals(AddInventory inventorys)
        {
            // Store data varables for parse data:
            int ProductNumber;
            double quanity;
            double itemCostOverhead;
            double positiveRevenue;
            decimal soldPrice;
            double msrp;
            int supplierIDNumber;
            double supplierTelephone;

            // If statement for try/parse to convert string to num.
                if (int.TryParse(productNumber.Text, out ProductNumber)){ }
                else {MessageBox.Show("Please Enter the correct values: Product Number"); }
                if(double.TryParse(quanityOnHand.Text, out quanity)) { }
                else { MessageBox.Show("Please Enter the correct values: Quanity"); }
                if(double.TryParse(costOfGoods.Text, out itemCostOverhead)) { }
                else { MessageBox.Show("Please Enter the correct values: Cost of Goods"); }
                if (double.TryParse(profit.Text, out positiveRevenue)) { }
                else { MessageBox.Show("Please Enter the correct values: Profit"); }
                if (decimal.TryParse(salePrice.Text, out soldPrice)) { }
                else { MessageBox.Show("Please Enter the correct values: Sell Price"); }
                if (double.TryParse(totalSalesOfProduct.Text, out msrp)) { }
                else { MessageBox.Show("Please Enter the correct values: Total Sales of Product"); }
                if (int.TryParse(productNumberFromSupplier.Text, out supplierIDNumber)) { }
                else { MessageBox.Show("Please Enter the correct values: Product Number From of Supplier"); }
                if (double.TryParse(supplierPhoneContact.Text, out supplierTelephone)) { }
                else { MessageBox.Show("Please Enter the correct values: Supplier Phone Contact"); }

                // Asign new varable names and sending to list after data conversion
                inventorys.ProductNumber = ProductNumber;
                inventorys.ProductName = productName.Text;
                inventorys.ProductDescription = productDescription.Text;
                inventorys.QuanityOnHand = quanity;
                inventorys.CostOfGoods = itemCostOverhead;
                inventorys.Profit = positiveRevenue;
                inventorys.SalePrice = soldPrice;
                inventorys.TotalSalesOfProduct = msrp;
                inventorys.ProductNumberFromSupplier = supplierIDNumber;
                inventorys.SupplierCountry = supplierCountry.Text;
                inventorys.SupplierName = supplierName.Text;
                inventorys.SupplierPhoneContact = supplierTelephone;
                inventorys.PlatformListed = platformListed.Text;
                inventorys.Tag = tag.Text;

        }

        // Reference
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void search_Click_1(object sender, EventArgs e)
        {

            AddInventory inventory = new AddInventory();
            // Send method to new object with data fields
            getItemDetals(inventory);
            // Add inventory to list
            InventoryList.Add(inventory);


            string selection = "";
            searchProductName.Text = selection;

           if(selection != null)
            {
                InventoryList.Contains(inventory);
                MessageBox.Show("Item is in Inventory");
               
            }
            else
            {
                MessageBox.Show("Item is not in Inventory");
            }
          

                     

        }
        // Add to Inventory button, submit data fields to list
        private void button3_Click_1(object sender, EventArgs e)
        {

            //Create a new list object
            AddInventory inventory = new AddInventory();
            // Send method to new object with data fields
            getItemDetals(inventory);
            // Add inventory to list
            InventoryList.Add(inventory);

            // List Box display order assignment and items:
            currentInventory.Items.Add("Product Number: " + inventory.ProductNumber + " | " + "Product Description: " +
                inventory.ProductDescription + " | " + "Product Name: " + inventory.ProductName + " | " + "Quanity: " +
                inventory.QuanityOnHand + " | " + "Cost of Goods: " + inventory.CostOfGoods + " | " + "Profit: " +
                inventory.Profit + " | " + "Sale of Price: " + inventory.SalePrice + " | " + "Total Sales of Product: " +
                inventory.TotalSalesOfProduct + " | " + "Product Number From Supplier: " + inventory.ProductNumberFromSupplier
                + " | " + "Supplier Name: " + inventory.SupplierCountry + " | " + "Supplier Phone Contact: " +
                inventory.SupplierPhoneContact + " | " + "Platfrom Listed: " + inventory.PlatformListed + " | " + "Tag: " +
                inventory.Tag);

            // Current Inventory Counts displayed
            if (currentInventory.Items.Count == 0)
            {
                label16.Text = "There are no Items In Inventory";
            }
            else
            {
                double totalNumberOfItemsInInventory = currentInventory.Items.Count;
                label16.Text = "There are " + totalNumberOfItemsInInventory.ToString() + " Items in Inventory";
            }
        }
    
    
        //Clear Fields/ Enter new item
        private void clearFields_Click_1(object sender, EventArgs e)
        {
           
            
                productNumber.Text = "";

                quanityOnHand.Text = "";

                costOfGoods.Text = "";

                profit.Text = "";

                salePrice.Text = "";

                totalSalesOfProduct.Text = "";

                productNumberFromSupplier.Text = "";

                supplierPhoneContact.Text = "";

                productDescription.Text = "";

                supplierName.Text = "";

                platformListed.Text = "";

                supplierCountry.Text = "";

                productName.Text = "";

                tag.Text = "";

                productName.Focus();

            }
        // Delete button and statement to remore at OnClick event or combined with a button click.
        private void deleteItem_Click_1(object sender, EventArgs e)
        {
            {
                currentInventory.Items.RemoveAt(currentInventory.SelectedIndex);
            }
        }

        private void restock_Click_1(object sender, EventArgs e)
        {
            {
                AddInventory inventory = new AddInventory();
                // Send method to new object with data fields
                getItemDetals(inventory);
                // Add inventory to list
                InventoryList.Add(inventory);

                // List Box display order assignment and items:
                currentInventory.Items.Add("Product Number: " + inventory.ProductNumber + " | " + "Product Description: " +
                    inventory.ProductDescription + " | " + "Product Name: " + inventory.ProductName + " | " + "Quanity: " +
                    inventory.QuanityOnHand + " | " + "Cost of Goods: " + inventory.CostOfGoods + " | " + "Profit: " +
                    inventory.Profit + " | " + "Sale of Price: " + inventory.SalePrice + " | " + "Total Sales of Product: " +
                    inventory.TotalSalesOfProduct + " | " + "Product Number From Supplier: " + inventory.ProductNumberFromSupplier
                    + " | " + "Supplier Name: " + inventory.SupplierCountry + " | " + "Supplier Phone Contact: " +
                    inventory.SupplierPhoneContact + " | " + "Platfrom Listed: " + inventory.PlatformListed + " | " + "Tag: " +
                    inventory.Tag);

            }
        }
    }
  }
    

