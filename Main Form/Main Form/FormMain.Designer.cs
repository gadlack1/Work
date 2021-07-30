namespace Main_Form
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВидПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.заказаноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаказаныеТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.Ordred = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePlacements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVersions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersCloseBtn = new System.Windows.Forms.Button();
            this.OrdersEditBtn = new System.Windows.Forms.Button();
            this.OrdersDeleteBtn = new System.Windows.Forms.Button();
            this.OrdersFindBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.видПродукцииToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.заказаноToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.добавлениеПользователяToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // добавлениеПользователяToolStripMenuItem
            // 
            this.добавлениеПользователяToolStripMenuItem.Name = "добавлениеПользователяToolStripMenuItem";
            this.добавлениеПользователяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.добавлениеПользователяToolStripMenuItem.Text = "Добавление пользователя";
            this.добавлениеПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавлениеПользователяToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.просмотретьToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            this.добавитьСотрудникаToolStripMenuItem.Click += new System.EventHandler(this.добавитьСотрудникаToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem
            // 
            this.просмотретьToolStripMenuItem.Name = "просмотретьToolStripMenuItem";
            this.просмотретьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.просмотретьToolStripMenuItem.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem.Click += new System.EventHandler(this.просмотретьToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКлиентаToolStripMenuItem,
            this.просмотретьToolStripMenuItem1});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // добавитьКлиентаToolStripMenuItem
            // 
            this.добавитьКлиентаToolStripMenuItem.Name = "добавитьКлиентаToolStripMenuItem";
            this.добавитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.добавитьКлиентаToolStripMenuItem.Text = "Добавить клиента";
            this.добавитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьКлиентаToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem1
            // 
            this.просмотретьToolStripMenuItem1.Name = "просмотретьToolStripMenuItem1";
            this.просмотретьToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.просмотретьToolStripMenuItem1.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem1.Click += new System.EventHandler(this.просмотретьToolStripMenuItem1_Click);
            // 
            // видПродукцииToolStripMenuItem
            // 
            this.видПродукцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВидПродукцииToolStripMenuItem,
            this.просмотретьToolStripMenuItem2});
            this.видПродукцииToolStripMenuItem.Name = "видПродукцииToolStripMenuItem";
            this.видПродукцииToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.видПродукцииToolStripMenuItem.Text = "Вид продукции";
            // 
            // добавитьВидПродукцииToolStripMenuItem
            // 
            this.добавитьВидПродукцииToolStripMenuItem.Name = "добавитьВидПродукцииToolStripMenuItem";
            this.добавитьВидПродукцииToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.добавитьВидПродукцииToolStripMenuItem.Text = "Добавить вид продукции";
            this.добавитьВидПродукцииToolStripMenuItem.Click += new System.EventHandler(this.добавитьВидПродукцииToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem2
            // 
            this.просмотретьToolStripMenuItem2.Name = "просмотретьToolStripMenuItem2";
            this.просмотретьToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.просмотретьToolStripMenuItem2.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem2.Click += new System.EventHandler(this.просмотретьToolStripMenuItem2_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem,
            this.просмотретьToolStripMenuItem3});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить товар";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem3
            // 
            this.просмотретьToolStripMenuItem3.Name = "просмотретьToolStripMenuItem3";
            this.просмотретьToolStripMenuItem3.Size = new System.Drawing.Size(160, 22);
            this.просмотретьToolStripMenuItem3.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem3.Click += new System.EventHandler(this.просмотретьToolStripMenuItem3_Click);
            // 
            // заказаноToolStripMenuItem
            // 
            this.заказаноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказаныеТоварыToolStripMenuItem,
            this.просмотретьToolStripMenuItem4});
            this.заказаноToolStripMenuItem.Name = "заказаноToolStripMenuItem";
            this.заказаноToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.заказаноToolStripMenuItem.Text = "Заказано";
            // 
            // добавитьЗаказаныеТоварыToolStripMenuItem
            // 
            this.добавитьЗаказаныеТоварыToolStripMenuItem.Name = "добавитьЗаказаныеТоварыToolStripMenuItem";
            this.добавитьЗаказаныеТоварыToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьЗаказаныеТоварыToolStripMenuItem.Text = "Добавить заказаные товары";
            this.добавитьЗаказаныеТоварыToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказаныеТоварыToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem4
            // 
            this.просмотретьToolStripMenuItem4.Name = "просмотретьToolStripMenuItem4";
            this.просмотретьToolStripMenuItem4.Size = new System.Drawing.Size(228, 22);
            this.просмотретьToolStripMenuItem4.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem4.Click += new System.EventHandler(this.просмотретьToolStripMenuItem4_Click);
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеЗаказаToolStripMenuItem,
            this.просмотретьToolStripMenuItem5});
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.заказыToolStripMenuItem.Text = "Заказы";
            // 
            // добавлениеЗаказаToolStripMenuItem
            // 
            this.добавлениеЗаказаToolStripMenuItem.Name = "добавлениеЗаказаToolStripMenuItem";
            this.добавлениеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.добавлениеЗаказаToolStripMenuItem.Text = "Добавление заказа";
            this.добавлениеЗаказаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеЗаказаToolStripMenuItem_Click);
            // 
            // просмотретьToolStripMenuItem5
            // 
            this.просмотретьToolStripMenuItem5.Name = "просмотретьToolStripMenuItem5";
            this.просмотретьToolStripMenuItem5.Size = new System.Drawing.Size(178, 22);
            this.просмотретьToolStripMenuItem5.Text = "Просмотреть";
            this.просмотретьToolStripMenuItem5.Click += new System.EventHandler(this.просмотретьToolStripMenuItem5_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзПользователяToolStripMenuItem});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // выходИзПользователяToolStripMenuItem
            // 
            this.выходИзПользователяToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходИзПользователяToolStripMenuItem.Name = "выходИзПользователяToolStripMenuItem";
            this.выходИзПользователяToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.выходИзПользователяToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выходИзПользователяToolStripMenuItem.Text = "Выход из пользователя";
            this.выходИзПользователяToolStripMenuItem.Click += new System.EventHandler(this.выходИзПользователяToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AllowUserToDeleteRows = false;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordred,
            this.Client,
            this.DeliveryCost,
            this.DatePlacements,
            this.DateVersions,
            this.Delivery,
            this.Staff,
            this.ID});
            this.OrdersDGV.Location = new System.Drawing.Point(12, 36);
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.ReadOnly = true;
            this.OrdersDGV.RowHeadersWidth = 20;
            this.OrdersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDGV.Size = new System.Drawing.Size(923, 150);
            this.OrdersDGV.TabIndex = 1;
            this.OrdersDGV.Visible = false;
            this.OrdersDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersDGV_CellDoubleClick);
            // 
            // Ordred
            // 
            this.Ordred.HeaderText = "Код заказа";
            this.Ordred.Name = "Ordred";
            this.Ordred.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "ФИО клиента";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // DeliveryCost
            // 
            this.DeliveryCost.HeaderText = "Стоимость доставки";
            this.DeliveryCost.Name = "DeliveryCost";
            this.DeliveryCost.ReadOnly = true;
            // 
            // DatePlacements
            // 
            this.DatePlacements.HeaderText = "Дата размещения";
            this.DatePlacements.Name = "DatePlacements";
            this.DatePlacements.ReadOnly = true;
            // 
            // DateVersions
            // 
            this.DateVersions.HeaderText = "Дата исполнения";
            this.DateVersions.Name = "DateVersions";
            this.DateVersions.ReadOnly = true;
            // 
            // Delivery
            // 
            this.Delivery.HeaderText = "Дата доставки";
            this.Delivery.Name = "Delivery";
            this.Delivery.ReadOnly = true;
            // 
            // Staff
            // 
            this.Staff.HeaderText = "ФИО сотрудника";
            this.Staff.Name = "Staff";
            this.Staff.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // OrdersCloseBtn
            // 
            this.OrdersCloseBtn.Location = new System.Drawing.Point(12, 249);
            this.OrdersCloseBtn.Name = "OrdersCloseBtn";
            this.OrdersCloseBtn.Size = new System.Drawing.Size(75, 23);
            this.OrdersCloseBtn.TabIndex = 2;
            this.OrdersCloseBtn.Text = "Закрыть";
            this.OrdersCloseBtn.UseVisualStyleBackColor = true;
            this.OrdersCloseBtn.Visible = false;
            this.OrdersCloseBtn.Click += new System.EventHandler(this.OrdersCloseBtn_Click);
            // 
            // OrdersEditBtn
            // 
            this.OrdersEditBtn.Location = new System.Drawing.Point(136, 249);
            this.OrdersEditBtn.Name = "OrdersEditBtn";
            this.OrdersEditBtn.Size = new System.Drawing.Size(75, 23);
            this.OrdersEditBtn.TabIndex = 3;
            this.OrdersEditBtn.Text = "Изменить";
            this.OrdersEditBtn.UseVisualStyleBackColor = true;
            this.OrdersEditBtn.Visible = false;
            this.OrdersEditBtn.Click += new System.EventHandler(this.OrdersEditBtn_Click);
            // 
            // OrdersDeleteBtn
            // 
            this.OrdersDeleteBtn.Location = new System.Drawing.Point(262, 249);
            this.OrdersDeleteBtn.Name = "OrdersDeleteBtn";
            this.OrdersDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.OrdersDeleteBtn.TabIndex = 4;
            this.OrdersDeleteBtn.Text = "Удалить";
            this.OrdersDeleteBtn.UseVisualStyleBackColor = true;
            this.OrdersDeleteBtn.Visible = false;
            this.OrdersDeleteBtn.Click += new System.EventHandler(this.OrdersDeleteBtn_Click);
            // 
            // OrdersFindBtn
            // 
            this.OrdersFindBtn.Location = new System.Drawing.Point(386, 249);
            this.OrdersFindBtn.Name = "OrdersFindBtn";
            this.OrdersFindBtn.Size = new System.Drawing.Size(75, 23);
            this.OrdersFindBtn.TabIndex = 5;
            this.OrdersFindBtn.Text = "Поиск";
            this.OrdersFindBtn.UseVisualStyleBackColor = true;
            this.OrdersFindBtn.Visible = false;
            this.OrdersFindBtn.Click += new System.EventHandler(this.OrdersFindBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.OrdersFindBtn);
            this.Controls.Add(this.OrdersDeleteBtn);
            this.Controls.Add(this.OrdersEditBtn);
            this.Controls.Add(this.OrdersCloseBtn);
            this.Controls.Add(this.OrdersDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Дитрикс-Сибирь\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказаноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВидПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказаныеТоварыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem просмотретьToolStripMenuItem5;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.Button OrdersCloseBtn;
        private System.Windows.Forms.Button OrdersDeleteBtn;
        private System.Windows.Forms.Button OrdersEditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordred;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePlacements;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVersions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button OrdersFindBtn;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеПользователяToolStripMenuItem;
    }
}

