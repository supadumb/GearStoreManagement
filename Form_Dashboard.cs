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
        GearStoreEntities db = new GearStoreEntities();
        private double GetRevenue(int op,DateTime dt) //1: Day, 2: Month, 3: Year, 4: All
        {

            double sum = 0;
            if (op == 1)
            {
                string d = dt.ToString("yyyy-MM-dd");
                sum = (double)db.Orders.Where(n => n.order_date.ToString() == d).Sum(n=>n.total_amount);
                return sum;
            }
            else if (op == 2)
            {
                sum = (double)db.Orders.Where(n => n.order_date.Month == dt.Month && n.order_date.Year == dt.Year).Sum(n => n.total_amount);
                return sum;
            }
            else if (op==3)
            {
                sum = (double)db.Orders.Where(n=>n.order_date.Year == dt.Year).Sum(n => n.total_amount);
                return sum;
            }
            else
            {
                sum = (double)db.Orders.Sum(n => n.total_amount);
                return sum;
            }
        }
        private int GetOrder(int op, DateTime dt) //1: Day, 2: Month, 3: Year
        {
            int sum = 0;
            if (op == 1)
            {
                string d = dt.ToString("yyyy-MM-dd");
                sum = db.Orders.Where(n => n.order_date.ToString() == d).Count();
                return sum;
            }
            else if (op == 2)
            {
                sum = db.Orders.Where(n => n.order_date.Month == dt.Month && n.order_date.Year == dt.Year).Count() ;
                return sum;
            }
            else if (op==3)
            {
                sum = db.Orders.Where(n => n.order_date.Year == dt.Year).Count() ;
                return sum;
            }
            else
            {
                sum = db.Orders.Count();
                return sum;
            }
        }
        private void OrderHistoty()
        {
            var orh = db.Orders.Select(n => new
            {
                Date = n.order_date,
                Customer = n.customer_id,
                Amount = n.number_of_items,
                Money = n.total_amount
            });
            dgv.DataSource = orh.ToList();
        }
        private void GetChart()
        {
            DateTime dt = DateTime.Now.AddDays(-(int)DateTime.Today.DayOfWeek);
            DateTime dtendweek = dt.AddDays(6);
            string d = dt.ToString("yyyy-MM-dd");
            string d1 = dtendweek.ToString("yyyy-MM-dd");
            var data = db.Orders.Where(n => n.order_date.Month==dt.Month && n.order_date.Year==dt.Year && n.order_date.Day>=dt.Day && n.order_date.Day<=dtendweek.Day)
                .GroupBy(n => n.order_date).Select(n => new
            {
                date = n.OrderBy(x => x.order_date),
                total = n.Sum(x=>x.total_amount),
                sl = n.Count()
            });

            doughnut_revenue.Data = data.Select(n => n.total).ToList().ConvertAll(a => double.Parse(a.ToString()));
            barchar_order.Data = data.Select(n=>n.sl).ToList().ConvertAll(a=>double.Parse(a.ToString()));
            
        }

        public void LoadDashboard()
        {
            btnday.PerformClick();
            OrderHistoty();

            GetChart();
            chart_order.Labels = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            chart_revenue.Labels = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        }
        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnday_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;                  //date now
            DateTime dtp = DateTime.Now.AddDays(-1);    //pass date
            txtorder.Text = GetOrder(1, dt).ToString();
            int ornnow = GetOrder(1, dt);
            int orpass = GetOrder(1, dtp);
            if (orpass != 0)
            {
                txtper_order.Text = ((double)((ornnow - orpass) / orpass) * 100).ToString() + "%";
            }
            else if (ornnow == 0) txtper_order.Text = "0%";
            else txtper_order.Text = "100%";

            if (ornnow != 0)
                txtrevenue.Text = GetRevenue(1, dt).ToString();
            else txtrevenue.Text = "0";
            if (orpass != 0 && ornnow != 0)
                txtper_revenue.Text = (((GetRevenue(1, dt) - GetRevenue(1, dtp)) / GetRevenue(1, dtp)) * 100).ToString() + "%";
            else if (ornnow == 0) txtper_revenue.Text = "0%";
            else txtper_revenue.Text = "100%";
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;                  //date now
            DateTime dtp = DateTime.Now.AddMonths(-1);    //pass date
            txtorder.Text = GetOrder(2, dt).ToString();
            int ornnow = GetOrder(2, dt);
            int orpass = GetOrder(2, dtp);
            if (orpass != 0)
            {
                txtper_order.Text = ((double)((ornnow - orpass) / orpass) * 100).ToString() + "%";
            }
            else if (ornnow == 0) txtper_order.Text = "0%";
            else txtper_order.Text = "100%";

            if (ornnow != 0)
                txtrevenue.Text = GetRevenue(2, dt).ToString();
            else txtrevenue.Text = "0";
            if (orpass != 0 && ornnow != 0)
                txtper_revenue.Text = (((GetRevenue(2, dt) - GetRevenue(2, dtp)) / GetRevenue(2, dtp)) * 100).ToString() + "%";
            else if (ornnow == 0) txtper_revenue.Text = "0%";
            else txtper_revenue.Text = "100%";
        }

        private void btnyear_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;                  //date now
            DateTime dtp = DateTime.Now.AddYears(-1);    //pass date
            txtorder.Text = GetOrder(3, dt).ToString();
            int ornnow = GetOrder(3, dt);
            int orpass = GetOrder(3, dtp);
            if (orpass != 0)
            {
                txtper_order.Text = ((double)((ornnow - orpass) / orpass) * 100).ToString() + "%";
            }
            else if (ornnow == 0) txtper_order.Text = "0%";
            else txtper_order.Text = "100%";

            if (ornnow != 0)
                txtrevenue.Text = GetRevenue(3, dt).ToString();
            else txtrevenue.Text = "0";
            if (orpass != 0 && ornnow != 0)
                txtper_revenue.Text = (((GetRevenue(3, dt) - GetRevenue(3, dtp)) / GetRevenue(3, dtp)) * 100).ToString() + "%";
            else if (ornnow == 0) txtper_revenue.Text = "0%";
            else txtper_revenue.Text = "100%";
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;                  //date now
            DateTime dtp = DateTime.Now.AddYears(-1);    //pass date
            txtorder.Text = GetOrder(4, dt).ToString();
            int ornnow = GetOrder(3, dt);
            int orpass = GetOrder(3, dtp);
            if (orpass != 0)
            {
                txtper_order.Text = ((double)((ornnow - orpass) / orpass) * 100).ToString() + "%";
            }
            else if (ornnow == 0) txtper_order.Text = "0%";
            else txtper_order.Text = "100%";

            if (ornnow != 0)
                txtrevenue.Text = GetRevenue(4, dt).ToString();
            else txtrevenue.Text = "0";
            if (orpass != 0 && ornnow != 0)
                txtper_revenue.Text = (((GetRevenue(3, dt) - GetRevenue(3, dtp)) / GetRevenue(3, dtp)) * 100).ToString() + "%";
            else if (ornnow == 0) txtper_revenue.Text = "0%";
            else txtper_revenue.Text = "100%";
        }
        
    }
}
