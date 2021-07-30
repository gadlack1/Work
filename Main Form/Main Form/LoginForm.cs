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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            string loginUser = UserNameTextBox.Text;
            string PassUser = PasswdTextBox.Text;

            DataDitrix newDataDitrix = new DataDitrix();
            DataTable userTable = new DataTable();
            DataDitrixTableAdapters.AuthorizaTableAdapter authorizaTA = new DataDitrixTableAdapters.AuthorizaTableAdapter();

            authorizaTA.Fill(newDataDitrix.Authoriza);
            authorizaTA.Adapter.SelectCommand.CommandText = "SELECT Passwd FROM Authoriza WHERE (Passwd ='" + PasswdTextBox.Text + "') AND (Name='" + UserNameTextBox.Text + "')";
            authorizaTA.Fill(newDataDitrix.Authoriza);

            if (newDataDitrix.Authoriza.Rows.Count >0)
            {
                MessageBox.Show("Вы успешно зашли в учетную запись " + UserNameTextBox.Text, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable rightsTable = newDataDitrix.Authoriza;
                authorizaTA.Adapter.SelectCommand.CommandText = "SELECT Rights FROM Authoriza WHERE (Name = '" + UserNameTextBox.Text +
                    "') AND (Passwd= '" + PasswdTextBox.Text + "') AND (Rights = 'Администратор')";
                authorizaTA.Fill(newDataDitrix.Authoriza);

                if (newDataDitrix.Authoriza.Rows.Count > 0)
                {
                    LoginClass.AdminFlag = true;
                    LoginClass.LogOutUser = UserNameTextBox.Text;

                }
                else
                {
                    LoginClass.AdminFlag = false;
                    LoginClass.LogOutUser = UserNameTextBox.Text;
                }
                LoginClass.LSF = true;
                if (LoginClass.LSF == true)
                {
                    mainForm a = new mainForm();
                    a.Show();
                }


                this.Hide();
            }
            else
            {
                MessageBox.Show("Имя пользователя или пароль не верны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
