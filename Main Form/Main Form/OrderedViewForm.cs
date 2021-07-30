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
    public partial class OrderedViewForm : Form
    {
        public OrderedViewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            OrderedViewForm.ActiveForm.Close();
        }

        
        private void EditBtn_Click(object sender, EventArgs e)
        {
            OrderedAddForm orderedAdd = new OrderedAddForm("Редактирования заказано", OrderedDGV.CurrentRow.Cells[0].Value.ToString(), OrderedDGV.CurrentRow.Cells[2].Value.ToString(),
                OrderedDGV.CurrentRow.Cells[1].Value.ToString(), OrderedDGV.CurrentRow.Cells[3].Value.ToString(), true, Convert.ToInt32(OrderedDGV.CurrentRow.Cells[4].Value.ToString()));
            orderedAdd.ShowDialog();
        }

        private void OrderedDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void OrderedViewForm_Activated(object sender, EventArgs e)
        {
            OrderedDGV.Rows.Clear();

            DataDitrix newDataDitrix = new DataDitrix();
            DataTable orderedTable = newDataDitrix.Ordered;
            DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
            orderedTA.Fill(newDataDitrix.Ordered);
            orderedTA.Adapter.SelectCommand.CommandText = "SELECT Ordered.Ordered_Price, Ordered.Ordered_KolVo, Ordered.Ordered_Sale, Ordered.Ordered_ID, ProductType.ProductType_Type FROM Ordered " +
                "INNER JOIN Product ON Product.Product_ID = Ordered.Products_ID INNER JOIN ProductType ON Product.ProductType_ID = ProductType.ProductType_ID";
            orderedTA.Fill(newDataDitrix.Ordered);

            DataRow[] foundRowsOrdered = orderedTable.Select();
            foreach (DataRow rowOrdered in foundRowsOrdered)
            {
                OrderedDGV.Rows.Add(rowOrdered["ProductType_Type"].ToString(), rowOrdered["Ordered_KolVo"].ToString(), rowOrdered["Ordered_Price"].ToString(), rowOrdered["Ordered_Sale"].ToString(),
                    rowOrdered["Ordered_ID"].ToString());
            }
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(OrderedDGV.CurrentRow.Cells[4].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataTable orderedTable = newDataDitrix.Ordered;
                DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
                orderedTA.Fill(newDataDitrix.Ordered);
                orderedTA.DeleteQuery(delete);

                orderedTA.Fill(newDataDitrix.Ordered);
                orderedTA.Adapter.SelectCommand.CommandText = "SELECT Ordered.Ordered_Price, Ordered.Ordered_KolVo, Ordered.Ordered_Sale, Ordered.Ordered_ID, ProductType.ProductType_Type FROM Ordered " +
                "INNER JOIN Product ON Product.Product_ID = Ordered.Products_ID INNER JOIN ProductType ON Product.ProductType_ID = ProductType.ProductType_ID";
                orderedTA.Fill(newDataDitrix.Ordered);

                OrderedDGV.Rows.Clear();
                DataRow[] foundRowsOrdered = orderedTable.Select();
                foreach (DataRow rowOrdered in foundRowsOrdered)
                {
                    OrderedDGV.Rows.Add(rowOrdered["ProductType_Type"].ToString(), rowOrdered["Ordered_KolVo"].ToString(),
                        rowOrdered["Ordered_Price"].ToString(), rowOrdered["Ordered_Sale"].ToString(),
                        rowOrdered["Ordered_ID"].ToString());
                }

            }

        }

        private void OrderedViewForm_Shown_1(object sender, EventArgs e)
        {

            //DataDitrix newDataDitrix = new DataDitrix();
            //DataTable orderedTable = newDataDitrix.Ordered;
            //DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
            //orderedTA.Fill(newDataDitrix.Ordered);
            //orderedTA.Adapter.SelectCommand.CommandText = "SELECT Ordered.Ordered_Price, Ordered.Ordered_KolVo, Ordered.Ordered_Sale, Ordered.Ordered_ID, ProductType.ProductType_Type FROM Ordered " +
            //    "INNER JOIN Product ON Product.Product_ID = Ordered.Products_ID INNER JOIN ProductType ON Product.ProductType_ID = ProductType.ProductType_ID";
            //orderedTA.Fill(newDataDitrix.Ordered);

            //DataRow[] foundRowsOrdered = orderedTable.Select();
            //foreach (DataRow rowOrdered in foundRowsOrdered)
            //{
            //    OrderedDGV.Rows.Add(rowOrdered["ProductType_Type"].ToString(), rowOrdered["Ordered_KolVo"].ToString(), rowOrdered["Ordered_Price"].ToString(), rowOrdered["Ordered_Sale"].ToString(),
            //        rowOrdered["Ordered_ID"].ToString());
            //}
        }
    }
}
