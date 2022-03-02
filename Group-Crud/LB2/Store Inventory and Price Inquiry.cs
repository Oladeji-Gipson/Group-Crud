using System;
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

        int accessKey = 1234;

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
                    lblResultsName.ForeColor = Color.Black;
                    lblResultsCost.ForeColor = Color.Black;
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
                    lblResultsName.ForeColor = Color.Red;
                    lblResultsName.Text = "Invalid Product Name";
                }
            }
        }

        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            string searchedCode = txtSearchUPC.Text;

            for (int i = 0; i < liInventory.Count; i++)
            {
                if (liInventory[i].UpcCode == searchedCode)
                {
                    lblResultsName.Text = String.Format("Name: {0}", liInventory[i].Name);
                    lblResultsUPC.Text = Convert.ToString(String.Format("UPC: {0}", liInventory[i].UpcCode));
                    lblResultsDistributor.Text = String.Format("Distributor: {0}", liInventory[i].Distributor);
                    lblResultsPrice.Text = Convert.ToString(String.Format("Store Price: {0:C}", liInventory[i].StorePrice));
                    lblResultsName.ForeColor = Color.Black;
                    lblResultsCost.ForeColor = Color.Black;
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
                    lblResultsCost.ForeColor = Color.Red;
                    lblResultsCost.Text = "Invalid UPC Code";
                }
            }
            }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool foundItem = false;

            for (int i = 0; i < liInventory.Count && foundItem == false; i++)
            {
                
                if (lblResultsName.Text.ToLower().Contains(liInventory[i].Name.ToLower()))
                {
                    foundItem = true;
                    if(accessKey == int.Parse(txtPriceAccess.Text) && txtNewPrice.Text != null)
                    {
                        liInventory[i].StorePrice = double.Parse(txtNewPrice.Text);
                        lblResultsPrice.Text = Convert.ToString(String.Format("Store Price: {0:C}", liInventory[i].StorePrice));
                        txtPriceAccess.Text = String.Empty;
                        txtNewPrice.Text = String.Empty;
                    }
                    else
                    {
                        lblChangeError.Visible = true;
                        txtPriceAccess.Text = String.Empty;
                        txtNewPrice.Text = String.Empty;
                    }
                }  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string verifyCode = txtVerifyUPC.Text;
            int enteredKey = Convert.ToInt32(txtDeleteAccess.Text);

            for (int i = 0; liInventory.Count > 0; i++)
            {
                if (liInventory[i].UpcCode == verifyCode && enteredKey == accessKey)
                {
                    lblDeleteError.Visible = false;
                    txtSearchName.Text = string.Empty;
                    txtSearchUPC.Text = string.Empty;

                    lblResultsName.Text = string.Empty;
                    lblResultsUPC.Text = string.Empty;
                    lblResultsDistributor.Text = string.Empty;
                    lblResultsPrice.Text = string.Empty;
                    lblResultsCost.Text = string.Empty;
                    lblResultsUnits.Text = string.Empty;

                    txtNewPrice.Visible = false;
                    txtPriceAccess.Visible = false;
                    btnUpdate.Visible = false;
                    lblChangeAccessKey.Visible = false;
                    lblChangeStorePrice.Visible = false;
                    lblNewPrice.Visible = false;

                    txtVerifyUPC.Visible = false;
                    txtDeleteAccess.Visible = false;
                    btnDelete.Visible = false;
                    lblDeleteItem.Visible = false;
                    lblVerifyUPC.Visible = false;
                    lblDeleteAccessKey.Visible = false;

                    liInventory.RemoveAt(i);
                    break;
                }
                else
                {
                    lblDeleteError.Visible = true;
                    break;
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(liInventory.Count < 21 && accessKey == int.Parse(txtAddAccess.Text))
            {
                liInventory.Add(new StoreInventory(
                    txtAddName.Text,
                    txtAddUPC.Text,
                    txtAddDistributor.Text,
                    double.Parse(txtAddPrice.Text),
                    double.Parse(txtAddCost.Text),
                    int.Parse(txtAddUnits.Text)
                ));
            }
            txtAddName.Text = String.Empty;
            txtAddUPC.Text = String.Empty;
            txtAddDistributor.Text = String.Empty;
            txtAddPrice.Text = String.Empty;
            txtAddCost.Text = String.Empty;
            txtAddUnits.Text = String.Empty;
            txtAddAccess.Text = String.Empty;
        }
    }
}
