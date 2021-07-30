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
    public partial class ClientViewForm : Form
    {
        public ClientViewForm()
        {
            InitializeComponent();
        }

        private void ClientViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDitrix.Client". При необходимости она может быть перемещена или удалена.
           // this.clientTableAdapter.Fill(this.dataDitrix.Client);

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            ClientViewForm.ActiveForm.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ClientAddForm clientAdd = new ClientAddForm("Редактирование данных о клиенте", ClientDGV.CurrentRow.Cells[0].Value.ToString(), ClientDGV.CurrentRow.Cells[1].Value.ToString(),
                ClientDGV.CurrentRow.Cells[2].Value.ToString(), ClientDGV.CurrentRow.Cells[3].Value.ToString(), true);
            clientAdd.ShowDialog();
        }

        private void ClientDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void ClientViewForm_Activated(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.dataDitrix.Client);
            if (LoginClass.AdminFlag == false)
            {
                EditBtn.Visible = false;
                DeleteBtn.Visible = false;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(ClientDGV.CurrentRow.Cells[4].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись, " +
                "а так же все связанные с ней записи в других таблицах?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.ClientTableAdapter clientTA = new DataDitrixTableAdapters.ClientTableAdapter();
                clientTA.DeleteQuery(delete);
            }
        }
    }
}
