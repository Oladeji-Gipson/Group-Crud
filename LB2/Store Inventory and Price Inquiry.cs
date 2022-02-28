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
        public Form1()
        {
            InitializeComponent();
        }

        List<StoreInventory> storeInventories = new List<StoreInventory>();
        int intialSets = 0;
        int position = 0;
        string accessKey = "1234";

        private void SetIntialValues()
        {
            if (intialSets == 0)
            {
                intialSets = 1;
                storeInventories.Add(new StoreInventory());
                storeInventories.Add(new StoreInventory());
                storeInventories.Add(new StoreInventory());
                storeInventories.Add(new StoreInventory());
                storeInventories.Add(new StoreInventory());
                storeInventories[0].SetStoreInventory("Bottle Rocket", "1234-5678", 15.00m, 100.00m, 50, "Black Cat", storeInventories.LastIndexOf(storeInventories[0]));
                storeInventories[1].SetStoreInventory("Ender Pearl", "1111-1111", 100.00m, 500.00m, 16, "Enderman", storeInventories.LastIndexOf(storeInventories[1]));
                storeInventories[2].SetStoreInventory("Wall", "2222-2222", 10000000m, 1000000m, 1, "Tonald Drump", storeInventories.LastIndexOf(storeInventories[2]));
                storeInventories[3].SetStoreInventory("Mk-1 Suit", "3333-3333", 20000m, 1000m, 20, "Tony Stark", storeInventories.LastIndexOf(storeInventories[3]));
                storeInventories[4].SetStoreInventory("Dragon Ball", "4444-4444", 100000m, 10000m, 7, "Shenron", storeInventories.LastIndexOf(storeInventories[4]));
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string userInput = txtSearchName.Text;
            SetIntialValues();
            for (int i = 0; i < storeInventories.Count; i++)
            {
                if(storeInventories[i].GetName().ToLower().Contains(userInput.ToLower()))
                {
                    lblDeleteError.Text = "";
                    lblChangeError.Text = "";
                    lblResultsName.Text = "Name: " + storeInventories[i].GetName();
                    lblResultsUPC.Text = "UPC: " + storeInventories[i].GetUpc();
                    lblResultsPrice.Text = "Store Price: " + String.Format("{0:C}", storeInventories[i].GetPrice());
                    lblResultsCost.Text = "Cost Per Case: " + String.Format("{0:C}", storeInventories[i].GetCost());
                    lblResultsUnits.Text = "Units Per Case: " + Convert.ToString(storeInventories[i].GetUnits());
                    lblResultsDistributor.Text = "Distributor: " + storeInventories[i].GetDistributor();
                    position = storeInventories[i].GetPosition();
                    break;
                }
                else
                {
                    lblDeleteError.Text = "";
                    lblChangeError.Text = "";
                    lblResultsName.Text = "Item Not Found!";
                    lblResultsUPC.Text = "Item Not Found!";
                    lblResultsPrice.Text = "Item Not Found!";
                    lblResultsCost.Text = "Item Not Found!";
                    lblResultsUnits.Text = "Item Not Found!";
                    lblResultsDistributor.Text = "Item Not Found!";
                }
            }
        }

        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            string userInput = txtSearchUPC.Text;
            SetIntialValues();
            for (int i = 0; i < storeInventories.Count; i++)
            {
                if (userInput == storeInventories[i].GetUpc())
                {
                    lblDeleteError.Text = "";
                    lblChangeError.Text = "";
                    lblResultsName.Text = "Name: " + storeInventories[i].GetName();
                    lblResultsUPC.Text = "UPC: " + storeInventories[i].GetUpc();
                    lblResultsPrice.Text = "Store Price: " + String.Format("{0:C}", storeInventories[i].GetPrice());
                    lblResultsCost.Text = "Cost Per Case: " + String.Format("{0:C}", storeInventories[i].GetCost());
                    lblResultsUnits.Text = "Units Per Case: " + Convert.ToString(storeInventories[i].GetUnits());
                    lblResultsDistributor.Text = "Distributor: " + storeInventories[i].GetDistributor();
                    position = storeInventories[i].GetPosition();
                    break;
                }
                else
                {
                    lblDeleteError.Text = "";
                    lblChangeError.Text = "";
                    lblResultsName.Text = "Item Not Found!";
                    lblResultsUPC.Text = "Item Not Found!";
                    lblResultsPrice.Text = "Item Not Found!";
                    lblResultsCost.Text = "Item Not Found!";
                    lblResultsUnits.Text = "Item Not Found!";
                    lblResultsDistributor.Text = "Item Not Found!";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SetIntialValues();
            string userInput = txtPriceAccess.Text;
            decimal newPrice = Convert.ToDecimal(txtNewPrice.Text);
            if(userInput == accessKey)
            {
                for (int i = 0; i < storeInventories.Count; i++)
                {
                    if(position == storeInventories[i].GetPosition())
                    {
                        txtPriceAccess.Text = "";
                        txtNewPrice.Text = "";
                        lblChangeError.Text = "Price Updated!";
                        storeInventories[i].SetNewPrice(newPrice);
                        lblResultsPrice.Text = "Store Price: " + String.Format("{0:C}", storeInventories[i].GetPrice());
                        break;
                    }
                }
            }
            else
            {
                lblChangeError.Text = "Access Key Incorrect";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userInput = txtVerifyUPC.Text;
            string accessKeyInput = txtDeleteAccess.Text;
            if (accessKeyInput == accessKey)
            {
                for (int i = 0; i < storeInventories.Count; i++)
                {
                    if (userInput == storeInventories[i].GetUpc())
                    {
                        txtVerifyUPC.Text = "";
                        txtDeleteAccess.Text = "";
                        lblDeleteError.Text = "Item Deleted";
                        storeInventories.RemoveAt(i);
                        break;
                    }
                    else
                    {
                        lblDeleteError.Text = "Access Key Incorrect";
                    }
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SetIntialValues();
            string userNewName = txtAddName.Text;
            string userNewUPC = txtAddUPC.Text;
            decimal userNewPrice = Convert.ToDecimal(txtAddPrice.Text);
            decimal userNewCost = Convert.ToDecimal(txtAddCost.Text);
            int userNewUnits = Convert.ToInt32(txtAddUnits.Text);
            string userNewDistributor = txtAddDistributor.Text;
            string accessInput = txtAddAccess.Text;
            if (accessInput == accessKey)
            {
                if (storeInventories.Count < 20)
                {
                    for (int i = storeInventories.Count - 1; i < storeInventories.Count; i++)
                    {
                        storeInventories.Add(new StoreInventory());
                        storeInventories[i].SetStoreInventory(userNewName, userNewUPC, userNewPrice, userNewCost,
                            userNewUnits, userNewDistributor, storeInventories.Count);
                        txtAddName.Text = "";
                        txtAddUPC.Text = "";
                        txtAddPrice.Text = "";
                        txtAddCost.Text = "";
                        txtAddUnits.Text = "";
                        txtAddDistributor.Text = "";
                        txtAddAccess.Text = "";
                        break;
                    }
                }
            }
            else
            {
                lblAddError.Text = "Access Key Incorrect";
            }
        }
    }
}
