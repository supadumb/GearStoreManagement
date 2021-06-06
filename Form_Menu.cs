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
        Form_Dashboard frm_dash;
        Form_Staff frm_staff;
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

        GearStoreEntities db = new GearStoreEntities();

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
            frm_dash = new Form_Dashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            pDashboard.Controls.Add(frm_dash);
            frm_staff = new Form_Staff()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            pStaff.Controls.Add(frm_staff);
        }
        private void Form_Menu_Load(object sender, EventArgs e)
        {
            loadFrom();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            page.SetPage(0);
            frm_dash.Refresh();
            frm_dash.Show();
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
            page.SetPage(4);
            frm_staff.Refresh();
            frm_staff.Show();
        }

        private void btnDashBoard_MouseHover(object sender, EventArgs e)
        {
            btnDashBoard.ForeColor = Color.Orange;
            btnDashBoard.IdleIconLeftImage = Gear_Store.Properties.Resources.Orange_home_48px;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            page.SetPage(3);
            frm_cus.Refresh();
            frm_cus.Show();
        }

    }
}
