using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShopriteGhLimited
{
    public partial class MainForm : Form
    {
        //setting up a connection to database
        SqlConnection cn = new SqlConnection(); //creating sql connection
        SqlCommand cm = new SqlCommand(); //creating sql command
        DBConnect dbcon = new DBConnect(); //creating a dbcon


        public MainForm()
        {
            InitializeComponent();
            customizeDesign(); //calling our method below to handle show or hide, we try to hide all components that are child
            cn = new SqlConnection(dbcon.myConnection());
            cn.Open();
            MessageBox.Show("Database connected");
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
