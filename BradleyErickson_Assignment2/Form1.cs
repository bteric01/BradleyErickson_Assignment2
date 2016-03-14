using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Assignment 2: This application will allow you to order and sell t-shirts
 * Author: Bradley Erickson
 * created: 2/19/2014
 */
namespace BradleyErickson_Assignment2
{
    public partial class Form1 : Form  
    {   
            const int TSHIRTS = 50;
            const int TSHIRTM = 50;
            const int TSHIRTL = 50;
            const double TOTALCASH = 50000.00;

            int sTshirtInv;
            int mTshirtInv;
            int lTshirtInv;
            double totalCash;
    
        private bool ExceedsInventorySold(int index, int saleQuantity)
        {
            bool inventorySoldExceeded=false;

            switch (index)
            {
                case 0:
                    if(saleQuantity>sTshirtInv)
                    {
                        inventorySoldExceeded = true;
                    }
                    break;
                case 1:
                    if(saleQuantity>mTshirtInv)
                    {   
                        inventorySoldExceeded = true;
                    }
                    break;
                case 2:
                    if(saleQuantity>lTshirtInv)
                    {
                        inventorySoldExceeded = true;
                    }
                    break;
            }
                return inventorySoldExceeded;
        }

        private bool ExceedsInventoryOrdered(int index, int orderQuantity)
        {
            bool inventoryOrderedExceeded = false;

            switch (index)
            {
                case 0:
                    if ((orderQuantity + sTshirtInv) > 50)
                    {
                        inventoryOrderedExceeded = true;
                    }
                    break;
                case 1:
                    if ((orderQuantity + mTshirtInv) > 50)
                    {
                        inventoryOrderedExceeded = true;
                    }
                    break;
                case 2:
                    if ((orderQuantity + lTshirtInv) > 50)
                    {
                        inventoryOrderedExceeded = true;
                    }
                    break;
            }
                return inventoryOrderedExceeded;
        }

    
        public Form1()
        {
            InitializeComponent();
            totalCash = TOTALCASH;
            sTshirtInv = TSHIRTS;
            mTshirtInv = TSHIRTM;
            lTshirtInv = TSHIRTL;
            lblSmallInventory.Text = TSHIRTS.ToString();
            lblMediumInventory.Text = TSHIRTM.ToString();
            lblLargeInventory.Text = TSHIRTL.ToString();
            lblTotalCash.Text = TOTALCASH.ToString("c");
        }

        private double GetTShirtPrice(int index)
        {
            double tShirtPrice = 0;

            const int REDTSHIRTS_INDEX = 0;
            const int REDTSHIRTM_INDEX = 1;
            const int REDTSHIRTL_INDEX = 2;

            const double REDTSHIRTS_PRICE = 18.99;
            const double REDTSHIRTM_PRICE = 19.99;
            const double REDTSHIRTL_PRICE = 20.99;


            switch (index)
            {
                case REDTSHIRTS_INDEX:
                    tShirtPrice = REDTSHIRTS_PRICE;
                    break;
                case REDTSHIRTM_INDEX:
                    tShirtPrice = REDTSHIRTM_PRICE;
                    break;
                case REDTSHIRTL_INDEX:
                    tShirtPrice = REDTSHIRTL_PRICE;
                    break;
            }

            return tShirtPrice;
        }

        private double GetOrderPrice(int index)
        {
            double orderPrice = 0;

            const int REDTSHIRTS_INDEX = 0;
            const int REDTSHIRTM_INDEX = 1;
            const int REDTSHIRTL_INDEX = 2;

            const double REDTSHIRTS_PRICE = 15.99;
            const double REDTSHIRTM_PRICE = 16.99;
            const double REDTSHIRTL_PRICE = 17.99;


            switch (index)
            {
                case REDTSHIRTS_INDEX:
                    orderPrice = REDTSHIRTS_PRICE;
                    break;
                case REDTSHIRTM_INDEX:
                    orderPrice = REDTSHIRTM_PRICE;
                    break;
                case REDTSHIRTL_INDEX:
                    orderPrice = REDTSHIRTL_PRICE;
                    break;
            }

            return orderPrice;
        }

        private void UpdateInventory(int index, int quantity)
        {
            const int REDTSHIRTS_INDEX = 0;
            const int REDTSHIRTM_INDEX = 1;
            const int REDTSHIRTL_INDEX = 2;


            switch (index)
            {
                case REDTSHIRTS_INDEX:
                    sTshirtInv -= quantity;
                    break;
                case REDTSHIRTM_INDEX:
                    mTshirtInv -= quantity;
                    break;
                case REDTSHIRTL_INDEX:
                    lTshirtInv -= quantity;
                    break;
            }
            lblSmallInventory.Text = sTshirtInv.ToString();
            lblMediumInventory.Text = mTshirtInv.ToString();
            lblLargeInventory.Text = lTshirtInv.ToString();
        }

        private void UpdateOrderInventory(int index, int quantity)
        {
            const int REDTSHIRTS_INDEX = 0;
            const int REDTSHIRTM_INDEX = 1;
            const int REDTSHIRTL_INDEX = 2;


            switch (index)
            {
                case REDTSHIRTS_INDEX:
                    sTshirtInv += quantity;
                    break;
                case REDTSHIRTM_INDEX:
                    mTshirtInv += quantity;
                    break;
                case REDTSHIRTL_INDEX:
                    lTshirtInv += quantity;
                    break;
            }
            lblSmallInventory.Text = sTshirtInv.ToString();
            lblMediumInventory.Text = mTshirtInv.ToString();
            lblLargeInventory.Text = lTshirtInv.ToString();
        }

        private void btnExecuteSale_Click(object sender, EventArgs e)
        {
            int saleQuantity;
            double saleAmount;

            
            saleQuantity = int.Parse(txtSaleQuantity.Text);
            saleAmount = (GetTShirtPrice(cboSelectTShirt.SelectedIndex) * saleQuantity);
            totalCash+= saleAmount;

            
            if (cboSelectTShirt.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select a T-Shirt", "Missing Selection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (ExceedsInventorySold(cboSelectTShirt.SelectedIndex, saleQuantity) == true)
            {
                MessageBox.Show("You cannot exceed the amount of t-shirts in the inventory!", "Inventory Exceeded Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSaleQuantity.Focus();
            }
            else
            {
                lblSaleAmount.Text = saleAmount.ToString("c");
                lblTotalCash.Text = totalCash.ToString("c");
                UpdateInventory(cboSelectTShirt.SelectedIndex, saleQuantity);
            }

               
        }

        private void btnExecuteOrder_Click(object sender, EventArgs e)
        {
            int orderQuantity;
            double orderCost;

            orderQuantity = int.Parse(txtOrderQuantity.Text);
            orderCost = (GetOrderPrice(cboTShirtType.SelectedIndex) * orderQuantity);
            totalCash -= orderCost;


            if (cboTShirtType.SelectedIndex == -1)
            {
                MessageBox.Show("You must first select a T-Shirt", "Missing Selection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (ExceedsInventoryOrdered(cboTShirtType.SelectedIndex, orderQuantity) == true)
            {
                MessageBox.Show("You cannot order more shirts than the set inventory of 50!", "Inventory Exceeded Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtOrderQuantity.Focus();
            }
            else
            {
                lblOrderCost.Text = orderCost.ToString("c");
                lblTotalCash.Text = totalCash.ToString("c");
                UpdateOrderInventory(cboTShirtType.SelectedIndex, orderQuantity);
            }
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            txtOrderQuantity.Clear();
            txtSaleQuantity.Clear();

            lblOrderCost.Text = "";
            lblSaleAmount.Text = "";

            cboTShirtType.Text = "";
            cboSelectTShirt.Text = "";

            tabOne.SelectedIndex = 0;
        }
    }
}
