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
    public partial class ProductsAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, Product, Warehourse, Price, MinStock, Unit;
        public DateTime ProductDate;
        public int EditID;

        public ProductsAddForm(string FormHeader, string Product, string Price, string Warehourse, string Unit, string MinStock, DateTime ProductDate, bool EditFlag, int EditID)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Product = Product;
            this.Price = Price;
            this.Warehourse = Warehourse;
            this.Unit = Unit;
            this.MinStock = MinStock;
            this.ProductDate = ProductDate;
            this.EditFlag = EditFlag;
            this.EditID = EditID;           
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ProductsAddForm.ActiveForm.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        { 
            int idProd = 0;
           

            if ((ProductComboBox.Text != "") && (WarehourseTextBox.Text != "") && (PriceTextBox.Text != "") && (MinStockTextBox.Text != "") && (UnitTextBox.Text != "") )
            {
               

                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ProductTableAdapter productTA = new DataDitrixTableAdapters.ProductTableAdapter();
                productTA.Fill(newDataDitrix.Product);
                DataDitrixTableAdapters.ProductTypeTableAdapter productTypeTA = new DataDitrixTableAdapters.ProductTypeTableAdapter();
                productTypeTA.Fill(newDataDitrix.ProductType);


                DataTable productTypeTable = newDataDitrix.ProductType;
                DataRow[] foundRowProductType;
                productTypeTA.Adapter.SelectCommand.CommandText = "SELECT ProductType_ID FROM ProductType WHERE ProductType_Type ='" + ProductComboBox.Text + "'";
                productTypeTA.Fill(newDataDitrix.ProductType);
                foundRowProductType = productTypeTable.Select();
                idProd = Convert.ToInt32(foundRowProductType[0]["ProductType_ID"].ToString());

                if (EditFlag == false)
                {
                    productTA.Insert(UnitTextBox.Text, Convert.ToInt32(PriceTextBox.Text), Convert.ToInt32(WarehourseTextBox.Text), ExpectedDTP.Value.Date, Convert.ToInt32(MinStockTextBox.Text), idProd);
                }
                else
                {
                    productTA.UpdateQuery(UnitTextBox.Text, Convert.ToInt32(PriceTextBox.Text), Convert.ToInt32(WarehourseTextBox.Text),
                        Convert.ToString(ExpectedDTP.Value.Date), Convert.ToInt32(MinStockTextBox.Text), idProd, EditID);
                }
               

                SuccessFlag = true;
                ProductsAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductComboBox.Focus();
            }
            
        }

        private void ProductsAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void ProductsAddForm_Shown(object sender, EventArgs e)
        {

            DataDitrix newDitrix = new DataDitrix();
            DataDitrixTableAdapters.ProductTypeTableAdapter productTypeTA = new DataDitrixTableAdapters.ProductTypeTableAdapter();
            productTypeTA.Fill(newDitrix.ProductType);

            DataTable productTypeTable = newDitrix.ProductType;
            DataRow[] foundRowsProduct;
            foundRowsProduct = productTypeTable.Select();
            foreach (DataRow rowProduct in foundRowsProduct)
            {
                ProductComboBox.Items.Add(rowProduct["ProductType_Type"].ToString());
            }

            ProductsAddForm.ActiveForm.Text = FormHeader;
            ProductComboBox.Text = Product;
            WarehourseTextBox.Text = Warehourse;
            PriceTextBox.Text = Price;
            MinStockTextBox.Text = MinStock;
            UnitTextBox.Text = Unit;
            ExpectedDTP.Value = ProductDate;
            ProductComboBox.Focus();
            SuccessFlag = false;
        }

    }
}
