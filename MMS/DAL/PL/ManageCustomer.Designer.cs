namespace MMS.DAL.PL
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_pay = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ts_Gender = new DevExpress.XtraEditors.ToggleSwitch();
            this.se_Age = new DevExpress.XtraEditors.SpinEdit();
            this.txt_Telephone = new DevExpress.XtraEditors.TextEdit();
            this.txt_Adress = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(31, 98);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 13);
            this.labelControl7.TabIndex = 50;
            this.labelControl7.Text = "Age";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(237, 64);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "address";
            // 
            // cmb_pay
            // 
            this.cmb_pay.FormattingEnabled = true;
            this.cmb_pay.Items.AddRange(new object[] {
            "Cach",
            "Credit Card"});
            this.cmb_pay.Location = new System.Drawing.Point(569, 60);
            this.cmb_pay.Name = "cmb_pay";
            this.cmb_pay.Size = new System.Drawing.Size(121, 21);
            this.cmb_pay.TabIndex = 48;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(476, 68);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Pay_Method";
            // 
            // ts_Gender
            // 
            this.ts_Gender.Location = new System.Drawing.Point(567, 17);
            this.ts_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_Gender.Name = "ts_Gender";
            this.ts_Gender.Properties.OffText = "Male";
            this.ts_Gender.Properties.OnText = "Female";
            this.ts_Gender.Size = new System.Drawing.Size(111, 24);
            this.ts_Gender.TabIndex = 46;
            // 
            // se_Age
            // 
            this.se_Age.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Age.Location = new System.Drawing.Point(96, 95);
            this.se_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.se_Age.Name = "se_Age";
            this.se_Age.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Age.Size = new System.Drawing.Size(86, 20);
            this.se_Age.TabIndex = 45;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(334, 61);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(109, 20);
            this.txt_Telephone.TabIndex = 41;
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(334, 25);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(109, 20);
            this.txt_Adress.TabIndex = 42;
            this.txt_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Adress_KeyPress);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(96, 57);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(109, 20);
            this.txt_LastName.TabIndex = 44;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(96, 22);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(109, 20);
            this.txt_FirstName.TabIndex = 43;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(476, 24);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 40;
            this.labelControl6.Text = "Gender";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(237, 32);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "Telephone";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Last Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "First Name";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 162);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(824, 278);
            this.gridControl1.TabIndex = 51;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(533, 118);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(240, 38);
            this.btn_delete.TabIndex = 52;
            this.btn_delete.Text = "delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(122, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(249, 38);
            this.btn_update.TabIndex = 53;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 452);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmb_pay);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ts_Gender);
            this.Controls.Add(this.se_Age);
            this.Controls.Add(this.txt_Telephone);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cmb_pay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ToggleSwitch ts_Gender;
        private DevExpress.XtraEditors.SpinEdit se_Age;
        private DevExpress.XtraEditors.TextEdit txt_Telephone;
        private DevExpress.XtraEditors.TextEdit txt_Adress;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_update;
    }
}