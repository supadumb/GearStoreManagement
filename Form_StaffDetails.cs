using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear_Store
{
    public partial class Form_StaffDetails : Form
    {
        public string mode;
        public string[] data = { "", "", "", "", "", "", "", "","" };
        bool mouseDown = false;
        private Point offset;
        bool yes = true;
        public Form_StaffDetails()
        {
            InitializeComponent();
        }

        GearStoreEntities db = new GearStoreEntities();
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
            if (tb.Parent == bunifuGroupBox1)
                foreach (Label item in this.bunifuGroupBox1.Controls.OfType<Label>())
                {
                    if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                    {
                        item.ForeColor = Color.Orange;
                        return;
                    }
                }
            else if (tb.Parent == bunifuGroupBox2)
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
        public void ResetAllText()
        {
            txtstaffid.ResetText();
            txtpass.ResetText();
            txtusername.ResetText();
            txtemail.ResetText();
            txtphone.ResetText();
            txtaddress.ResetText();
            txtsalary.ResetText();
            txtdate.ResetText();
        }
        public void AutoID()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=GearStore;Integrated Security=True");
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Auto_IDSta()", conn);
            string result = Convert.ToString(cmd.ExecuteScalar());
            txtstaffid.Text = result.Trim();
            conn.Close();
        }
        void LoadData()
        {
            ResetAllText();
            AutoID();
            if (mode == "Edit")
            {
                txtstaffid.Text = data[0];
                txtpass.Text = data[1];
                txtusername.Text = data[2];
                txtdate.Text = data[3];
                txtaddress.Text = data[4];
                txtsalary.Text = data[5];
                txtemail.Text = data[6];
                txtphone.Text = data[7];
                cbpoisition.Text = "Employee";
                if (data[8] == "1") cbpoisition.Text = "Manager";

            }
        }
        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            if (txtemail.Text.Length != 0)
            {
                if (IsValidEmail(txtemail.Text))
                    txtemail.IconRight = Gear_Store.Properties.Resources._checked;
                else
                {
                    txtemail.IconRight = Gear_Store.Properties.Resources.cancel;
                }
            }
            else
            {
                txtemail.IconRight = Gear_Store.Properties.Resources.cancel;
            }
        }
        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            if (txtphone.Text.Length != 0)
            {
                if (IsValidPhoneNumber(txtphone.Text))
                    txtphone.IconRight = Gear_Store.Properties.Resources._checked;
                else
                {
                    txtphone.IconRight = Gear_Store.Properties.Resources.cancel;
                }
            }
            else
            {
                txtphone.IconRight = Gear_Store.Properties.Resources.cancel;
            }
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        void Check()
        {
            if (txtusername.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Please enter your username!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtusername.Focus();
                yes = false;
            }
            if (txtpass.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Please enter your password!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtpass.Focus();
                yes = false;
            }
            if (txtemail.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Please enter your email!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtemail.Focus();
                yes = false;
            }
            double num;
            if (txtsalary.Text.Trim() == "" || !double.TryParse(txtsalary.Text,out num))
            {
                bunifuSnackbar1.Show(this, "Please enter salary!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                txtsalary.Focus();
                yes = false;
            }
            if (cbpoisition.Text.Trim() == "")
            {
                bunifuSnackbar1.Show(this, "Please enter poisition!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning);
                cbpoisition.Focus();
                yes = false;
            }
            if (!IsValidPhoneNumber(txtphone.Text)) yes = false;
            if (!IsValidEmail(txtemail.Text)) yes = false;
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
                        int temp = 2;
                        if (cbpoisition.Text == "Manager") temp = 1;
                        DateTime d = DateTime.Parse(txtdate.Text);
                        db.InsertStaff(txtpass.Text,txtusername.Text,d,txtaddress.Text,decimal.Parse(txtsalary.Text),txtemail.Text,txtphone.Text,temp);
                        bunifuSnackbar1.Show(this, "Staff successfully added", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                        LoadData();
                    }
                    else
                    {
                        int temp = 2;
                        if (cbpoisition.Text == "Manager") temp = 1;
                        DateTime d = DateTime.Parse(txtdate.Text);
                        db.UpdateStaff(txtstaffid.Text,txtpass.Text, txtusername.Text, d, txtaddress.Text, decimal.Parse(txtsalary.Text), txtemail.Text, txtphone.Text, temp);
                        bunifuSnackbar1.Show(this, "Staff successfully edited", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                    }
                }
                catch (Exception)
                {
                    bunifuSnackbar1.Show(this, "Error!!!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                }
            }
            else bunifuSnackbar1.Show(this, "Please enter correct", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            yes = true;
        }

        private void Form_StaffDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
