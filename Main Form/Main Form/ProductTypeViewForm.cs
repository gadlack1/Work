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
    public partial class ProductTypeViewForm : Form
    {
        public ProductTypeViewForm()
        {
            InitializeComponent();
        }

        private void ProductTypeViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDitrix.ProductType". При необходимости она может быть перемещена или удалена.
            //this.productTypeTableAdapter.Fill(this.dataDitrix.ProductType);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ProductTypeViewForm.ActiveForm.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProductTypeAddForm productTypeAdd = new ProductTypeAddForm("Редактирования вида продукции", ProductTypeDGV.CurrentRow.Cells[0].Value.ToString(), ProductTypeDGV.CurrentRow.Cells[1].Value.ToString(), true);
            productTypeAdd.ShowDialog();
        }

        private void ProductTypeDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void ProductTypeViewForm_Activated(object sender, EventArgs e)
        {
            this.productTypeTableAdapter.Fill(this.dataDitrix.ProductType);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(ProductTypeDGV.CurrentRow.Cells[2].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись, " +
                "а так же все связанные с ней записи в других таблицах?", "Вопрос?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ProductTypeTableAdapter productTypeTA = new DataDitrixTableAdapters.ProductTypeTableAdapter();
                productTypeTA.DeleteQuery(delete);
            }
        }
    }
}
