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
    public partial class ProductTypeAddForm : Form
    {
        public bool SuccessFlag,EditFlag;
        public string FormHeader, Type, Description;

        public ProductTypeAddForm(string FormHeader, string Type, string Description, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.Type = Type;
            this.Description = Description;
            this.EditFlag = EditFlag;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ProductTypeAddForm.ActiveForm.Close();
        }

        private void ProductTypeAddForm_Shown(object sender, EventArgs e)
        {
            TypeTextBox.Text = Type;
            DescriptionRichTextBox.Text = Description;
            ProductTypeAddForm.ActiveForm.Text = FormHeader;
            TypeTextBox.Focus();
            SuccessFlag = false;
        }

        private void ProductTypeAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (TypeTextBox.Text !="" )
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ProductTypeTableAdapter productTypeTA = new DataDitrixTableAdapters.ProductTypeTableAdapter();
                productTypeTA.Fill(newDataDitrix.ProductType);
                if (EditFlag == false)
                {
                    productTypeTA.Insert(TypeTextBox.Text, DescriptionRichTextBox.Text);
                }
                else
                {
                    productTypeTA.UpdateQuery(TypeTextBox.Text, DescriptionRichTextBox.Text, Type, Description);
                }
                    
                SuccessFlag = true;
                ProductTypeAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Поле 'Вид продукции' должно быть заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TypeTextBox.Focus();
            }
        }
    }
}
