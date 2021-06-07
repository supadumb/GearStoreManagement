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
    public partial class Form_Customer : Form
    {
        public Form_Customer()
        {
            InitializeComponent();
        }
        GearStoreEntities db = new GearStoreEntities();

        #region Misc

        private void btnDel_MouseHover(object sender, EventArgs e)
        {
            btndelete.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_trash_can_48px;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnadd.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_plus_math_48px;
        }

        private void btnReload_MouseHover(object sender, EventArgs e)
        {
            btnload.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_reboot_48px;
        }

        #endregion
        public void LoadData()
        {
            var d = db.Customers.Select(n => new
            {
                ID = n.customer_id,
                FirstName = n.first_name,
                LastName = n.last_name,
                Phone = n.phone,
                Email = n.email,
                Street = n.street,
                City = n.city,
                State = n.state

            });
            dgv.DataSource = d.ToList();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_CustomerDetails frm_cusD = new Form_CustomerDetails())
                {
                    frm_cusD.mode = "New";
                    frm_cusD.ShowDialog();
                    LoadData();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        //Double Click = Edit mode
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                int r = dgv.CurrentCell.RowIndex;
                try
                {
                    using (Form_CustomerDetails frm_cusD = new Form_CustomerDetails())
                    {
                        frm_cusD.mode = "Edit";
                        frm_cusD.data[0] = dgv.Rows[r].Cells[0].Value.ToString();
                        frm_cusD.data[1] = dgv.Rows[r].Cells[1].Value.ToString();
                        frm_cusD.data[2] = dgv.Rows[r].Cells[2].Value.ToString();
                        frm_cusD.data[3] = dgv.Rows[r].Cells[3].Value.ToString();
                        frm_cusD.data[4] = dgv.Rows[r].Cells[4].Value.ToString();
                        frm_cusD.data[5] = dgv.Rows[r].Cells[5].Value.ToString();
                        frm_cusD.data[6] = dgv.Rows[r].Cells[6].Value.ToString();
                        frm_cusD.data[7] = dgv.Rows[r].Cells[7].Value.ToString();
                        frm_cusD.ShowDialog();
                        LoadData();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentCell != null)
                {
                    int r = dgv.CurrentCell.RowIndex;
                    db.DeleteCustomer(dgv.Rows[r].Cells[0].Value.ToString());
                    MessageBox.Show("Delete complete", "Notification");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please select the line you want to delete", "Notification");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Notification");
            }

        }


        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
            txtsearch.ResetText();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            var sr = db.SearchedCustomer(txtsearch.Text).Select(n => new
            {
                ID = n.customer_id,
                FirstName = n.first_name,
                LastName = n.last_name,
                Phone = n.phone,
                Email = n.email,
                Street = n.street,
                City = n.city,
                State = n.state
            });
            dgv.DataSource = sr;
        }


    }
}
