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

        public void LoadData()
        {

        }

        #region Misc
        private void btnDel_MouseHover(object sender, EventArgs e)
        {
            btnDel.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_trash_can_48px;
        }

        private void btnPrint_MouseHover(object sender, EventArgs e)
        {
            btnPrint.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_print_48px;
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_plus_math_48px;
        }

        private void btnReload_MouseHover(object sender, EventArgs e)
        {
            btnReload.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_reboot_48px;
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_CustomerDetails frm_cusD = new Form_CustomerDetails())
                {
                    frm_cusD.mode = "New Customer";
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
                        frm_cusD.mode = "Edit Customer";
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
    }
}
