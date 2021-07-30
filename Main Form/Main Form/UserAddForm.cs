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
    public partial class UserAddForm : Form
    {
        public bool SuccessFlag;

        public UserAddForm()
        {
            InitializeComponent();
            RightsComboBox.Text = "----Выберите из списка----";
           // RightsComboBox.Text = "Пользователь";
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            UserAddForm.ActiveForm.Close();
        }

        private void UserAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти не создавая пользователя?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                { e.Cancel = true; }
            }
        }

        private void UserAddForm_Load(object sender, EventArgs e)
        {
            RightsComboBox.Items.Add("Администратор");
            RightsComboBox.Items.Add("Пользователь");
        }

        private void UserAddForm_Shown(object sender, EventArgs e)
        {
            UserTextBox.Text = "";
            PasswdTextBox.Text = "";
            UserTextBox.Focus();
            SuccessFlag = false;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text !="" && PasswdTextBox.Text !="" && RightsComboBox.Text != "----Выберите из списка----")
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.AuthorizaTableAdapter authorizaTA = new DataDitrixTableAdapters.AuthorizaTableAdapter();
                authorizaTA.Fill(newDataDitrix.Authoriza);

                authorizaTA.Insert(UserTextBox.Text, PasswdTextBox.Text, RightsComboBox.Text);

                SuccessFlag = true;
                UserAddForm.ActiveForm.Close();
            }

        }
    }
}
