namespace MMS.DAL.PL
{
    partial class frm_AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddCustomer));
            this.cmb_pay = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_pay
            // 
            this.cmb_pay.FormattingEnabled = true;
            this.cmb_pay.Items.AddRange(new object[] {
            "Cach",
            "Credit Card"});
            this.cmb_pay.Location = new System.Drawing.Point(130, 210);
            this.cmb_pay.Name = "cmb_pay";
            this.cmb_pay.Size = new System.Drawing.Size(121, 21);
            this.cmb_pay.TabIndex = 34;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 218);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "Pay_Method";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(201, 264);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 35);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(114, 264);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(81, 35);
            this.btn_Clear.TabIndex = 32;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(12, 264);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 35);
            this.btn_Add.TabIndex = 30;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ts_Gender
            // 
            this.ts_Gender.Location = new System.Drawing.Point(128, 162);
            this.ts_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_Gender.Name = "ts_Gender";
            this.ts_Gender.Properties.OffText = "Male";
            this.ts_Gender.Properties.OnText = "Female";
            this.ts_Gender.Size = new System.Drawing.Size(111, 24);
            this.ts_Gender.TabIndex = 29;
            // 
            // se_Age
            // 
            this.se_Age.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Age.Location = new System.Drawing.Point(130, 76);
            this.se_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.se_Age.Name = "se_Age";
            this.se_Age.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Age.Size = new System.Drawing.Size(86, 20);
            this.se_Age.TabIndex = 28;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(130, 110);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(109, 20);
            this.txt_Telephone.TabIndex = 24;
            this.txt_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telephone_KeyPress);
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(130, 138);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(109, 20);
            this.txt_Adress.TabIndex = 25;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(130, 49);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(109, 20);
            this.txt_LastName.TabIndex = 27;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(130, 22);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(109, 20);
            this.txt_FirstName.TabIndex = 26;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 173);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Gender";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 113);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Telephone";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 52);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Last Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 24);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 141);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "address";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(22, 79);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(19, 13);
            this.labelControl7.TabIndex = 36;
            this.labelControl7.Text = "Age";
            // 
            // frm_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 357);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cmb_pay);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Add);
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
            this.Name = "frm_AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_pay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}