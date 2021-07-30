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
    public partial class StaffViewForm : Form
    {
       

        public StaffViewForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            StaffViewForm.ActiveForm.Close();
        }

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDitrix.Staff". При необходимости она может быть перемещена или удалена.
            //this.staffTableAdapter.Fill(this.dataDitrix.Staff);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            StaffAddForm staff = new StaffAddForm("Редактирование данных о сотруднике", StaffDGV.CurrentRow.Cells[0].Value.ToString(), StaffDGV.CurrentRow.Cells[1].Value.ToString(),
                StaffDGV.CurrentRow.Cells[2].Value.ToString(), StaffDGV.CurrentRow.Cells[3].Value.ToString(), StaffDGV.CurrentRow.Cells[4].Value.ToString(), true);
            staff.ShowDialog();
        }

        private void StaffDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditBtn_Click(sender, e);
        }

        private void StaffViewForm_Activated(object sender, EventArgs e)
        {
            this.staffTableAdapter.Fill(this.dataDitrix.Staff);
        }

        private void DeletBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(StaffDGV.CurrentRow.Cells[5].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись, " +
                "а так же все связанные с ней записи в других таблицах?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataDitrix newDataDitrix = new DataDitrix();
                DataDitrixTableAdapters.StaffTableAdapter staffTA = new DataDitrixTableAdapters.StaffTableAdapter();
                staffTA.DeleteQuery(delete);
            }
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
