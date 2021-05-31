using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Gear_Store
{
    public partial class Form_CustomerDetails : Form
    {
        public string mode;
        bool mouseDown = false;
        private Point offset;

        public Form_CustomerDetails()
        {
            InitializeComponent();
        }


        #region Misc
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
        private void txtColorChange_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTextBox tb = (Bunifu.UI.WinForms.BunifuTextBox)sender;
            if(tb.Parent == bunifuGroupBox1)
                foreach (Label item in this.bunifuGroupBox1.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.Orange;
                        return;
                    }
                }
            else if(tb.Parent == bunifuGroupBox2)
                foreach (Label item in this.bunifuGroupBox2.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.Orange;
                        return;
                    }
                }
            else
                foreach (Label item in this.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.Orange;
                        return;
                    }
                }
        }
        private void txtColorChange_Leave(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuTextBox tb = (Bunifu.UI.WinForms.BunifuTextBox)sender;
            if (tb.Parent == bunifuGroupBox1)
                foreach (Label item in this.bunifuGroupBox1.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.White;
                        return;
                    }
                }
            else if (tb.Parent == bunifuGroupBox2)
                foreach (Label item in this.bunifuGroupBox2.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.White;
                        return;
                    }
                }
            else
                foreach (Label item in this.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.White;
                        return;
                    }
                }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidPhoneNumber(string number)
        {
            return Regex.Match(number, @"(84|0[1-9])+([0-9]{8})\b").Success;
        }
        #endregion

       
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length != 0)
            {
                if (IsValidEmail(txtEmail.Text))
                    txtEmail.IconRight = Gear_Store.Properties.Resources._checked;
                else
                    txtEmail.IconRight = Gear_Store.Properties.Resources.cancel;
            }
            else
            {
                txtEmail.IconRight = Gear_Store.Properties.Resources.cancel;
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length != 0)
            {
                if (IsValidPhoneNumber(txtPhone.Text))
                    txtPhone.IconRight = Gear_Store.Properties.Resources._checked;
                else
                    txtPhone.IconRight = Gear_Store.Properties.Resources.cancel;
            }
            else
            {
                txtPhone.IconRight = Gear_Store.Properties.Resources.cancel;
            }
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            txtColorChange_Leave(sender, e);
        }

        private void Form_CustomerDetails_Load(object sender, EventArgs e)
        {
            bunifuLabel2.Text = mode;
        }
    }
}
