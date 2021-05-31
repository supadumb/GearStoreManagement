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
    public partial class Form_Menu : Form
    {
        bool cl = false;
        bool mouseDown = false;
        private Point offset;

        Form_Customer frm_cus;
        Form_Product frm_pro;
        public Form_Menu()
        {
            InitializeComponent();
        }

        #region Misc
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maxi_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentPos = PointToScreen(e.Location);
                Location = new Point(currentPos.X - offset.X, currentPos.Y - offset.Y);
            }
        }
        #endregion



        void loadFrom()
        {
            frm_cus = new Form_Customer()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            pCustomer.Controls.Add(frm_cus);

            frm_pro = new Form_Product()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            pProduct.Controls.Add(frm_pro);

        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            loadFrom();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            page.SetPage(3);
            frm_cus.Refresh();

            //btnCustomer.ForeColor = Color.Orange;
            //btnDashBoard.ForeColor = Color.White;
            //btnProduct.ForeColor = Color.White;
            //btnOrder.ForeColor = Color.White;
            //btnEmployee.ForeColor = Color.White;

            frm_cus.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            page.SetPage(1);
            frm_pro.Refresh();
            frm_pro.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnDashBoard_MouseHover(object sender, EventArgs e)
        {
            btnDashBoard.ForeColor = Color.Orange;
            btnDashBoard.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_home_48px;
        }

    }
}
