using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gear_Store
{
    public partial class Form_ProductInfo : Form
    {
        #region .data
        byte[] image = null;
        public string mode;
        bool mouseDown = false;
        private Point offset;
        string url;
        Form_Brand frm_brand = new Form_Brand();
        GearStoreEntities db = new GearStoreEntities();
        
        #endregion
        public Form_ProductInfo()
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
            try
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
            catch (Exception)
            {
                try
                {
                    Bunifu.UI.WinForms.BunifuDropdown tb = (Bunifu.UI.WinForms.BunifuDropdown)sender;
                    if (tb.Parent == bunifuGroupBox2)
                        foreach (Label item in this.bunifuGroupBox2.Controls.OfType<Label>())
                        {
                            if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                            {
                                item.ForeColor = Color.Orange;
                                return;
                            }
                        }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtColorChange_Leave(object sender, EventArgs e)
        {
            try
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
            catch(Exception erra)
            {
                try
                {
                    Bunifu.UI.WinForms.BunifuDropdown tb = (Bunifu.UI.WinForms.BunifuDropdown)sender;
                    if (tb.Parent == bunifuGroupBox2)
                        foreach (Label item in this.bunifuGroupBox2.Controls.OfType<Label>())
                        {
                            if (item.Name == "label" + tb.Name.Substring(3, tb.Name.Length - 3))
                            {
                                item.ForeColor = Color.White;
                                return;
                            }
                        }
                }
                catch (Exception errb)
                {
                    MessageBox.Show(erra.Message + "\n" + errb.Message);
                }
            }
        }


        #endregion
        private void Form_ProductInfo_Load(object sender, EventArgs e)
        {

            LoadData();
        }
        void LoadData()
        {
            LoadAutoID();
            LoadDatacbBrand();
            LoadDatacbCategory();
            ResetButton();
        }
        void LoadAutoID() {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=ThuCung;Integrated Security=True");
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.Auto_IDPeCa()", conn);
            string result = Convert.ToString(cmd.ExecuteScalar());
            txtProductID.Text = result.Trim();
            conn.Close();
        }

        void LoadDatacbBrand()
        {
            var temp = db.Brands.Select(n => n.brand_name);
            foreach (var i in temp)
                cbbBrandName.Items.Add(i);
        }
        void LoadDatacbCategory()
        {
            var temp = db.Categories.Select(n => n.category_name);
            foreach (var i in temp)
                cbbCategoryName.Items.Add(i);
        }
        
        void ResetButton()
        {
            txtDpt.ResetText();
            txtQuantity.ResetText();
            txtProductName.ResetText();
            txtProductID.ResetText();
            txtModelYear.ResetText();
            txtPrice.ResetText();
            cbbBrandName.ResetText();
            cbbCategoryName.ResetText();
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Select Your Image";
            openfile.Filter = "Image File (*.jpg;*.jepg;*.gif;*.bmp;*.png)|.jpg; *.jepg; *.gif; *.bmp;*.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                pbProducImage.ImageLocation = openfile.FileName;
                url = openfile.FileName;
            }

        }

           
            
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region check
            bool temp = false ;
            if (string.IsNullOrEmpty(txtDpt.Text)) txtDpt.Text = null;

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                txtProductName.Focus();
                errorProvider1.SetError(txtProductName, "Please enter product name !");
            }
            else
            {
                errorProvider1.SetError(txtProductName, null);
                temp = true;
            }
            if (string.IsNullOrEmpty(txtModelYear.Text))
            {
                txtModelYear.Focus();
                errorProvider1.SetError(txtModelYear, "Please enter model year !");
            }
            else
            {
                errorProvider1.SetError(txtModelYear, null);
                temp = true;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtProductName.Focus();
                errorProvider1.SetError(txtPrice, "Please enter price!");
            }
            else
            {
                errorProvider1.SetError(txtPrice, null);
                temp = true;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtProductName.Focus();
                errorProvider1.SetError(txtQuantity, "Please enter quantity!");
            }
            else
            {
                errorProvider1.SetError(txtQuantity, null);
                temp = true;

            }
            #endregion

            try
            {
                if (temp)
                {
                    if (url == "")
                    {
                        MessageBox.Show("Please Choose Your Image Product!", "Notification");
                        throw new Exception();
                    }
                    var brand_id = db.SearchedBrand(cbbBrandName.Text).Select(n => n.brand_id).Single();
                    var category_id = db.SearchedCategory(cbbCategoryName.Text).Select(n => n.category_id).Single();
                    byte[] img = null;
                    FileStream fs = new FileStream(url, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    db.InsertProduct(
                        txtProductName.Text,
                        brand_id, category_id,
                        decimal.Parse(txtPrice.Text),
                        int.Parse(txtQuantity.Text),
                        txtDpt.Text,
                        img
                        );
                    url = "";
                    LoadData();
                    Message.Show(this, "Product successfully added",Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                
            }
            catch(Exception)
            {
                Message.Show(this, "Failled to added product", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_brand.Show();
        }
    }
}
