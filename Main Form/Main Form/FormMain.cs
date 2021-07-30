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
    public partial class mainForm : Form
    {
        public bool OrdersShowFlag = false, IsFind = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffAddForm staff = new StaffAddForm("Добавление нового сотрудника","","","","","",false);
            staff.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAddForm client = new ClientAddForm("Добавление нового клиента", "", "", "", "", false);
            client.ShowDialog();
        }

        private void добавитьВидПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductTypeAddForm productType = new ProductTypeAddForm("Добавление новой продукции", "", "", false);
            productType.ShowDialog();
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsAddForm products = new ProductsAddForm("Добавление нового товара", "", "", "", "", "", DateTime.Now, false, 0);
            products.ShowDialog();
        }

        private void добавитьЗаказаныеТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderedAddForm ordered = new OrderedAddForm("Добавление нового закано", "", "", "", "", false, 0);
            ordered.ShowDialog();
        }

        private void добавлениеЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersAddForm orders = new OrdersAddForm("Добавление нового заказа", 0, "", 0, DateTime.Now, DateTime.Now, DateTime.Now, "", false, 0);
            orders.ShowDialog();
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffViewForm viewStaff = new StaffViewForm();
            viewStaff.ShowDialog();
        }

        private void просмотретьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientViewForm clientView = new ClientViewForm();
            clientView.ShowDialog();
        }

        private void просмотретьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductTypeViewForm productTypeView = new ProductTypeViewForm();
            productTypeView.ShowDialog();
        }

        private void просмотретьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProductViewForm productView = new ProductViewForm();
            productView.ShowDialog();
        }

        private void просмотретьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OrderedViewForm orderedView = new OrderedViewForm();
            orderedView.ShowDialog();
        }

        private void просмотретьToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OrdersEditBtn.Top = mainForm.ActiveForm.Height - 100;
            OrdersDeleteBtn.Top = mainForm.ActiveForm.Height - 100;
            OrdersFindBtn.Top = mainForm.ActiveForm.Height - 100;
            OrdersCloseBtn.Top = mainForm.ActiveForm.Height - 100;
            

            //OrdersEditBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersDeleteBtn.Width / 2 - OrdersEditBtn.Width - 70;
            //OrdersDeleteBtn.Left = mainForm.ActiveForm.Width / 2 + OrdersDeleteBtn.Width + OrdersCloseBtn.Width / 2;
            OrdersDeleteBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersEditBtn.Width  - OrdersDeleteBtn.Width - 90;
            OrdersCloseBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersCloseBtn.Width - 30;
            OrdersFindBtn.Left = mainForm.ActiveForm.Width / 2 + 30;
            OrdersEditBtn.Left = mainForm.ActiveForm.Width / 2 + OrdersFindBtn.Width + 100;
            
            

            OrdersDGV.Width = mainForm.ActiveForm.Width - 40;
            OrdersDGV.Height = mainForm.ActiveForm.Height - 180;
            //OrdersCloseBtn.Top = mainForm.ActiveForm.Height - 100;
            //OrdersCloseBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersCloseBtn.Width / 2;
            OrdersDGV.Columns[0].Width = 100;
            OrdersDGV.Columns[2].Width = OrdersDGV.Width / 7 - 10;
            OrdersDGV.Columns[3].Width = OrdersDGV.Width / 7 - 15;
            OrdersDGV.Columns[4].Width = OrdersDGV.Width / 7 - 20;
            OrdersDGV.Columns[5].Width = OrdersDGV.Width / 7 - 25;
            OrdersDGV.Columns[6].Width = OrdersDGV.Width / 7 - 5;
            OrdersDGV.Columns[1].Width = OrdersDGV.Width - (OrdersDGV.Columns[0].Width + OrdersDGV.Columns[2].Width + OrdersDGV.Columns[3].Width + OrdersDGV.Columns[4].Width +
                OrdersDGV.Columns[5].Width + OrdersDGV.Columns[6].Width + 40);
            OrdersDGV.Rows.Clear();

            DateTime DatePlace, DateDelivery, DateVersion;

            DataDitrix newDataDitrix = new DataDitrix();
            DataTable ordersTable = newDataDitrix.Orders;
            DataDitrixTableAdapters.OrdersTableAdapter ordersTA = new DataDitrixTableAdapters.OrdersTableAdapter();
            ordersTA.Fill(newDataDitrix.Orders);
            ordersTA.Adapter.SelectCommand.CommandText = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost,"+
            "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
            "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID";
            ordersTA.Fill(newDataDitrix.Orders);

            DataRow[] foundRowsOrders = ordersTable.Select();
            foreach (DataRow rowOrders in foundRowsOrders)
            {
                DatePlace = DateTime.Parse(rowOrders["Orders_DataPlacements"].ToString());
                DateDelivery = DateTime.Parse(rowOrders["Orders_Delivery"].ToString());
                DateVersion = DateTime.Parse(rowOrders["Orders_DataVersions"].ToString());
                OrdersDGV.Rows.Add(rowOrders["Ordered_ID"].ToString(), rowOrders["Client_FIO"].ToString(), rowOrders["Orders_DeliveryCost"].ToString(), DatePlace.ToShortDateString(),
                    DateVersion.ToShortDateString(), DateDelivery.ToShortDateString(), rowOrders["Staff_FIO"].ToString(), rowOrders["Orders_ID"].ToString());
            }

            OrdersDGV.Visible = true;
            OrdersDeleteBtn.Visible = true;
            OrdersEditBtn.Visible = true;
            OrdersCloseBtn.Visible = true;
            OrdersFindBtn.Visible = true;
            OrdersShowFlag = true;
        }

        private void OrdersCloseBtn_Click(object sender, EventArgs e)
        {
            OrdersDGV.Visible = false;
            OrdersCloseBtn.Visible = false;
            OrdersEditBtn.Visible = false;
            OrdersDeleteBtn.Visible = false;
            OrdersFindBtn.Visible = false;
            OrdersShowFlag = false;
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (OrdersShowFlag == true)
            {
                OrdersEditBtn.Top = mainForm.ActiveForm.Height - 100;
                OrdersDeleteBtn.Top = mainForm.ActiveForm.Height - 100;
                OrdersFindBtn.Top = mainForm.ActiveForm.Height - 100;
                OrdersCloseBtn.Top = mainForm.ActiveForm.Height - 100;


                //OrdersEditBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersDeleteBtn.Width / 2 - OrdersEditBtn.Width - 70;
                //OrdersDeleteBtn.Left = mainForm.ActiveForm.Width / 2 + OrdersDeleteBtn.Width + OrdersCloseBtn.Width / 2;
                OrdersDeleteBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersEditBtn.Width - OrdersDeleteBtn.Width - 90;
                OrdersCloseBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersCloseBtn.Width - 30;
                OrdersFindBtn.Left = mainForm.ActiveForm.Width / 2 + 30;
                OrdersEditBtn.Left = mainForm.ActiveForm.Width / 2 + OrdersFindBtn.Width + 100;



                OrdersDGV.Width = mainForm.ActiveForm.Width - 40;
                OrdersDGV.Height = mainForm.ActiveForm.Height - 180;
                //OrdersCloseBtn.Top = mainForm.ActiveForm.Height - 100;
                //OrdersCloseBtn.Left = mainForm.ActiveForm.Width / 2 - OrdersCloseBtn.Width / 2;
                OrdersDGV.Columns[0].Width = 100;
                OrdersDGV.Columns[2].Width = OrdersDGV.Width / 7 - 10;
                OrdersDGV.Columns[3].Width = OrdersDGV.Width / 7 - 15;
                OrdersDGV.Columns[4].Width = OrdersDGV.Width / 7 - 20;
                OrdersDGV.Columns[5].Width = OrdersDGV.Width / 7 - 25;
                OrdersDGV.Columns[6].Width = OrdersDGV.Width / 7 - 5;
                OrdersDGV.Columns[1].Width = OrdersDGV.Width - (OrdersDGV.Columns[0].Width + OrdersDGV.Columns[2].Width + OrdersDGV.Columns[3].Width + OrdersDGV.Columns[4].Width +
                    OrdersDGV.Columns[5].Width + OrdersDGV.Columns[6].Width + 40);
                OrdersDGV.Rows.Clear();
            }
        }

        private void OrdersEditBtn_Click(object sender, EventArgs e)
        {
            DateTime placement, version, deliveryDate;

            placement = DateTime.Parse(OrdersDGV.CurrentRow.Cells[3].Value.ToString());
            version = DateTime.Parse(OrdersDGV.CurrentRow.Cells[4].Value.ToString());
            deliveryDate = DateTime.Parse(OrdersDGV.CurrentRow.Cells[5].Value.ToString());

            OrdersAddForm ordersAdd = new OrdersAddForm("Редактирование заказа", Convert.ToInt32(OrdersDGV.CurrentRow.Cells[0].Value.ToString()), OrdersDGV.CurrentRow.Cells[1].Value.ToString(),
                Convert.ToInt32(OrdersDGV.CurrentRow.Cells[2].Value.ToString()), placement, version, deliveryDate, OrdersDGV.CurrentRow.Cells[6].Value.ToString(),
                true,Convert.ToInt32(OrdersDGV.CurrentRow.Cells[7].Value.ToString()));
            ordersAdd.ShowDialog();
        }

        private void OrdersDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OrdersEditBtn_Click(sender, e);
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            if (OrdersShowFlag == true && IsFind == false)
            {
                OrdersDGV.Rows.Clear();

                DateTime DatePlace, DateDelivery, DateVersion;

                DataDitrix newDataDitrix = new DataDitrix();
                DataTable ordersTable = newDataDitrix.Orders;
                DataDitrixTableAdapters.OrdersTableAdapter ordersTA = new DataDitrixTableAdapters.OrdersTableAdapter();
                ordersTA.Fill(newDataDitrix.Orders);
                ordersTA.Adapter.SelectCommand.CommandText = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID";
                ordersTA.Fill(newDataDitrix.Orders);

                DataRow[] foundRowsOrders = ordersTable.Select();
                foreach (DataRow rowOrders in foundRowsOrders)
                {
                    DatePlace = DateTime.Parse(rowOrders["Orders_DataPlacements"].ToString());
                    DateDelivery = DateTime.Parse(rowOrders["Orders_Delivery"].ToString());
                    DateVersion = DateTime.Parse(rowOrders["Orders_DataVersions"].ToString());
                    OrdersDGV.Rows.Add(rowOrders["Ordered_ID"].ToString(), rowOrders["Client_FIO"].ToString(), rowOrders["Orders_DeliveryCost"].ToString(), DatePlace.ToShortDateString(),
                        DateVersion.ToShortDateString(), DateDelivery.ToShortDateString(), rowOrders["Staff_FIO"].ToString(), rowOrders["Orders_ID"].ToString());
                }
            }
        }

        private void OrdersFindBtn_Click(object sender, EventArgs e)
        {
            IsFind = true;
            OrdersFindForm findForm = new OrdersFindForm();
            findForm.ShowDialog();
            string FindQuery = findForm.QueryText;

            OrdersDGV.Rows.Clear();
            DateTime DatePlace, DateDelivery, DateVersion;

            DataDitrix newDataDitrix = new DataDitrix();
            DataTable ordersTable = newDataDitrix.Orders;
            DataDitrixTableAdapters.OrdersTableAdapter ordersTA = new DataDitrixTableAdapters.OrdersTableAdapter();

            ordersTA.Fill(newDataDitrix.Orders);
            ordersTA.Adapter.SelectCommand.CommandText = FindQuery;
            ordersTA.Fill(newDataDitrix.Orders);

            DataRow[] foundRowsOrders = ordersTable.Select();
            foreach (DataRow rowOrders in foundRowsOrders)
            {
                DatePlace = DateTime.Parse(rowOrders["Orders_DataPlacements"].ToString());
                DateDelivery = DateTime.Parse(rowOrders["Orders_Delivery"].ToString());
                DateVersion = DateTime.Parse(rowOrders["Orders_DataVersions"].ToString());
                OrdersDGV.Rows.Add(rowOrders["Ordered_ID"].ToString(), rowOrders["Client_FIO"].ToString(), rowOrders["Orders_DeliveryCost"].ToString(), DatePlace.ToShortDateString(),
                    DateVersion.ToShortDateString(), DateDelivery.ToShortDateString(), rowOrders["Staff_FIO"].ToString(), rowOrders["Orders_ID"].ToString());
            }
            IsFind = false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void выходИзПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LoginClass.LSF == true)
            {
                LoginForm log = new LoginForm();
                log.Show();

                LoginClass.LT = true;

                if (LoginClass.LT == true)
                {
                    this.Hide();
                    log.Show();
                }
            }
        }

        private void добавлениеПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAddForm userAdd = new UserAddForm();
            userAdd.ShowDialog();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            пользовательToolStripMenuItem.Text = LoginClass.LogOutUser;
        }

        private void OrdersDeleteBtn_Click(object sender, EventArgs e)
        {
            int delete = Convert.ToInt32(OrdersDGV.CurrentRow.Cells[7].Value.ToString());

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime DatePlace, DateDelivery, DateVersion;

                DataDitrix newDataDitrix = new DataDitrix();
                DataTable ordersTable = newDataDitrix.Orders;
                DataDitrixTableAdapters.OrdersTableAdapter ordersTA = new DataDitrixTableAdapters.OrdersTableAdapter();
                ordersTA.Fill(newDataDitrix.Orders);
                ordersTA.DeleteQuery(delete);

                ordersTA.Fill(newDataDitrix.Orders);
                ordersTA.Adapter.SelectCommand.CommandText = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID";
                ordersTA.Fill(newDataDitrix.Orders);

                OrdersDGV.Rows.Clear();
                DataRow[] foundRowsOrders = ordersTable.Select();
                foreach (DataRow rowOrders in foundRowsOrders)
                {
                    DatePlace = DateTime.Parse(rowOrders["Orders_DataPlacements"].ToString());
                    DateDelivery = DateTime.Parse(rowOrders["Orders_Delivery"].ToString());
                    DateVersion = DateTime.Parse(rowOrders["Orders_DataVersions"].ToString());
                    OrdersDGV.Rows.Add(rowOrders["Ordered_ID"].ToString(), rowOrders["Client_FIO"].ToString(), rowOrders["Orders_DeliveryCost"].ToString(), DatePlace.ToShortDateString(),
                        DateVersion.ToShortDateString(), DateDelivery.ToShortDateString(), rowOrders["Staff_FIO"].ToString(), rowOrders["Orders_ID"].ToString());
                }
            }
        }
    }
}
