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
    public partial class StaffAddForm : Form
    {
        public bool SuccessFlag, EditFlag;

        public string FormHeader, FIO, Dolg, Address, Number, Zp;

        public StaffAddForm(string FormHeader, string FIO, string Dolg, string Address, string Number, string Zp, bool EditFlag)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.FIO = FIO;
            this.Dolg = Dolg;
            this.Address = Address;
            this.Number = Number;
            this.Zp = Zp;
            this.EditFlag = EditFlag;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            StaffAddForm.ActiveForm.Close();
        }

        private void StaffAddForm_Shown(object sender, EventArgs e)
        {
            StaffAddForm.ActiveForm.Text = FormHeader;
            FIOtextBox.Text = FIO;
            DolgTextBox.Text = Dolg;
            AddressStaffTextBox.Text = Address;
            NumberStaffTextBox.Text = Number;
            ZPStaffTextBox.Text = Zp;
            FIOtextBox.Focus();
            SuccessFlag = false;
        }

        private void StaffAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if ((FIOtextBox.Text != "") && (DolgTextBox.Text !="") && (AddressStaffTextBox.Text != "") && (NumberStaffTextBox.Text != "") && (ZPStaffTextBox.Text!=""))
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.StaffTableAdapter staffTA = new DataDitrixTableAdapters.StaffTableAdapter();
                staffTA.Fill(newDataDitrix.Staff);
                if (EditFlag == false)
                {
                    staffTA.Insert(FIOtextBox.Text, DolgTextBox.Text, AddressStaffTextBox.Text, NumberStaffTextBox.Text, Convert.ToInt32(ZPStaffTextBox.Text));
                }
                else
                {
                    staffTA.UpdateQuery(FIOtextBox.Text, DolgTextBox.Text, AddressStaffTextBox.Text, NumberStaffTextBox.Text, Convert.ToInt32(ZPStaffTextBox.Text),
                        FIO, Dolg, Address, Number,Convert.ToInt32(Zp));
                }
                SuccessFlag = true;
                StaffAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FIOtextBox.Focus();
            }
        }
    }
}
