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
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }
        public void LoadDashboard()
        {
            var r = new Random();
            List<int> data_revenue = new List<int>();
            data_revenue.Add(10);
            data_revenue.Add(20);
            data_revenue.Add(30);
            data_revenue.Add(40);
            data_revenue.Add(50);
            data_revenue.Add(60);
            data_revenue.Add(70);
            doughnut_revenue.Data = data_revenue.ConvertAll(a=> double.Parse(a.ToString()));
            doughnut_revenue.TargetCanvas = chart_revenue;
            chart_revenue.Labels = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            List<double> data_order = new List<double>();
            data_order.Add(10);
            data_order.Add(20);
            data_order.Add(30);
            data_order.Add(40);
            data_order.Add(50);
            data_order.Add(60);
            data_order.Add(70);
            barchar_order.Data = data_order;
            barchar_order.TargetCanvas = chart_order;
            chart_revenue.Labels = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }
    }
}
