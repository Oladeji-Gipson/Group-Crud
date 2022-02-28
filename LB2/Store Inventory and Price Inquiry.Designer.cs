﻿namespace LB2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchUPC = new System.Windows.Forms.TextBox();
            this.btnSearchUPC = new System.Windows.Forms.Button();
            this.lblResultsName = new System.Windows.Forms.Label();
            this.lblResultsUPC = new System.Windows.Forms.Label();
            this.lblResultsPrice = new System.Windows.Forms.Label();
            this.lblResultsCost = new System.Windows.Forms.Label();
            this.lblResultsUnits = new System.Windows.Forms.Label();
            this.lblResultsDistributor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.txtPriceAccess = new System.Windows.Forms.TextBox();
            this.txtVerifyUPC = new System.Windows.Forms.TextBox();
            this.txtDeleteAccess = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAddError = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddUPC = new System.Windows.Forms.TextBox();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddAccess = new System.Windows.Forms.TextBox();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.txtAddUnits = new System.Windows.Forms.TextBox();
            this.txtAddDistributor = new System.Windows.Forms.TextBox();
            this.lblChangeError = new System.Windows.Forms.Label();
            this.lblDeleteError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 31);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 1;
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(138, 27);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by UPC";
            // 
            // txtSearchUPC
            // 
            this.txtSearchUPC.Location = new System.Drawing.Point(298, 31);
            this.txtSearchUPC.Name = "txtSearchUPC";
            this.txtSearchUPC.Size = new System.Drawing.Size(100, 20);
            this.txtSearchUPC.TabIndex = 4;
            // 
            // btnSearchUPC
            // 
            this.btnSearchUPC.Location = new System.Drawing.Point(419, 31);
            this.btnSearchUPC.Name = "btnSearchUPC";
            this.btnSearchUPC.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUPC.TabIndex = 5;
            this.btnSearchUPC.Text = "Search";
            this.btnSearchUPC.UseVisualStyleBackColor = true;
            this.btnSearchUPC.Click += new System.EventHandler(this.btnSearchUPC_Click);
            // 
            // lblResultsName
            // 
            this.lblResultsName.AutoSize = true;
            this.lblResultsName.Location = new System.Drawing.Point(13, 63);
            this.lblResultsName.Name = "lblResultsName";
            this.lblResultsName.Size = new System.Drawing.Size(0, 13);
            this.lblResultsName.TabIndex = 6;
            // 
            // lblResultsUPC
            // 
            this.lblResultsUPC.AutoSize = true;
            this.lblResultsUPC.Location = new System.Drawing.Point(13, 80);
            this.lblResultsUPC.Name = "lblResultsUPC";
            this.lblResultsUPC.Size = new System.Drawing.Size(0, 13);
            this.lblResultsUPC.TabIndex = 7;
            // 
            // lblResultsPrice
            // 
            this.lblResultsPrice.AutoSize = true;
            this.lblResultsPrice.Location = new System.Drawing.Point(12, 98);
            this.lblResultsPrice.Name = "lblResultsPrice";
            this.lblResultsPrice.Size = new System.Drawing.Size(0, 13);
            this.lblResultsPrice.TabIndex = 8;
            // 
            // lblResultsCost
            // 
            this.lblResultsCost.AutoSize = true;
            this.lblResultsCost.Location = new System.Drawing.Point(224, 64);
            this.lblResultsCost.Name = "lblResultsCost";
            this.lblResultsCost.Size = new System.Drawing.Size(0, 13);
            this.lblResultsCost.TabIndex = 9;
            // 
            // lblResultsUnits
            // 
            this.lblResultsUnits.AutoSize = true;
            this.lblResultsUnits.Location = new System.Drawing.Point(224, 81);
            this.lblResultsUnits.Name = "lblResultsUnits";
            this.lblResultsUnits.Size = new System.Drawing.Size(0, 13);
            this.lblResultsUnits.TabIndex = 10;
            // 
            // lblResultsDistributor
            // 
            this.lblResultsDistributor.AutoSize = true;
            this.lblResultsDistributor.Location = new System.Drawing.Point(224, 98);
            this.lblResultsDistributor.Name = "lblResultsDistributor";
            this.lblResultsDistributor.Size = new System.Drawing.Size(0, 13);
            this.lblResultsDistributor.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Change Store Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "New Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "AccessKey";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Delete Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Verify UPC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Access Key";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(74, 176);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(70, 20);
            this.txtNewPrice.TabIndex = 18;
            // 
            // txtPriceAccess
            // 
            this.txtPriceAccess.Location = new System.Drawing.Point(74, 202);
            this.txtPriceAccess.Name = "txtPriceAccess";
            this.txtPriceAccess.Size = new System.Drawing.Size(70, 20);
            this.txtPriceAccess.TabIndex = 19;
            // 
            // txtVerifyUPC
            // 
            this.txtVerifyUPC.Location = new System.Drawing.Point(259, 173);
            this.txtVerifyUPC.Name = "txtVerifyUPC";
            this.txtVerifyUPC.Size = new System.Drawing.Size(111, 20);
            this.txtVerifyUPC.TabIndex = 20;
            // 
            // txtDeleteAccess
            // 
            this.txtDeleteAccess.Location = new System.Drawing.Point(259, 202);
            this.txtDeleteAccess.Name = "txtDeleteAccess";
            this.txtDeleteAccess.Size = new System.Drawing.Size(111, 20);
            this.txtDeleteAccess.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(52, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Price";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Add New Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "UPC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Store Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Access Key";
            // 
            // lblAddError
            // 
            this.lblAddError.AutoSize = true;
            this.lblAddError.Location = new System.Drawing.Point(12, 404);
            this.lblAddError.Name = "lblAddError";
            this.lblAddError.Size = new System.Drawing.Size(0, 13);
            this.lblAddError.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Cost Per Case";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(212, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Units Per Case";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(212, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Distributor";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(215, 376);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 33;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(104, 306);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(70, 20);
            this.txtAddName.TabIndex = 34;
            // 
            // txtAddUPC
            // 
            this.txtAddUPC.Location = new System.Drawing.Point(104, 332);
            this.txtAddUPC.Name = "txtAddUPC";
            this.txtAddUPC.Size = new System.Drawing.Size(70, 20);
            this.txtAddUPC.TabIndex = 35;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(104, 356);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(70, 20);
            this.txtAddPrice.TabIndex = 36;
            // 
            // txtAddAccess
            // 
            this.txtAddAccess.Location = new System.Drawing.Point(104, 381);
            this.txtAddAccess.Name = "txtAddAccess";
            this.txtAddAccess.Size = new System.Drawing.Size(70, 20);
            this.txtAddAccess.TabIndex = 37;
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(304, 306);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(70, 20);
            this.txtAddCost.TabIndex = 38;
            // 
            // txtAddUnits
            // 
            this.txtAddUnits.Location = new System.Drawing.Point(304, 333);
            this.txtAddUnits.Name = "txtAddUnits";
            this.txtAddUnits.Size = new System.Drawing.Size(70, 20);
            this.txtAddUnits.TabIndex = 39;
            // 
            // txtAddDistributor
            // 
            this.txtAddDistributor.Location = new System.Drawing.Point(304, 356);
            this.txtAddDistributor.Name = "txtAddDistributor";
            this.txtAddDistributor.Size = new System.Drawing.Size(70, 20);
            this.txtAddDistributor.TabIndex = 40;
            // 
            // lblChangeError
            // 
            this.lblChangeError.AutoSize = true;
            this.lblChangeError.Location = new System.Drawing.Point(49, 254);
            this.lblChangeError.Name = "lblChangeError";
            this.lblChangeError.Size = new System.Drawing.Size(0, 13);
            this.lblChangeError.TabIndex = 41;
            // 
            // lblDeleteError
            // 
            this.lblDeleteError.AutoSize = true;
            this.lblDeleteError.Location = new System.Drawing.Point(243, 254);
            this.lblDeleteError.Name = "lblDeleteError";
            this.lblDeleteError.Size = new System.Drawing.Size(0, 13);
            this.lblDeleteError.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeleteError);
            this.Controls.Add(this.lblChangeError);
            this.Controls.Add(this.txtAddDistributor);
            this.Controls.Add(this.txtAddUnits);
            this.Controls.Add(this.txtAddCost);
            this.Controls.Add(this.txtAddAccess);
            this.Controls.Add(this.txtAddPrice);
            this.Controls.Add(this.txtAddUPC);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblAddError);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDeleteAccess);
            this.Controls.Add(this.txtVerifyUPC);
            this.Controls.Add(this.txtPriceAccess);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultsDistributor);
            this.Controls.Add(this.lblResultsUnits);
            this.Controls.Add(this.lblResultsCost);
            this.Controls.Add(this.lblResultsPrice);
            this.Controls.Add(this.lblResultsUPC);
            this.Controls.Add(this.lblResultsName);
            this.Controls.Add(this.btnSearchUPC);
            this.Controls.Add(this.txtSearchUPC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Store Inventory & Price Inquiry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchUPC;
        private System.Windows.Forms.Button btnSearchUPC;
        private System.Windows.Forms.Label lblResultsName;
        private System.Windows.Forms.Label lblResultsUPC;
        private System.Windows.Forms.Label lblResultsPrice;
        private System.Windows.Forms.Label lblResultsCost;
        private System.Windows.Forms.Label lblResultsUnits;
        private System.Windows.Forms.Label lblResultsDistributor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.TextBox txtPriceAccess;
        private System.Windows.Forms.TextBox txtVerifyUPC;
        private System.Windows.Forms.TextBox txtDeleteAccess;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAddError;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddUPC;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddAccess;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.TextBox txtAddUnits;
        private System.Windows.Forms.TextBox txtAddDistributor;
        private System.Windows.Forms.Label lblChangeError;
        private System.Windows.Forms.Label lblDeleteError;
    }
}
