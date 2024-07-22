using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21___Demo4___EntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //With using without waiting garbage collector, we are disposing the object from memory. This happens when block ended
            using (ECommerceContext context = new ECommerceContext())
            {
                dgwProducts.DataSource = context.Products.ToList();
            }
        }
    }
}
