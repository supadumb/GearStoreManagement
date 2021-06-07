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
    public partial class Form_Staff : Form
    {
        public Form_Staff()
        {
            InitializeComponent();
        }
        GearStoreEntities db = new GearStoreEntities();

        #region Misc

        private void btnDel_MouseHover(object sender, EventArgs e)
        {
            btndelete.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_trash_can_48px;
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
            var d = db.Staffs.Select(n => new
            {
                ID = n.staff_id,
                Password=n.pass,
                Users=n.users_name,
                Birthday=n.birthday,
                Address=n.addr,
                Salary=n.salary,
                Email=n.email,
                Phone=n.phone,
                Poisition=n.poitision
            });
            dgv.DataSource = d.ToList();

        }
        private void Form_Staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Form_StaffDetails frm_cusD = new  Form_StaffDetails())
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
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                int r = dgv.CurrentCell.RowIndex;
                try
                {
                    using (Form_StaffDetails frm_cusD = new Form_StaffDetails())
                    {
                        frm_cusD.mode = "Edit";
                    string temp;
                        frm_cusD.data[0] = dgv.Rows[r].Cells[0].Value.ToString();
                        frm_cusD.data[1] = dgv.Rows[r].Cells[1].Value.ToString();
                        frm_cusD.data[2] = dgv.Rows[r].Cells[2].Value.ToString();
                        frm_cusD.data[3] = dgv.Rows[r].Cells[3].Value.ToString();
                        frm_cusD.data[4] = dgv.Rows[r].Cells[4].Value.ToString();
                        frm_cusD.data[5] = dgv.Rows[r].Cells[5].Value.ToString();
                        frm_cusD.data[6] = dgv.Rows[r].Cells[6].Value.ToString();
                        frm_cusD.data[7] = dgv.Rows[r].Cells[7].Value.ToString();
                        temp = dgv.Rows[r].Cells[8].Value.ToString().Trim();
                        frm_cusD.data[8] = temp;
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
                    db.DeleteStaff(dgv.Rows[r].Cells[0].Value.ToString());
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
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            var sr = db.SearchedStaff(txtsearch.Text).Select(n => new
            {
                ID = n.staff_id,
                Password = n.pass,
                Users = n.users_name,
                Birthday = n.birthday,
                Address = n.addr,
                Salary = n.salary,
                Email = n.email,
                Phone = n.phone,
                Poisition = n.poitision
            });
            dgv.DataSource = sr;
        }

        private void Form_Staff_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
