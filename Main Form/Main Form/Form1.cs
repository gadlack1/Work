using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffAddForm staff = new StaffAddForm();
            staff.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAddForm client = new ClientAddForm();
            client.ShowDialog();
        }

        private void добавитьВидПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductTypeAddForm productType = new ProductTypeAddForm();
            productType.ShowDialog();
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsAddForm products = new ProductsAddForm();
            products.ShowDialog();
        }

        private void добавитьЗаказаныеТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedAddForm ordered = new OrderedAddForm();
            ordered.ShowDialog();
        }
    }
}
