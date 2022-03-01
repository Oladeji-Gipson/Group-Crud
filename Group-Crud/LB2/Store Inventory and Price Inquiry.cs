﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        List<StoreInventory> liInventory = new List<StoreInventory>
        {
            new StoreInventory("Bubble Gum", "3463-1232", "Double Bubble", 3.00, 150.00, 30),
            new StoreInventory("JoyCons", "4756-9243", "Nintendo", 80.00, 1000.00, 120),
            new StoreInventory("Orange Box", "1827-3737", "Valve", 15.00, 400.00, 50),
            new StoreInventory("Lego Colosseum", "1110-9928", "Lego", 500.00, 15000.00, 15),
            new StoreInventory("Coca-Cola", "4747-3328", "Coca-Cola", 4.00, 400.00, 100),
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string searchedName = txtSearchName.Text;

            for (int i = 0; i < liInventory.Count; i++)
            {
                if (liInventory[i].Name.ToLower().Contains(searchedName.ToLower()))
                {
                    lblResultsName.Text = String.Format("Name: {0}", liInventory[i].Name);
                    lblResultsUPC.Text = Convert.ToString(String.Format("UPC: {0}", liInventory[i].UpcCode));
                    lblResultsDistributor.Text = String.Format("Distributor: {0}", liInventory[i].Distributor);
                    lblResultsPrice.Text = Convert.ToString(String.Format("Store Price: {0:C}", liInventory[i].StorePrice));
                    lblResultsCost.Text = Convert.ToString(String.Format("Cost Per Case: {0:C}", liInventory[i].CostPerCase));
                    lblResultsUnits.Text = Convert.ToString(String.Format("Units Per Case: {0:C}", liInventory[i].UnitsPerCase));

                    txtNewPrice.Visible = true;
                    txtPriceAccess.Visible = true;
                    btnUpdate.Visible = true;
                    lblChangeAccessKey.Visible = true;
                    lblChangeStorePrice.Visible = true;
                    lblNewPrice.Visible = true;

                    txtVerifyUPC.Visible = true;
                    txtDeleteAccess.Visible = true;
                    btnDelete.Visible = true;
                    lblDeleteItem.Visible = true;
                    lblVerifyUPC.Visible = true;
                    lblDeleteAccessKey.Visible = true;
                    break;
                }
                else
                {
                    
                }
            }
        }

        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            string searchedCode = txtSearchUPC.Text;

            for (int i = 0; i < liInventory.Count; i++)
            {
                if (liInventory[i].UpcCode.Contains(searchedCode))
                {
                    lblResultsName.Text = String.Format("Name: {0}", liInventory[i].Name);
                    lblResultsUPC.Text = Convert.ToString(String.Format("UPC: {0}", liInventory[i].UpcCode));
                    lblResultsDistributor.Text = String.Format("Distributor: {0}", liInventory[i].Distributor);
                    lblResultsPrice.Text = Convert.ToString(String.Format("Store Price: {0:C}", liInventory[i].StorePrice));
                    lblResultsCost.Text = Convert.ToString(String.Format("Cost Per Case: {0:C}", liInventory[i].CostPerCase));
                    lblResultsUnits.Text = Convert.ToString(String.Format("Units Per Case: {0:C}", liInventory[i].UnitsPerCase));

                    txtNewPrice.Visible = true;
                    txtPriceAccess.Visible = true;
                    btnUpdate.Visible = true;
                    lblChangeAccessKey.Visible = true;
                    lblChangeStorePrice.Visible = true;
                    lblNewPrice.Visible = true;

                    txtVerifyUPC.Visible = true;
                    txtDeleteAccess.Visible = true;
                    btnDelete.Visible = true;
                    lblDeleteItem.Visible = true;
                    lblVerifyUPC.Visible = true;
                    lblDeleteAccessKey.Visible = true;
                    break;
                }
                else
                {

                }
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
