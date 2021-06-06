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


        }


        #region Load Data

        private void LoadProd()
        {
            UCProduct[] listprod = new UCProduct[20];
            for(int i=0; i < listprod.Length; i++)
            {
                listprod[i] = new UCProduct();
                listprod[i].Title = "Test HERE!!!";
                listprod[i].Price = "1000000000$";

                flowtabOther.Controls.Add(listprod[i]);
                
            }
        }
        #endregion

        private void Form_Product_Load(object sender, EventArgs e)
        {
            LoadProd();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            tabButon.Hide();
            tabOther.Show();
        }
    }
}
