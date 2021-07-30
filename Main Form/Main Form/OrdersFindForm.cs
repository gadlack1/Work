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
    public partial class OrdersFindForm : Form
    {
        public OrdersFindForm()
        {
            InitializeComponent();
        }

        private string QueryTextValue;
        public string QueryText
        {
            get { return QueryTextValue; }
            set { QueryTextValue = value; }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            QueryText = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID";
            this.Close();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            string QueryForFind = "";

            if(FindTextBox.Text !="" && (OrderedRadioBtn.Checked == true || ClientFIORadioButton.Checked == true  || DatePlacementRadioButton.Checked == true || DateVersionRadioBtn.Checked == true ))
            {
                if (OrderedRadioBtn.Checked == true)
                {
                    QueryForFind = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID " +
                "WHERE Ordered.Ordered_ID LIKE '" + FindTextBox.Text + "'";
                }
                if (ClientFIORadioButton.Checked == true)
                {
                    QueryForFind = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID " +
                "WHERE Client.Client_FIO LIKE '" + FindTextBox.Text + "'";
                }
                if (DatePlacementRadioButton.Checked == true)
                {
                    QueryForFind = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                 "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                 "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID " +
                 "WHERE Orders.Orders_DataPlacements LIKE '" + FindTextBox.Text + "'";
                }
                if (DateVersionRadioBtn.Checked == true)
                {
                    QueryForFind = "SELECT Orders.Orders_DataPlacements,Orders.Orders_DataVersions,Orders.Orders_Delivery,Orders.Orders_DeliveryCost," +
                "Ordered.Ordered_ID, Client.Client_FIO,Staff.Staff_FIO, Orders.Orders_ID FROM Orders INNER JOIN Ordered ON Orders.Ordered_ID = Ordered.Ordered_ID " +
                "INNER JOIN Staff ON Orders.Staff_ID = Staff.Staff_ID INNER JOIN Client ON Orders.Client_ID = Client.Client_ID " +
                "WHERE Orders.Orders_DataVersions LIKE '" + FindTextBox.Text + "'";
                }
                QueryText = QueryForFind;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполнены или отмечены не все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FindTextBox.Focus();
            }
        }
    }
}
