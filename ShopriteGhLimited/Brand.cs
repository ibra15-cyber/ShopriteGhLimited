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
    public partial class Brand : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Brand()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadBrand();
        }

        //data retrieve from tbBrand on the tbForm
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BrandModule moduleForm = new BrandModule(this);
            moduleForm.ShowDialog();

        }

        private void dgvBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //for update and delete brand by cell click form tband
            string colName = dgvBrand.Columns[e.ColumnIndex].Name;
            if (colName == "Deleted")
            {
                if (MessageBox.Show("Are you sure you want o save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tBrand WHERE id LIKE `" + dgvBrand[1, e.RowIndex].Value.ToString() + " ", cn);         
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Brand has been successfully deleted", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                } else if (colName == "Edit")
                {
                    BrandModule brandModule = new BrandModule(this);
                    brandModule.lblId.Text = dgvBrand[1, e.RowIndex].Value.ToString();
                    brandModule.txtBrand.Text = dgvBrand[2, e.RowIndex].Value.ToString();
                    brandModule.btnSave.Enabled = false;
                    brandModule.btnUpdate.Enabled = true;
                    brandModule.ShowDialog();

                }
                LoadBrand();
            }

        }

        public void LoadBrand()
        {
            int i=0;
            dgvBrand.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM tBand ORDERED BY brand", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBrand.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
