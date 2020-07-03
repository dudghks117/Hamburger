using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniproject_Hamburger
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Dock = DockStyle.Fill;
            order.MdiParent = this;

            order.Show();
        }

        public static void newOrder(int orderID)
        {

        }
    }
}
