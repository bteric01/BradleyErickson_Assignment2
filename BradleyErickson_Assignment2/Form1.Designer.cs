namespace BradleyErickson_Assignment2
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
            this.tabOne = new System.Windows.Forms.TabControl();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.txtSaleQuantity = new System.Windows.Forms.TextBox();
            this.cboSelectTShirt = new System.Windows.Forms.ComboBox();
            this.btnExecuteSale = new System.Windows.Forms.Button();
            this.lblSaleAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExecuteOrder = new System.Windows.Forms.Button();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.cboTShirtType = new System.Windows.Forms.ComboBox();
            this.lblOrderCost = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.lblSmallInventory = new System.Windows.Forms.Label();
            this.lblMediumInventory = new System.Windows.Forms.Label();
            this.lblLargeInventory = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.tabOne.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOne
            // 
            this.tabOne.Controls.Add(this.tabSell);
            this.tabOne.Controls.Add(this.tabPage2);
            this.tabOne.Location = new System.Drawing.Point(24, 27);
            this.tabOne.Name = "tabOne";
            this.tabOne.SelectedIndex = 0;
            this.tabOne.Size = new System.Drawing.Size(236, 298);
            this.tabOne.TabIndex = 0;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.txtSaleQuantity);
            this.tabSell.Controls.Add(this.cboSelectTShirt);
            this.tabSell.Controls.Add(this.btnExecuteSale);
            this.tabSell.Controls.Add(this.lblSaleAmount);
            this.tabSell.Controls.Add(this.label1);
            this.tabSell.Controls.Add(this.label2);
            this.tabSell.Controls.Add(this.label3);
            this.tabSell.Location = new System.Drawing.Point(4, 22);
            this.tabSell.Name = "tabSell";
            this.tabSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabSell.Size = new System.Drawing.Size(228, 272);
            this.tabSell.TabIndex = 0;
            this.tabSell.Text = "Sell T-Shirts";
            this.tabSell.UseVisualStyleBackColor = true;
            // 
            // txtSaleQuantity
            // 
            this.txtSaleQuantity.Location = new System.Drawing.Point(23, 121);
            this.txtSaleQuantity.Name = "txtSaleQuantity";
            this.txtSaleQuantity.Size = new System.Drawing.Size(124, 20);
            this.txtSaleQuantity.TabIndex = 7;
            // 
            // cboSelectTShirt
            // 
            this.cboSelectTShirt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboSelectTShirt.FormattingEnabled = true;
            this.cboSelectTShirt.Items.AddRange(new object[] {
            "Red T-Shirt (S)      $18.99",
            "Red T-Shirt (M)    $19.99",
            "Red T-Shirt (L)      $20.99"});
            this.cboSelectTShirt.Location = new System.Drawing.Point(23, 45);
            this.cboSelectTShirt.Name = "cboSelectTShirt";
            this.cboSelectTShirt.Size = new System.Drawing.Size(161, 21);
            this.cboSelectTShirt.TabIndex = 6;
            // 
            // btnExecuteSale
            // 
            this.btnExecuteSale.Location = new System.Drawing.Point(23, 235);
            this.btnExecuteSale.Name = "btnExecuteSale";
            this.btnExecuteSale.Size = new System.Drawing.Size(117, 25);
            this.btnExecuteSale.TabIndex = 5;
            this.btnExecuteSale.Text = "Execute Sale";
            this.btnExecuteSale.UseVisualStyleBackColor = true;
            this.btnExecuteSale.Click += new System.EventHandler(this.btnExecuteSale_Click);
            // 
            // lblSaleAmount
            // 
            this.lblSaleAmount.BackColor = System.Drawing.Color.LightGray;
            this.lblSaleAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaleAmount.Location = new System.Drawing.Point(23, 192);
            this.lblSaleAmount.Name = "lblSaleAmount";
            this.lblSaleAmount.Size = new System.Drawing.Size(129, 21);
            this.lblSaleAmount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a T-Shirt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sale quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sale amount:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExecuteOrder);
            this.tabPage2.Controls.Add(this.txtOrderQuantity);
            this.tabPage2.Controls.Add(this.cboTShirtType);
            this.tabPage2.Controls.Add(this.lblOrderCost);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(228, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order T-Shirts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExecuteOrder
            // 
            this.btnExecuteOrder.Location = new System.Drawing.Point(23, 234);
            this.btnExecuteOrder.Name = "btnExecuteOrder";
            this.btnExecuteOrder.Size = new System.Drawing.Size(113, 26);
            this.btnExecuteOrder.TabIndex = 6;
            this.btnExecuteOrder.Text = "Execute Order";
            this.btnExecuteOrder.UseVisualStyleBackColor = true;
            this.btnExecuteOrder.Click += new System.EventHandler(this.btnExecuteOrder_Click);
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(23, 118);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(137, 20);
            this.txtOrderQuantity.TabIndex = 5;
            // 
            // cboTShirtType
            // 
            this.cboTShirtType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboTShirtType.FormattingEnabled = true;
            this.cboTShirtType.Items.AddRange(new object[] {
            "Red T-Shirt (S)      $15.99",
            "Red T-Shirt (M)     $16.99",
            "Red T-Shirt (L)      $17.99"});
            this.cboTShirtType.Location = new System.Drawing.Point(23, 42);
            this.cboTShirtType.Name = "cboTShirtType";
            this.cboTShirtType.Size = new System.Drawing.Size(161, 21);
            this.cboTShirtType.TabIndex = 4;
            // 
            // lblOrderCost
            // 
            this.lblOrderCost.BackColor = System.Drawing.Color.LightGray;
            this.lblOrderCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderCost.Location = new System.Drawing.Point(23, 194);
            this.lblOrderCost.Name = "lblOrderCost";
            this.lblOrderCost.Size = new System.Drawing.Size(138, 22);
            this.lblOrderCost.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Order Cost:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Order quantity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Select T-Shirt Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Red T-Shirt (S)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Red T-Shirt (M)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Red T-Shirt (L)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total cash:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Inventory";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "T-Shirt";
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Location = new System.Drawing.Point(51, 331);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(161, 29);
            this.btnNewTransaction.TabIndex = 10;
            this.btnNewTransaction.Text = "New Transaction";
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // lblSmallInventory
            // 
            this.lblSmallInventory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSmallInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmallInventory.Location = new System.Drawing.Point(380, 75);
            this.lblSmallInventory.Name = "lblSmallInventory";
            this.lblSmallInventory.Size = new System.Drawing.Size(92, 18);
            this.lblSmallInventory.TabIndex = 11;
            // 
            // lblMediumInventory
            // 
            this.lblMediumInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMediumInventory.Location = new System.Drawing.Point(380, 115);
            this.lblMediumInventory.Name = "lblMediumInventory";
            this.lblMediumInventory.Size = new System.Drawing.Size(92, 21);
            this.lblMediumInventory.TabIndex = 12;
            // 
            // lblLargeInventory
            // 
            this.lblLargeInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargeInventory.Location = new System.Drawing.Point(380, 154);
            this.lblLargeInventory.Name = "lblLargeInventory";
            this.lblLargeInventory.Size = new System.Drawing.Size(92, 21);
            this.lblLargeInventory.TabIndex = 13;
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCash.Location = new System.Drawing.Point(380, 296);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(92, 25);
            this.lblTotalCash.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 369);
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.lblLargeInventory);
            this.Controls.Add(this.lblMediumInventory);
            this.Controls.Add(this.lblSmallInventory);
            this.Controls.Add(this.btnNewTransaction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabOne.ResumeLayout(false);
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOne;
        private System.Windows.Forms.TabPage tabSell;
        private System.Windows.Forms.TextBox txtSaleQuantity;
        private System.Windows.Forms.ComboBox cboSelectTShirt;
        private System.Windows.Forms.Button btnExecuteSale;
        private System.Windows.Forms.Label lblSaleAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNewTransaction;
        private System.Windows.Forms.Label lblSmallInventory;
        private System.Windows.Forms.Label lblMediumInventory;
        private System.Windows.Forms.Label lblLargeInventory;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblOrderCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnExecuteOrder;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.ComboBox cboTShirtType;
    }
}

