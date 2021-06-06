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
    public partial class Form_Staff : Form
    {
        public Form_Staff()
        {
            InitializeComponent();
        }
        GearStoreEntities db = new GearStoreEntities();
        public void LoadData()
        {
            var data = db.Staffs.Select(n => n);
            dgv.DataSource = data.ToList();
        }

        private void Form_Staff_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
