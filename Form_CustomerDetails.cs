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
using System.Data.SqlClient;

namespace Gear_Store
{
    public partial class Form_CustomerDetails : Form
    {
        public string mode;
        public string[] data= {"","","","","","","","" };
        bool mouseDown = false;
        private Point offset;
        bool yes = true;
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

        GearStoreEntities db = new GearStoreEntities();
        public void ResetAllText()
        {
            txtCustomerID.ResetText();
            txtFName.ResetText();
            txtLName.ResetText();
            txtPhone.ResetText();
            txtEmail.ResetText();
            txtState.ResetText();
            txtStreet.ResetText();
            txtState.ResetText();
            txtCity.ResetText();
        }
        public void AutoID()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=GearStore;Integrated Security=True");
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Auto_IDCus()", conn);
            string result = Convert.ToString(cmd.ExecuteScalar());
            txtCustomerID.Text = result.Trim();
            conn.Close();
        }
         void LoadData()
        {
            ResetAllText();
            AutoID();
            if (mode=="Edit")
            {
                txtCustomerID.Text = data[0];
                txtFName.Text = data[1];
                txtLName.Text = data[2];
                txtPhone.Text = data[3];
                txtEmail.Text = data[4];
                txtStreet.Text = data[5];
                txtCity.Text = data[6];
                txtState.Text = data[7];
            }
        }
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length != 0)
            {
                if (IsValidEmail(txtEmail.Text))
                    txtEmail.IconRight = Gear_Store.Properties.Resources._checked;
                else
                {
                    txtEmail.IconRight = Gear_Store.Properties.Resources.cancel;
                }
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
                {
                    txtPhone.IconRight = Gear_Store.Properties.Resources.cancel;
                }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        void Check()
        {
            if (txtFName.Text.Trim() == "")
            {
                snackbarcomplete.Show(this, "Please enter your name!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtFName.Focus();
                yes = false;
            }
            if (txtLName.Text.Trim() == "")
            {
                snackbarcomplete.Show(this, "Please enter your name!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtLName.Focus();
                yes = false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                snackbarcomplete.Show(this, "Please enter your email!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtLName.Focus();
                yes = false;
            }
            if (!IsValidPhoneNumber(txtPhone.Text)) yes = false;
            if (!IsValidEmail(txtEmail.Text)) yes = false;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            Check();
            if (yes)
            {
                try
                {
                    if (mode == "New")
                    {

                        db.InsertCustomer(txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, txtStreet.Text, txtCity.Text, txtState.Text);
                        snackbarcomplete.Show(this, "Customer successfully added", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        LoadData();
                    }
                    else
                    {
                        db.UpdateCustomer(txtCustomerID.Text, txtFName.Text, txtLName.Text, txtPhone.Text, txtEmail.Text, txtStreet.Text, txtCity.Text, txtState.Text);
                        snackbarcomplete.Show(this, "Customer successfully edited", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    }
                }
                catch (Exception)
                {
                    snackbarcomplete.Show(this, "Error!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            else snackbarcomplete.Show(this, "Please enter correct", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            yes = true;
        }

        private void Form_CustomerDetails_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
