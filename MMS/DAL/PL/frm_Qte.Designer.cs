namespace MMS.DAL.PL
{
    partial class frm_Qte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Qte));
            this.btn_showRpt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_showRpt
            // 
            this.btn_showRpt.Image = ((System.Drawing.Image)(resources.GetObject("btn_showRpt.Image")));
            this.btn_showRpt.Location = new System.Drawing.Point(59, 149);
            this.btn_showRpt.Name = "btn_showRpt";
            this.btn_showRpt.Size = new System.Drawing.Size(206, 31);
            this.btn_showRpt.TabIndex = 15;
            this.btn_showRpt.Text = "Show report";
            this.btn_showRpt.Click += new System.EventHandler(this.btn_showRpt_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(12, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(309, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Enter the Quantity to search product less than Enterd value";
            // 
            // txtQte
            // 
            this.txtQte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQte.Location = new System.Drawing.Point(116, 90);
            this.txtQte.MaxLength = 8;
            this.txtQte.Multiline = true;
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(86, 23);
            this.txtQte.TabIndex = 17;
            this.txtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQte_KeyPress);
            // 
            // frm_Qte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btn_showRpt);
            this.Name = "frm_Qte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Qte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_showRpt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtQte;
    }
}