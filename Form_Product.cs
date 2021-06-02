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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
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
            Form_ProductDetails frm = new Form_ProductDetails();
            frm.Show();

        }
    }
}
