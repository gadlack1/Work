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
    public partial class ClientAddForm : Form
    {
        public bool SuccessFlag, EditFlag;
        public string FormHeader, ClientFIO, ClientCity, ClientAddress, ClientNumber;

        public ClientAddForm(string FormHeader, string ClientFIO, string ClientCity, string ClientAddress, string ClientNumber, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.ClientFIO = ClientFIO;
            this.ClientCity = ClientCity;
            this.ClientAddress = ClientAddress;
            this.ClientNumber = ClientNumber;
            this.EditFlag = EditFlag;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if ((FIOClientTextBox.Text !="") && (CityClientTextBox.Text !="") && (AddressClientTextBox.Text !="") && (NumberClientTextBox.Text !=""))
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ClientTableAdapter clientTA = new DataDitrixTableAdapters.ClientTableAdapter();
                clientTA.Fill(newDataDitrix.Client);
                if (EditFlag == false)
                {
                    clientTA.Insert(FIOClientTextBox.Text, CityClientTextBox.Text, AddressClientTextBox.Text, NumberClientTextBox.Text);
                }
                else
                {
                    clientTA.UpdateQuery(FIOClientTextBox.Text, CityClientTextBox.Text, AddressClientTextBox.Text, NumberClientTextBox.Text,
                        ClientFIO, ClientCity, ClientAddress, ClientNumber);
                }
                SuccessFlag = true;
                ClientAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FIOClientTextBox.Focus();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ClientAddForm.ActiveForm.Close();
        }

        private void ClientAddForm_Shown(object sender, EventArgs e)
        {
            FIOClientTextBox.Text = ClientFIO;
            CityClientTextBox.Text = ClientCity;
            AddressClientTextBox.Text = ClientAddress;
            NumberClientTextBox.Text = ClientNumber;
            ClientAddForm.ActiveForm.Text = FormHeader;
            FIOClientTextBox.Focus();
            SuccessFlag = false;
        }

        private void ClientAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }
    }
}
