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
    public partial class UCProduct : UserControl
    {
        Form_ProductInfo fm = new Form_ProductInfo();
        public UCProduct()
        {
            InitializeComponent();
        }
        #region Properties

        private string _title;
        private string _price;
        private Image _image;


        public string Title
        {
            get { return _title; }
            set { _title = value; labelName.Text = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; labelPrice.Text = value; }
        }
        public Image Picture
        {
            get { return _image; }
            set { _image = value; Picbox.Image = value; }
        }


        #endregion

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void labelMoreDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            fm.Show(); 
        }
    }
}
