namespace Main_Form
{
    partial class OrdersAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePlacementsDTP = new System.Windows.Forms.DateTimePicker();
            this.DateVersionsDTP = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DeliveryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OrderedComboBox = new System.Windows.Forms.ComboBox();
            this.StaffComboBox = new System.Windows.Forms.ComboBox();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата размещения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата исполнения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Доставка";
            // 
            // DatePlacementsDTP
            // 
            this.DatePlacementsDTP.Location = new System.Drawing.Point(275, 25);
            this.DatePlacementsDTP.Name = "DatePlacementsDTP";
            this.DatePlacementsDTP.Size = new System.Drawing.Size(200, 20);
            this.DatePlacementsDTP.TabIndex = 5;
            // 
            // DateVersionsDTP
            // 
            this.DateVersionsDTP.Location = new System.Drawing.Point(275, 83);
            this.DateVersionsDTP.Name = "DateVersionsDTP";
            this.DateVersionsDTP.Size = new System.Drawing.Size(200, 20);
            this.DateVersionsDTP.TabIndex = 6;
            // 
            // DeliveryDTP
            // 
            this.DeliveryDTP.Location = new System.Drawing.Point(275, 146);
            this.DeliveryDTP.Name = "DeliveryDTP";
            this.DeliveryDTP.Size = new System.Drawing.Size(200, 20);
            this.DeliveryDTP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Стоимость доставки";
            // 
            // DeliveryTextBox
            // 
            this.DeliveryTextBox.Location = new System.Drawing.Point(142, 209);
            this.DeliveryTextBox.Name = "DeliveryTextBox";
            this.DeliveryTextBox.Size = new System.Drawing.Size(200, 20);
            this.DeliveryTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Код заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сотрудник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Клиент";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(15, 262);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 16;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(399, 262);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // OrderedComboBox
            // 
            this.OrderedComboBox.FormattingEnabled = true;
            this.OrderedComboBox.Location = new System.Drawing.Point(12, 25);
            this.OrderedComboBox.Name = "OrderedComboBox";
            this.OrderedComboBox.Size = new System.Drawing.Size(201, 21);
            this.OrderedComboBox.TabIndex = 18;
            // 
            // StaffComboBox
            // 
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.Location = new System.Drawing.Point(12, 83);
            this.StaffComboBox.Name = "StaffComboBox";
            this.StaffComboBox.Size = new System.Drawing.Size(201, 21);
            this.StaffComboBox.TabIndex = 19;
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(12, 146);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(201, 21);
            this.ClientComboBox.TabIndex = 20;
            // 
            // OrdersAddForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(501, 304);
            this.Controls.Add(this.ClientComboBox);
            this.Controls.Add(this.StaffComboBox);
            this.Controls.Add(this.OrderedComboBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeliveryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeliveryDTP);
            this.Controls.Add(this.DateVersionsDTP);
            this.Controls.Add(this.DatePlacementsDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersAddForm_FormClosing);
            this.Shown += new System.EventHandler(this.OrdersAddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePlacementsDTP;
        private System.Windows.Forms.DateTimePicker DateVersionsDTP;
        private System.Windows.Forms.DateTimePicker DeliveryDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeliveryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ComboBox OrderedComboBox;
        private System.Windows.Forms.ComboBox StaffComboBox;
        private System.Windows.Forms.ComboBox ClientComboBox;
    }
}