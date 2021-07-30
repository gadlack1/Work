namespace Main_Form
{
    partial class ClientViewForm
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
            this.components = new System.ComponentModel.Container();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ClientDGV = new System.Windows.Forms.DataGridView();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDitrix = new Main_Form.DataDitrix();
            this.clientTableAdapter = new Main_Form.DataDitrixTableAdapters.ClientTableAdapter();
            this.clientFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(355, 213);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(207, 213);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(484, 213);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ClientDGV
            // 
            this.ClientDGV.AllowUserToAddRows = false;
            this.ClientDGV.AllowUserToDeleteRows = false;
            this.ClientDGV.AutoGenerateColumns = false;
            this.ClientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientFIODataGridViewTextBoxColumn,
            this.clientCityDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.clientNumberDataGridViewTextBoxColumn,
            this.Client_ID});
            this.ClientDGV.DataSource = this.clientBindingSource;
            this.ClientDGV.Location = new System.Drawing.Point(22, 26);
            this.ClientDGV.Name = "ClientDGV";
            this.ClientDGV.ReadOnly = true;
            this.ClientDGV.RowHeadersWidth = 20;
            this.ClientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientDGV.Size = new System.Drawing.Size(770, 150);
            this.ClientDGV.TabIndex = 3;
            this.ClientDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDGV_CellDoubleClick);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dataDitrix;
            // 
            // dataDitrix
            // 
            this.dataDitrix.DataSetName = "DataDitrix";
            this.dataDitrix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientFIODataGridViewTextBoxColumn
            // 
            this.clientFIODataGridViewTextBoxColumn.DataPropertyName = "Client_FIO";
            this.clientFIODataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.clientFIODataGridViewTextBoxColumn.Name = "clientFIODataGridViewTextBoxColumn";
            this.clientFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.clientFIODataGridViewTextBoxColumn.Width = 280;
            // 
            // clientCityDataGridViewTextBoxColumn
            // 
            this.clientCityDataGridViewTextBoxColumn.DataPropertyName = "Client_City";
            this.clientCityDataGridViewTextBoxColumn.HeaderText = "Город клиента";
            this.clientCityDataGridViewTextBoxColumn.Name = "clientCityDataGridViewTextBoxColumn";
            this.clientCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientCityDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientAddressDataGridViewTextBoxColumn
            // 
            this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "Client_Address";
            this.clientAddressDataGridViewTextBoxColumn.HeaderText = "Адрес клиента";
            this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
            this.clientAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientAddressDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientNumberDataGridViewTextBoxColumn
            // 
            this.clientNumberDataGridViewTextBoxColumn.DataPropertyName = "Client_Number";
            this.clientNumberDataGridViewTextBoxColumn.HeaderText = "Номер клиента";
            this.clientNumberDataGridViewTextBoxColumn.Name = "clientNumberDataGridViewTextBoxColumn";
            this.clientNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Client_ID
            // 
            this.Client_ID.DataPropertyName = "Client_ID";
            this.Client_ID.HeaderText = "Client_ID";
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.ReadOnly = true;
            this.Client_ID.Visible = false;
            // 
            // ClientViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(818, 257);
            this.Controls.Add(this.ClientDGV);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр клиентов";
            this.Activated += new System.EventHandler(this.ClientViewForm_Activated);
            this.Load += new System.EventHandler(this.ClientViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ClientDGV;
        private DataDitrix dataDitrix;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataDitrixTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
    }
}