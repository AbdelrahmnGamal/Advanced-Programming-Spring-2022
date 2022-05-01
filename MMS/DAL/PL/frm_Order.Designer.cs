namespace MMS.PL
{
    partial class frm_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Order));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIDproduct = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSumTotals = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnPrint);
            this.groupControl3.Controls.Add(this.btnClear);
            this.groupControl3.Controls.Add(this.btn_Save);
            this.groupControl3.Location = new System.Drawing.Point(10, 527);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(905, 72);
            this.groupControl3.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(715, 23);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(146, 45);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "print order";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(31, 23);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(213, 45);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "New Order";
            this.btnClear.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.Location = new System.Drawing.Point(359, 23);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(230, 45);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save Order";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_customer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtOrder);
            this.groupBox1.Controls.Add(this.txtOrderID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSalesMan);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 202);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Info";
            // 
            // cmb_customer
            // 
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(169, 147);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(202, 23);
            this.cmb_customer.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Customer_Name";
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(169, 75);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(200, 22);
            this.dtOrder.TabIndex = 1;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderID.Location = new System.Drawing.Point(257, 38);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(112, 22);
            this.txtOrderID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Order_Id";
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesMan.Location = new System.Drawing.Point(169, 115);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(200, 22);
            this.txtSalesMan.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Employee_Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtIDproduct);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtAmount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNameProduct);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtSumTotals);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.dgvProducts);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 256);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Products";
            // 
            // txtIDproduct
            // 
            this.txtIDproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDproduct.Location = new System.Drawing.Point(709, 47);
            this.txtIDproduct.Multiline = true;
            this.txtIDproduct.Name = "txtIDproduct";
            this.txtIDproduct.ReadOnly = true;
            this.txtIDproduct.Size = new System.Drawing.Size(83, 23);
            this.txtIDproduct.TabIndex = 1;
            this.txtIDproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(791, 17);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(100, 31);
            this.label18.TabIndex = 24;
            this.label18.Text = "Choose Item";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAmount.Location = new System.Drawing.Point(56, 47);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(112, 23);
            this.txtTotalAmount.TabIndex = 7;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(56, 17);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(112, 31);
            this.label17.TabIndex = 22;
            this.label17.Text = "Total Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(167, 47);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(78, 23);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(166, 17);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(79, 31);
            this.label15.TabIndex = 20;
            this.label15.Text = "Discount";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(243, 47);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(85, 23);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(242, 17);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(86, 31);
            this.label16.TabIndex = 18;
            this.label16.Text = "QuantityPrice";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(327, 47);
            this.txtQty.MaxLength = 8;
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(96, 23);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(323, 17);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(100, 31);
            this.label14.TabIndex = 16;
            this.label14.Text = "Quantity";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(422, 47);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(86, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyDown);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(418, 17);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(90, 31);
            this.label13.TabIndex = 14;
            this.label13.Text = "Price";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameProduct.Location = new System.Drawing.Point(506, 47);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.ReadOnly = true;
            this.txtNameProduct.Size = new System.Drawing.Size(204, 23);
            this.txtNameProduct.TabIndex = 2;
            this.txtNameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(505, 17);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(205, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "Product_Name";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(709, 17);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "product_id";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSumTotals
            // 
            this.txtSumTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumTotals.Location = new System.Drawing.Point(132, 217);
            this.txtSumTotals.Name = "txtSumTotals";
            this.txtSumTotals.ReadOnly = true;
            this.txtSumTotals.Size = new System.Drawing.Size(142, 22);
            this.txtSumTotals.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total_Price";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageKey = "cancel.png";
            this.btnDelete.Location = new System.Drawing.Point(763, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersVisible = false;
            this.dgvProducts.Location = new System.Drawing.Point(56, 76);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(836, 126);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvProducts_RowsAdded);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(791, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 27);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(718, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add New Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupControl3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Order";
            this.Load += new System.EventHandler(this.frm_Order_Load);
            this.TextChanged += new System.EventHandler(this.frm_Order_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSumTotals;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button button1;
    }
}