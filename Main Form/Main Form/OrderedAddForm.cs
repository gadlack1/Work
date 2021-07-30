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
    public partial class OrderedAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public DialogResult dialog;
        public bool Expect;
        public string FormHeader, OrderedProduct, OrderedPrice, OrderedKolVo, OrderedSale;
        public int OrderedEditID;

        public OrderedAddForm(string FormHeader, string OrderedProduct, string OrderedPrice, string OrderedKolVo, string OrderedSale, bool EditFlag, int OrderedEditID)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.OrderedProduct = OrderedProduct;
            this.OrderedPrice = OrderedPrice;
            this.OrderedKolVo = OrderedKolVo;
            this.OrderedSale = OrderedSale;
            this.EditFlag = EditFlag;
            this.OrderedEditID = OrderedEditID;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            OrderedAddForm.ActiveForm.Close();
        }

        private void OrderedAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void OrderedAddForm_Shown(object sender, EventArgs e)
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
            OrderedAddForm.ActiveForm.Text = FormHeader;
            ProductComboBox.Text = OrderedProduct;
            KolVoTextBox.Text = OrderedKolVo;
            PriceTextBox.Text = OrderedPrice;
            SaleTextBox.Text = OrderedSale;
            ProductComboBox.Focus();
            SuccessFlag = false;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (ProductComboBox.Text != "" && KolVoTextBox.Text != "" && PriceTextBox.Text != "" && SaleTextBox.Text != "")
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ProductTableAdapter productTA = new DataDitrixTableAdapters.ProductTableAdapter();
                productTA.Fill(newDataDitrix.Product);
                DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
                orderedTA.Fill(newDataDitrix.Ordered);

                DataTable productTable = newDataDitrix.Product;
                DataRow[] foundRowsProductType;
                productTA.Adapter.SelectCommand.CommandText = "SELECT Product_ID FROM Product INNER JOIN ProductType ON ProductType.ProductType_Type = '" + ProductComboBox.Text + "'" +
                    "WHERE Product.ProductType_ID = ProductType.ProductType_ID";
                productTA.Fill(newDataDitrix.Product);
                foundRowsProductType = productTable.Select();
                                
                try
                {
                    i = Convert.ToInt32(foundRowsProductType[0]["Product_ID"].ToString());
                    Expect = false;
                }
                catch
                {
                    dialog = MessageBox.Show("Продукции нет в наличии. Хотите добвить продукцию?", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    Expect = true;
                }

                if (Expect == true)
                {
                    if (dialog == DialogResult.OK)
                    {
                        ProductsAddForm products = new ProductsAddForm("Добавление нового товара", "", "", "", "", "", DateTime.Now, false, 0);
                        products.ShowDialog();
                    }
                    
                }
                else
                {
                        if (EditFlag == false)
                        {
                            orderedTA.Insert(Convert.ToInt32(PriceTextBox.Text), Convert.ToInt32(KolVoTextBox.Text), Convert.ToInt32(SaleTextBox.Text), i);
                        }
                        else
                        {
                            orderedTA.UpdateQuery(Convert.ToInt32(PriceTextBox.Text), Convert.ToInt32(KolVoTextBox.Text), Convert.ToInt32(SaleTextBox.Text), i, OrderedEditID);
                        }
                    SuccessFlag = true;
                    OrderedAddForm.ActiveForm.Close();
                }

                                
                //OrderedAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProductComboBox.Focus();
            }
        }
    }
}
