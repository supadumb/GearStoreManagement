using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
         public void LoadData()
        {
            var data = db.Customers.Select(n => new
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
            dgv.DataSource = data.ToList();
        }
        void MySet()
        {
            LoadData();
        }
        #region Misc
        private void btnDel_MouseHover(object sender, EventArgs e)
        {
            btndelete.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_trash_can_48px;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            btnprint.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_print_48px;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_CustomerDetails frm_cusD = new Form_CustomerDetails())
                {
                    frm_cusD.mode = "New";
                    frm_cusD.ShowDialog();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                int r = dgv.CurrentCell.RowIndex;
                //code
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
                        frm_cusD.ShowDialog();
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
            if (dgv.CurrentCell == null) 
            {
                //code
            }
            else
            {
                //code
            } 
                
        }



        private void btnload_Click(object sender, EventArgs e)
        {
            LoadData();
            txtsearch.ResetText();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
            MySet();
        }
    }
}
