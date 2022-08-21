using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopriteGhLimited
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }


        #region panelSlide
        private void customizeDesign()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubStock.Visible = false;
            panelSubSetting.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;
            if (panelSubSetting.Visible == true)
                panelSubSetting.Visible = false;
        }

        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            } else
                submenu.Visible = false;
        }
        #endregion panelSlide


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubProduct);
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void btnCategory_Click(object sender, EventArgs e)

        {
            hideSubmenu();
        }

        private void btnBrand_Click(object sender, EventArgs e)

        {
            hideSubmenu();
        }

        private void btnInStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubStock);
        }

        private void btnStockEntry_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnStockAdjustment_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubRecord);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
        private void flowLayoutPanel1_Paint(object sender, EventArgs e)
        {
            
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalesHis_Click(object sender, EventArgs e)
        {
            hideSubmenu(); 
        }

        private void btnPostRecord_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubSetting);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            hideSubmenu();
        }
    }
}
