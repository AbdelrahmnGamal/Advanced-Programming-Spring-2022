using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;

namespace MMS
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
          public frm_Main()
        {
            InitializeComponent();
            Skin();
            
            
        }
        void Skin()
        {
            SkinHelper.InitSkinGallery(rgbiSkins,true);
        }


      

       

        private void barButtonItem6_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("are you sure ? ", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }


        // open order management form
        private void navBarItem2_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (Program.Emp_name != "AbdElRahman Gamal")
            {
                MessageBox.Show("sorry our Employee, But you dont have Right to open Report Form","Not allowed", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }


            PL.frm_OrderManagement frm = new PL.frm_OrderManagement();
            frm.ShowDialog();
        }

        private void add_product_link_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_AddNewItem frm = new PL.frm_AddNewItem();
            frm.ShowDialog();
        }

        private void manage_product_link_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_ManageProducts frm = new PL.frm_ManageProducts();
            frm.ShowDialog();
        }

        private void add_dept_link_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_AddDept frm = new PL.frm_AddDept();
            frm.ShowDialog();
        }

        private void manage_dept_link_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_ManageDept frm = new PL.frm_ManageDept();
            frm.ShowDialog();
        }

        private void add_emp_link_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_AddEmp frm = new PL.frm_AddEmp();
            frm.ShowDialog();
        }

        private void manage_emp_link_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_ManageEmp frm = new PL.frm_ManageEmp();
            frm.ShowDialog();
        
        }

        private void order_link_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            PL.frm_Order frm = new PL.frm_Order();
            frm.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            PL.frm_Login frm_login = new PL.frm_Login();
            frm_login.ShowDialog();

            if (Program.isLogin)
            {
               
                LogIn.Enabled = false;
                LogOut.Enabled = true;
            }
           
         
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            DAL.PL.frm_AddCustomer frm_cutomer = new DAL.PL.frm_AddCustomer();
            frm_cutomer.ShowDialog();
         }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DAL.PL.ManageCustomer frm_managerCustomer = new DAL.PL.ManageCustomer();
            frm_managerCustomer.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
          
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            if (Program.Emp_name!="AbdElRahman Gamal")
            {
                MessageBox.Show("sorry our Employee, But you dont have Right to open Report Form", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DAL.PL.frm_Reports FRM_REPprt = new DAL.PL.frm_Reports();
                FRM_REPprt.ShowDialog();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Alloperation.Enabled = false;
            LogIn.Enabled = true;
            LogOut.Enabled = false;


        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            DAL.PL.frmBackup frmBackup = new DAL.PL.frmBackup();

            frmBackup.StartPosition = FormStartPosition.CenterParent;
            frmBackup.ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            DAL.PL.frm_Restore frmRestore = new DAL.PL.frm_Restore();
            frmRestore.StartPosition = FormStartPosition.CenterParent;
            frmRestore.ShowDialog();

        }

        private void btnFacebook_Click(object sender, EventArgs e)
        { 


                System.Diagnostics.Process.Start("https://www.facebook.com/");
      
            
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com");

        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");

        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/");

        }

        private void backstageViewControl2_Click(object sender, EventArgs e)
        {

        }

         

        

      
       

     




    }
}
