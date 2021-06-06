using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear_Store
{
    public partial class Form_Brand : Form
    {
        public Form_Brand()
        {
            InitializeComponent();
        }
        #region data
        GearStoreEntities db = new GearStoreEntities();
        #endregion
        private void Form_Brand_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetTextBox();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            bool temp = true;
            if(string.IsNullOrEmpty(txtBrandName.Text))
            {
                txtBrandName.Focus();
                errorProvider.SetError(txtBrandName, "Please enter Brand name !");
            }
            else
            {
                errorProvider.SetError(txtBrandName, null);
                temp = true;
            }
            var Brand = db.SearchedBrand(txtBrandName.Text).Select(n => n.brand_name).Count();
            int count = int.Parse(Brand.ToString());
            if (count != 0)
            {
                txtBrandName.Focus();
                errorProvider.SetError(txtCategoryName, "Brand name has already exited!");
            }
            else
            {
                errorProvider.SetError(txtCategoryName, null);
                temp = true;
            }
            if (temp)
            {
                db.InsertBrand(txtBrandName.Text);
                LoadData();
                ResetTextBox();
            }
        }

        void ResetTextBox()
        {
            txtBrandName.ResetText();
            txtCategoryName.ResetText();
        }
        void LoadData()
        {
            var Brand = db.Brands.Select(n => new
            {
                BrandID = n.brand_id,
                BrandName = n.brand_name
            });
            dgvBrand.DataSource = Brand.ToList();

            var Category = db.Categories.Select(n => new
            {
                CategoryID = n.category_id,
                CategoryName = n.category_name
            });

            dgvcatg.DataSource = Category.ToList();
            
        }
        private void dgvBrand_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBrand.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtBrandName.Text = dgvBrand.Rows[r].Cells[1].Value.ToString().Trim();
        }

        private void dvgcatg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvcatg.CurrentCell.RowIndex;
            // Chuyển thông tin từ Gridview lên các textbox ở panel
            txtCategoryName.Text = dgvcatg.Rows[r].Cells[1].Value.ToString().Trim();
        }

        private void btnAddlPCatg_Click(object sender, EventArgs e)
        {
            bool temp = true;
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                txtBrandName.Focus();
                errorProvider.SetError(txtCategoryName, "Please enter Category name !");
            }
            else
            {
                errorProvider.SetError(txtCategoryName, null);
                temp = true;
            }

            
            var Category = db.SearchedCategory(txtCategoryName.Text).Select(n => n.category_name).Single();
            int count = int.Parse(Category.ToString());
            if (count != 0)
            {
                txtBrandName.Focus();
                errorProvider.SetError(txtCategoryName, "Category Name has already exited!");
            }
            else
            {
                errorProvider.SetError(txtCategoryName, null);
                temp = true;
            }
            if (temp)
            {
                db.InsertCategory(txtCategoryName.Text);
                LoadData();
                ResetTextBox();
            }
        }

        private void btnDelBrand_Click(object sender, EventArgs e)
        {
            DialogResult CheckYN;
            CheckYN = MessageBox.Show("Are you sure to delete this data ?", " Your answer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckYN == DialogResult.Yes)
            {
                try
                {
                    db.DeleteBrand(txtBrandName.Text);
                    Message.Show(this, "Brand successfully added", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LoadData();
                    ResetTextBox();
                }
                catch (SqlException)
                {
                    Message.Show(this, "Failed to added brand", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            ResetTextBox();
        }

        private void btnDelPCatg_Click(object sender, EventArgs e)
        {
            DialogResult CheckYN;
            CheckYN = MessageBox.Show("Are you sure to delete this data ?", " Your answer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckYN == DialogResult.Yes)
            {
                try
                {
                    db.DeleteCategory(txtCategoryName.Text);
                    Message.Show(this, "Category successfully added", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    LoadData();
                    ResetTextBox();
                }
                catch (SqlException)
                {
                    Message.Show(this, "Failed to added category", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            ResetTextBox();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
