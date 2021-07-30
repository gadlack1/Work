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
    public partial class ProductViewForm : Form
    {
        public ProductViewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ProductViewForm.ActiveForm.Close();
        }

        //private void ProductViewForm_Shown(object sender, EventArgs e)
        //{
        //    DataDitrix newDataDitrix = new DataDitrix();
        //    DataTable productTable = newDataDitrix.Product;
        //    DataDitrixTableAdapters.ProductTableAdapter productTA = new DataDitrixTableAdapters.ProductTableAdapter();
        //    productTA.Fill(newDataDitrix.Product);
        //    productTA.Adapter.SelectCommand.CommandText = "SELECT Product.Product_Unit, Product.Product_Price, Product.Product_Warehourse, Product.Product_Expected, Product.Product_MinStock," +
        //        "Product.Product_ID, ProductType.ProductType_Type FROM Product INNER JOIN ProductType ON  Product.ProductType_ID = ProductType.ProductType_ID";
        //    productTA.Fill(newDataDitrix.Product);

        //    DataRow[] foundRowsProduct = productTable.Select();
        //    foreach (DataRow rowProduct in foundRowsProduct)
        //    {
        //        ProductDGV.Rows.Add(rowProduct["ProductType_Type"].ToString(), rowProduct["Product_Price"].ToString(), rowProduct["Product_Warehourse"].ToString(), rowProduct["Product_Unit"].ToString(),
        //            rowProduct["Product_MinStock"].ToString(), rowProduct["Product_Expected"].ToString(), rowProduct["Product_ID"].ToString());
        //    }
        //}

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DateTime onlyDate = DateTime.Parse(ProductDGV.CurrentRow.Cells[5].Value.ToString());
            ProductsAddForm productsAdd = new ProductsAddForm("Редактирования данных о продукте", ProductDGV.CurrentRow.Cells[0].Value.ToString(), ProductDGV.CurrentRow.Cells[1].Value.ToString(),
                ProductDGV.CurrentRow.Cells[2].Value.ToString(), ProductDGV.CurrentRow.Cells[3].Value.ToString(), ProductDGV.CurrentRow.Cells[4].Value.ToString(), onlyDate, true,
                Convert.ToInt32(ProductDGV.CurrentRow.Cells[6].Value.ToString()));
            productsAdd.ShowDialog();
        }

        private void ProductDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void ProductViewForm_Activated(object sender, EventArgs e)
        {
            ProductDGV.Rows.Clear();

            DateTime Expected;

            DataDitrix newDataDitrix = new DataDitrix();
            DataTable productTable = newDataDitrix.Product;
            DataDitrixTableAdapters.ProductTableAdapter productTA = new DataDitrixTableAdapters.ProductTableAdapter();
            productTA.Fill(newDataDitrix.Product);
            productTA.Adapter.SelectCommand.CommandText = "SELECT Product.Product_Unit, Product.Product_Price, Product.Product_Warehourse, Product.Product_Expected, Product.Product_MinStock," +
                "Product.Product_ID, ProductType.ProductType_Type FROM Product INNER JOIN ProductType ON  Product.ProductType_ID = ProductType.ProductType_ID";
            productTA.Fill(newDataDitrix.Product);

            DataRow[] foundRowsProduct = productTable.Select();
            foreach (DataRow rowProduct in foundRowsProduct)
            {
                Expected = DateTime.Parse(rowProduct["Product_Expected"].ToString());
                ProductDGV.Rows.Add(rowProduct["ProductType_Type"].ToString(), rowProduct["Product_Price"].ToString(), rowProduct["Product_Warehourse"].ToString(), rowProduct["Product_Unit"].ToString(),
                    rowProduct["Product_MinStock"].ToString(), Expected.ToShortDateString(), rowProduct["Product_ID"].ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(ProductDGV.CurrentRow.Cells[6].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                

                DateTime Expected;

                DataDitrix newDataDitrix = new DataDitrix();
                DataTable productTable = newDataDitrix.Product;
                DataDitrixTableAdapters.ProductTableAdapter productTA = new DataDitrixTableAdapters.ProductTableAdapter();
                productTA.Fill(newDataDitrix.Product);
                productTA.DeleteQuery(delete);
                productTA.Fill(newDataDitrix.Product);

                productTA.Adapter.SelectCommand.CommandText = "SELECT Product.Product_Unit, Product.Product_Price, Product.Product_Warehourse, Product.Product_Expected, Product.Product_MinStock," +
                    "Product.Product_ID, ProductType.ProductType_Type FROM Product INNER JOIN ProductType ON  Product.ProductType_ID = ProductType.ProductType_ID";
                productTA.Fill(newDataDitrix.Product);

                ProductDGV.Rows.Clear();
                DataRow[] foundRowsProduct = productTable.Select();
                foreach (DataRow rowProduct in foundRowsProduct)
                {
                    Expected = DateTime.Parse(rowProduct["Product_Expected"].ToString());
                    ProductDGV.Rows.Add(rowProduct["ProductType_Type"].ToString(), rowProduct["Product_Price"].ToString(), rowProduct["Product_Warehourse"].ToString(), rowProduct["Product_Unit"].ToString(),
                        rowProduct["Product_MinStock"].ToString(), Expected.ToShortDateString(), rowProduct["Product_ID"].ToString());
                }
            }
        }
    }
}
