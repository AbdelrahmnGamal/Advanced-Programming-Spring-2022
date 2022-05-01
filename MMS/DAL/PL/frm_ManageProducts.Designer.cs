namespace MMS.PL
{
    partial class frm_ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageProducts));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmb_Dept = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_PrintAll = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printSelected = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.txt_quantity = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.txt_sell = new DevExpress.XtraEditors.TextEdit();
            this.txt_price = new DevExpress.XtraEditors.TextEdit();
            this.txt_name = new DevExpress.XtraEditors.TextEdit();
            this.txt_id = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_price.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmb_Dept);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_PrintAll);
            this.groupControl1.Controls.Add(this.btn_printSelected);
            this.groupControl1.Controls.Add(this.btn_delete);
            this.groupControl1.Controls.Add(this.btn_update);
            this.groupControl1.Controls.Add(this.txt_quantity);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.timeEdit1);
            this.groupControl1.Controls.Add(this.txt_sell);
            this.groupControl1.Controls.Add(this.txt_price);
            this.groupControl1.Controls.Add(this.txt_name);
            this.groupControl1.Controls.Add(this.txt_id);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(797, 196);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Item details";
            // 
            // cmb_Dept
            // 
            this.cmb_Dept.FormattingEnabled = true;
            this.cmb_Dept.Location = new System.Drawing.Point(445, 110);
            this.cmb_Dept.Name = "cmb_Dept";
            this.cmb_Dept.Size = new System.Drawing.Size(129, 21);
            this.cmb_Dept.TabIndex = 33;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(381, 113);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "dept_name";
            // 
            // btn_PrintAll
            // 
            this.btn_PrintAll.Enabled = false;
            this.btn_PrintAll.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintAll.Image")));
            this.btn_PrintAll.Location = new System.Drawing.Point(254, 143);
            this.btn_PrintAll.Name = "btn_PrintAll";
            this.btn_PrintAll.Size = new System.Drawing.Size(148, 38);
            this.btn_PrintAll.TabIndex = 30;
            this.btn_PrintAll.Text = "Print All items";
            this.btn_PrintAll.Click += new System.EventHandler(this.btn_PrintAll_Click);
            // 
            // btn_printSelected
            // 
            this.btn_printSelected.Enabled = false;
            this.btn_printSelected.Image = ((System.Drawing.Image)(resources.GetObject("btn_printSelected.Image")));
            this.btn_printSelected.Location = new System.Drawing.Point(40, 143);
            this.btn_printSelected.Name = "btn_printSelected";
            this.btn_printSelected.Size = new System.Drawing.Size(148, 38);
            this.btn_printSelected.TabIndex = 29;
            this.btn_printSelected.Text = "Print selected item";
            this.btn_printSelected.Click += new System.EventHandler(this.btn_printSelected_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(459, 143);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(148, 38);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(646, 143);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(125, 38);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(676, 30);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(113, 20);
            this.txt_quantity.TabIndex = 27;
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_ManageProducts_KeyPress);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(592, 33);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 26;
            this.labelControl7.Text = "Quantity";
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2016, 3, 28, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(85, 70);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "D";
            this.timeEdit1.Size = new System.Drawing.Size(224, 20);
            this.timeEdit1.TabIndex = 25;
            // 
            // txt_sell
            // 
            this.txt_sell.Location = new System.Drawing.Point(445, 70);
            this.txt_sell.Name = "txt_sell";
            this.txt_sell.Size = new System.Drawing.Size(129, 20);
            this.txt_sell.TabIndex = 24;
            this.txt_sell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_ManageProducts_KeyPress);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(676, 70);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(113, 20);
            this.txt_price.TabIndex = 23;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_ManageProducts_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(85, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(224, 20);
            this.txt_name.TabIndex = 22;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(445, 30);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(129, 20);
            this.txt_id.TabIndex = 21;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(393, 73);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Sell Price";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(592, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Purchasing price";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 33);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Name of item";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Date";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(393, 33);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Item ID";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(9, 214);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 347);
            this.gridControl1.TabIndex = 17;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // frm_ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 568);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_ManageProducts";
            this.Load += new System.EventHandler(this.frm_ManageProducts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_ManageProducts_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantity.Properties)).EndInit();
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

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_quantity;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        private DevExpress.XtraEditors.TextEdit txt_sell;
        private DevExpress.XtraEditors.TextEdit txt_price;
        private DevExpress.XtraEditors.TextEdit txt_name;
        private DevExpress.XtraEditors.TextEdit txt_id;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cmb_Dept;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton btn_PrintAll;
        public DevExpress.XtraEditors.SimpleButton btn_printSelected;
        public DevExpress.XtraEditors.SimpleButton btn_delete;
        public DevExpress.XtraEditors.SimpleButton btn_update;
    }
}