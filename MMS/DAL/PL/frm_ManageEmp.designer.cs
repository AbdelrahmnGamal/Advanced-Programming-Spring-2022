namespace MMS.PL
{
    partial class frm_ManageEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageEmp));
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.ts_Gender = new DevExpress.XtraEditors.ToggleSwitch();
            this.se_Age = new DevExpress.XtraEditors.SpinEdit();
            this.txt_Passwrod = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.txt_Telephone = new DevExpress.XtraEditors.TextEdit();
            this.txt_Adress = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.txtsalary = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passwrod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(267, 370);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(106, 27);
            this.btn_Cancel.TabIndex = 39;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(145, 370);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(104, 27);
            this.btn_Delete.TabIndex = 40;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(12, 370);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(110, 27);
            this.btn_Add.TabIndex = 38;
            this.btn_Add.Text = "Update";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ts_Gender
            // 
            this.ts_Gender.Location = new System.Drawing.Point(179, 186);
            this.ts_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_Gender.Name = "ts_Gender";
            this.ts_Gender.Properties.OffText = "Male";
            this.ts_Gender.Properties.OnText = "Female";
            this.ts_Gender.Size = new System.Drawing.Size(152, 24);
            this.ts_Gender.TabIndex = 36;
            // 
            // se_Age
            // 
            this.se_Age.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Age.Location = new System.Drawing.Point(175, 100);
            this.se_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.se_Age.Name = "se_Age";
            this.se_Age.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Age.Size = new System.Drawing.Size(127, 20);
            this.se_Age.TabIndex = 35;
            // 
            // txt_Passwrod
            // 
            this.txt_Passwrod.Location = new System.Drawing.Point(173, 341);
            this.txt_Passwrod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Passwrod.Name = "txt_Passwrod";
            this.txt_Passwrod.Properties.PasswordChar = '*';
            this.txt_Passwrod.Size = new System.Drawing.Size(127, 20);
            this.txt_Passwrod.TabIndex = 28;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(173, 313);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(127, 20);
            this.txt_UserName.TabIndex = 29;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(175, 159);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(127, 20);
            this.txt_Telephone.TabIndex = 30;
            this.txt_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telephone_KeyPress);
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(175, 131);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(127, 20);
            this.txt_Adress.TabIndex = 32;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(175, 74);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(127, 20);
            this.txt_LastName.TabIndex = 34;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(175, 46);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(127, 20);
            this.txt_FirstName.TabIndex = 33;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(65, 344);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 15);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Password";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(65, 316);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 15);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "User Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(65, 285);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 15);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Department";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(66, 219);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 15);
            this.labelControl7.TabIndex = 23;
            this.labelControl7.Text = "Manager";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(65, 192);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 15);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "Gender";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(67, 161);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 15);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Telephone";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(67, 133);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 15);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Adress";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(67, 103);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 15);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Age";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(67, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 15);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Last Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(67, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 15);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "First Name";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Location = new System.Drawing.Point(30, 20);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(51, 15);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Employee";
            // 
            // cmbEmp
            // 
            this.cmbEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(175, 12);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(177, 21);
            this.cmbEmp.TabIndex = 41;
            this.cmbEmp.SelectedIndexChanged += new System.EventHandler(this.cmbEmp_SelectedIndexChanged);
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbManager.Location = new System.Drawing.Point(174, 219);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(150, 21);
            this.cmbManager.TabIndex = 43;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Choose Department"});
            this.cmbDept.Location = new System.Drawing.Point(173, 285);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(180, 21);
            this.cmbDept.TabIndex = 42;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(175, 249);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(149, 20);
            this.txtsalary.TabIndex = 45;
            this.txtsalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalary_KeyPress);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Location = new System.Drawing.Point(66, 252);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(35, 15);
            this.labelControl12.TabIndex = 44;
            this.labelControl12.Text = "Salary";
            // 
            // frm_ManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 408);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.cmbManager);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ts_Gender);
            this.Controls.Add(this.se_Age);
            this.Controls.Add(this.txt_Passwrod);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.txt_Telephone);
            this.Controls.Add(this.txt_Adress);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ManageEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Employees";
            this.Load += new System.EventHandler(this.frm_ManageEmp_Load);
            this.Shown += new System.EventHandler(this.frm_ManageEmp_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passwrod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalary.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.ToggleSwitch ts_Gender;
        private DevExpress.XtraEditors.SpinEdit se_Age;
        private DevExpress.XtraEditors.TextEdit txt_Passwrod;
        private DevExpress.XtraEditors.TextEdit txt_UserName;
        private DevExpress.XtraEditors.TextEdit txt_Telephone;
        private DevExpress.XtraEditors.TextEdit txt_Adress;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbManager;
        private System.Windows.Forms.ComboBox cmbDept;
        private DevExpress.XtraEditors.TextEdit txtsalary;
        private DevExpress.XtraEditors.LabelControl labelControl12;

    }
}