namespace MMS.PL
{
    partial class frm_AddDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddDept));
            this.txt_DeptName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Create = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.cmbManager = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DeptName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_DeptName
            // 
            this.txt_DeptName.Location = new System.Drawing.Point(170, 38);
            this.txt_DeptName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DeptName.Name = "txt_DeptName";
            this.txt_DeptName.Size = new System.Drawing.Size(212, 20);
            this.txt_DeptName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Department Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 85);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Department Manager";
            // 
            // btn_Create
            // 
            this.btn_Create.Image = ((System.Drawing.Image)(resources.GetObject("btn_Create.Image")));
            this.btn_Create.Location = new System.Drawing.Point(89, 131);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(99, 29);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Create";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(209, 131);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(95, 29);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cmbManager
            // 
            this.cmbManager.FormattingEnabled = true;
            this.cmbManager.Items.AddRange(new object[] {
            "Choose Department Manager "});
            this.cmbManager.Location = new System.Drawing.Point(170, 85);
            this.cmbManager.Name = "cmbManager";
            this.cmbManager.Size = new System.Drawing.Size(212, 21);
            this.cmbManager.TabIndex = 6;
            // 
            // frm_AddDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 191);
            this.Controls.Add(this.cmbManager);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_DeptName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_AddDept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Department";
            this.Load += new System.EventHandler(this.frm_AddDept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_DeptName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_DeptName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Create;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private System.Windows.Forms.ComboBox cmbManager;
    }
}