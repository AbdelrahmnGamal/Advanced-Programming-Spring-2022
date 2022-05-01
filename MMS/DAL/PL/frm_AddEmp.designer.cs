namespace MMS.PL
{
    partial class frm_AddEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddEmp));
            this.se_Age = new DevExpress.XtraEditors.SpinEdit();
            this.txt_Telephone = new DevExpress.XtraEditors.TextEdit();
            this.txt_Adress = new DevExpress.XtraEditors.TextEdit();
            this.txt_LastName = new DevExpress.XtraEditors.TextEdit();
            this.txt_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.age = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ts_Gender = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.txt_Passwrod = new DevExpress.XtraEditors.TextEdit();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsalary = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passwrod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalary.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // se_Age
            // 
            this.se_Age.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Age.Location = new System.Drawing.Point(132, 63);
            this.se_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.se_Age.Name = "se_Age";
            this.se_Age.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Age.Size = new System.Drawing.Size(86, 20);
            this.se_Age.TabIndex = 13;
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(132, 121);
            this.txt_Telephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(109, 20);
            this.txt_Telephone.TabIndex = 9;
            this.txt_Telephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telephone_KeyPress);
            // 
            // txt_Adress
            // 
            this.txt_Adress.Location = new System.Drawing.Point(132, 93);
            this.txt_Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(109, 20);
            this.txt_Adress.TabIndex = 10;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(132, 36);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(109, 20);
            this.txt_LastName.TabIndex = 12;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(132, 9);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(109, 20);
            this.txt_FirstName.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(24, 153);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 15);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Gender";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(24, 124);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 15);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Telephone";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(24, 95);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 15);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Adress";
            // 
            // age
            // 
            this.age.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(24, 66);
            this.age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(20, 15);
            this.age.TabIndex = 7;
            this.age.Text = "Age";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(24, 39);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 15);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Last Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(24, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 15);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "First Name";
            // 
            // ts_Gender
            // 
            this.ts_Gender.Location = new System.Drawing.Point(130, 149);
            this.ts_Gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ts_Gender.Name = "ts_Gender";
            this.ts_Gender.Properties.OffText = "Male";
            this.ts_Gender.Properties.OnText = "Female";
            this.ts_Gender.Size = new System.Drawing.Size(111, 24);
            this.ts_Gender.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(24, 185);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 15);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "Manager";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(24, 244);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 15);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Department";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(24, 274);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(58, 15);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "User Name";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(24, 302);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 15);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Password";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(132, 272);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(139, 20);
            this.txt_UserName.TabIndex = 9;
            // 
            // txt_Passwrod
            // 
            this.txt_Passwrod.Location = new System.Drawing.Point(132, 300);
            this.txt_Passwrod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Passwrod.Name = "txt_Passwrod";
            this.txt_Passwrod.Properties.PasswordChar = '*';
            this.txt_Passwrod.Size = new System.Drawing.Size(139, 20);
            this.txt_Passwrod.TabIndex = 9;
            this.txt_Passwrod.EditValueChanged += new System.EventHandler(this.txt_Passwrod_EditValueChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.Location = new System.Drawing.Point(12, 334);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(98, 43);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(143, 334);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(98, 43);
            this.btn_Clear.TabIndex = 17;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(257, 334);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(98, 43);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Items.AddRange(new object[] {
            "Choose Department"});
            this.cmbDept.Location = new System.Drawing.Point(132, 241);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(139, 21);
            this.cmbDept.TabIndex = 18;
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbManager.Location = new System.Drawing.Point(132, 182);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(109, 21);
            this.cmbManager.TabIndex = 19;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(257, 174);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 34);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "AddNewDepartment";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(24, 216);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 15);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(132, 209);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(109, 20);
            this.txtsalary.TabIndex = 22;
            // 
            // frm_AddEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 388);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cmbManager);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Clear);
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
            this.Controls.Add(this.age);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_AddEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.frm_AddEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.se_Age.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Telephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Adress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts_Gender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Passwrod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsalary.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit se_Age;
        private DevExpress.XtraEditors.TextEdit txt_Telephone;
        private DevExpress.XtraEditors.TextEdit txt_Adress;
        private DevExpress.XtraEditors.TextEdit txt_LastName;
        private DevExpress.XtraEditors.TextEdit txt_FirstName;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl age;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch ts_Gender;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_UserName;
        private DevExpress.XtraEditors.TextEdit txt_Passwrod;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.ComboBox cmbDept;
        private System.Windows.Forms.ComboBox cmbManager;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsalary;
    }
}