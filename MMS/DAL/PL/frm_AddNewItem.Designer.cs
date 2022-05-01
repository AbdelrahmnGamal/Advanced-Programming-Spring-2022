namespace MMS.PL
{
    partial class frm_AddNewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewItem));
            this.txt_quantity = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.txt_sell = new DevExpress.XtraEditors.TextEdit();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(94, 120);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(113, 20);
            this.txt_quantity.TabIndex = 15;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sell_KeyPress);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_Dept);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_quantity);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btn_add);
            this.groupControl1.Controls.Add(this.btn_Cancel);
            this.groupControl1.Controls.Add(this.timeEdit1);
            this.groupControl1.Controls.Add(this.txt_sell);
            this.groupControl1.Controls.Add(this.txt_price);
            this.groupControl1.Controls.Add(this.txt_name);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(834, 151);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Order details";
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Location = new System.Drawing.Point(687, 120);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(121, 21);
            this.cmb_Dept.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(610, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "dept_name";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Quantity";
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(687, 24);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(113, 31);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(687, 61);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 35);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2016, 3, 28, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(469, 120);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "D";
            this.timeEdit1.Size = new System.Drawing.Size(113, 20);
            this.timeEdit1.TabIndex = 11;
            // 
            // txt_sell
            // 
            this.txt_sell.Location = new System.Drawing.Point(94, 76);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(113, 20);
            this.txt_sell.TabIndex = 10;
            this.txt_sell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sell_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(469, 76);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(113, 20);
            this.txt_price.TabIndex = 9;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sell_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(94, 35);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(251, 20);
            this.txt_name.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(469, 35);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(113, 20);
            this.txt_id.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 79);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Sell Price";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(371, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Purchasing price";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Name of item";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(371, 123);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Date";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(371, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Item ID";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 179);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(834, 365);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frm_AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_AddNewItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_AddNewItem1";
            this.Load += new System.EventHandler(this.frm_AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_quantity;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.TextEdit txt_sell;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}