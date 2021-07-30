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
    public partial class OrdersAddForm : Form
    {
        public bool SuccessFlag, OrdersEditFlag;

        public string FormHeader, FIOClient, FIOStaff;
        public int EditID, KodZakaza;
        public float DeliveryCost;
        public DateTime DatePlacements, DateVersions, DateDelivery;

        public OrdersAddForm(string FormHeader, int KodZakaza, string FIOClient, float DeliveryCost, DateTime DatePlacements, DateTime DateVersions, DateTime DateDelivery, string FIOStaff, bool OrdersEditFlag, int EditID)
        {
            InitializeComponent();
            this.FormHeader = FormHeader;
            this.KodZakaza = KodZakaza;
            this.FIOClient = FIOClient;
            this.DeliveryCost = DeliveryCost;
            this.DatePlacements = DatePlacements;
            this.DateVersions = DateVersions;
            this.DateDelivery = DateDelivery;
            this.FIOStaff = FIOStaff;
            this.OrdersEditFlag = OrdersEditFlag;
            this.EditID = EditID;
        }

        private void OrdersAddForm_Shown(object sender, EventArgs e)
        {
            DataDitrix newDataDitrix = new DataDitrix();

            DataDitrixTableAdapters.ClientTableAdapter clientTA = new DataDitrixTableAdapters.ClientTableAdapter();
            clientTA.Fill(newDataDitrix.Client);
            DataDitrixTableAdapters.StaffTableAdapter staffTA = new DataDitrixTableAdapters.StaffTableAdapter();
            staffTA.Fill(newDataDitrix.Staff);
            DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
            orderedTA.Fill(newDataDitrix.Ordered);

            DataTable clientTable = newDataDitrix.Client;
            DataRow[] foundRowClient;
            foundRowClient = clientTable.Select();
            foreach(DataRow rowClient in foundRowClient)
            {
                ClientComboBox.Items.Add(rowClient["Client_FIO"].ToString());
            }

            DataTable staffTable = newDataDitrix.Staff;
            DataRow[] foundRowStaff;
            foundRowStaff = staffTable.Select();
            foreach (DataRow rowStaff in foundRowStaff)
            {
                StaffComboBox.Items.Add(rowStaff["Staff_FIO"].ToString());
            }

            DataTable orderedTable = newDataDitrix.Ordered;
            DataRow[] foundRowOrdered;
            foundRowOrdered = orderedTable.Select();
            foreach (DataRow rowOrdered in foundRowOrdered)
            {
                OrderedComboBox.Items.Add(rowOrdered["Ordered_ID"].ToString());
            }
            OrdersAddForm.ActiveForm.Text = FormHeader;
            OrderedComboBox.Text = Convert.ToString(KodZakaza);
            StaffComboBox.Text = FIOStaff;
            ClientComboBox.Text = FIOClient;
            DeliveryTextBox.Text = Convert.ToString(DeliveryCost);
            DatePlacementsDTP.Value = DatePlacements;
            DateVersionsDTP.Value = DateVersions;
            DeliveryDTP.Value = DateDelivery;
            OrderedComboBox.Focus();
            SuccessFlag = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            OrderedAddForm.ActiveForm.Close();
        }

        private void OrdersAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SuccessFlag == false)
            {
                DialogResult result = MessageBox.Show("Выйти без сохранения?", "Вопрос",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) { e.Cancel = true; }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            int client = 0, staff = 0, ordered = 0;
            if (OrderedComboBox.Text != "" && StaffComboBox.Text !="" && ClientComboBox.Text !="")
            {
                DataDitrix newDataDitrix = new DataDitrix();

                DataDitrixTableAdapters.ClientTableAdapter clientTA = new DataDitrixTableAdapters.ClientTableAdapter();
                clientTA.Fill(newDataDitrix.Client);
                DataDitrixTableAdapters.StaffTableAdapter staffTA = new DataDitrixTableAdapters.StaffTableAdapter();
                staffTA.Fill(newDataDitrix.Staff);
                DataDitrixTableAdapters.OrderedTableAdapter orderedTA = new DataDitrixTableAdapters.OrderedTableAdapter();
                orderedTA.Fill(newDataDitrix.Ordered);
                DataDitrixTableAdapters.OrdersTableAdapter ordersTA = new DataDitrixTableAdapters.OrdersTableAdapter();
                ordersTA.Fill(newDataDitrix.Orders);

                DataTable clientTable = newDataDitrix.Client;
                DataRow[] foundRowClient;
                clientTA.Adapter.SelectCommand.CommandText = "SELECT Client_ID FROM Client WHERE Client_FIO='" + ClientComboBox.Text + "'";
                clientTA.Fill(newDataDitrix.Client);
                foundRowClient = clientTable.Select();
                client = Convert.ToInt32(foundRowClient[0]["Client_ID"].ToString());

                DataTable staffTable = newDataDitrix.Staff;
                DataRow[] foundRowStaff;
                staffTA.Adapter.SelectCommand.CommandText = "SELECT Staff_ID From Staff WHERE Staff_FIO='" + StaffComboBox.Text + "'";
                staffTA.Fill(newDataDitrix.Staff);
                foundRowStaff = staffTable.Select();
                staff = Convert.ToInt32(foundRowStaff[0]["Staff_ID"].ToString());

                DataTable orderedTable = newDataDitrix.Ordered;
                DataRow[] foundRowOrdered;
                ordersTA.Adapter.SelectCommand.CommandText = "SELECT Ordered_ID FROM Ordered WHERE Ordered_ID='" + OrderedComboBox.Text + "'";
                orderedTA.Fill(newDataDitrix.Ordered);
                foundRowOrdered = orderedTable.Select();
                ordered = Convert.ToInt32(foundRowOrdered[0]["Ordered_ID"].ToString());

                if(OrdersEditFlag == false)
                {
                    ordersTA.Insert(DatePlacementsDTP.Value.Date, DateVersionsDTP.Value.Date, DeliveryDTP.Value.Date, Convert.ToInt32(DeliveryTextBox.Text), client, staff, ordered);
                }
                else
                {
                    ordersTA.UpdateQuery(DatePlacementsDTP.Value.Date.ToString(), DateVersionsDTP.Value.Date.ToString(), DeliveryDTP.Value.Date.ToString(),
                        Convert.ToInt32(DeliveryTextBox.Text), client, staff, ordered, EditID);
                }
                

                SuccessFlag = true;
                OrdersAddForm.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OrderedComboBox.Focus();
            }
        }
    }
}
