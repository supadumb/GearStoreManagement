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
    public partial class Form_ProductInfo : Form
    {
        #region .data
        public string mode;
        bool mouseDown = false;
        private Point offset;
        string url;
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
            bunifuLabel2.Text = mode;
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
    }
}
