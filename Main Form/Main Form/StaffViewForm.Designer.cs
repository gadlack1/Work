namespace Main_Form
{
    partial class StaffViewForm
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
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            this.staffFIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDolgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffZPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDitrix = new Main_Form.DataDitrix();
            this.staffTableAdapter = new Main_Form.DataDitrixTableAdapters.StaffTableAdapter();
            this.DeletBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(478, 202);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // StaffDGV
            // 
            this.StaffDGV.AllowUserToAddRows = false;
            this.StaffDGV.AllowUserToDeleteRows = false;
            this.StaffDGV.AutoGenerateColumns = false;
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffFIODataGridViewTextBoxColumn,
            this.staffDolgDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn,
            this.staffNumberDataGridViewTextBoxColumn,
            this.staffZPDataGridViewTextBoxColumn,
            this.Staff_ID});
            this.StaffDGV.DataSource = this.staffBindingSource;
            this.StaffDGV.Location = new System.Drawing.Point(22, 26);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.ReadOnly = true;
            this.StaffDGV.RowHeadersWidth = 20;
            this.StaffDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDGV.Size = new System.Drawing.Size(970, 150);
            this.StaffDGV.TabIndex = 1;
            this.StaffDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDGV_CellDoubleClick);
            // 
            // staffFIODataGridViewTextBoxColumn
            // 
            this.staffFIODataGridViewTextBoxColumn.DataPropertyName = "Staff_FIO";
            this.staffFIODataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.staffFIODataGridViewTextBoxColumn.Name = "staffFIODataGridViewTextBoxColumn";
            this.staffFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.staffFIODataGridViewTextBoxColumn.Width = 280;
            // 
            // staffDolgDataGridViewTextBoxColumn
            // 
            this.staffDolgDataGridViewTextBoxColumn.DataPropertyName = "Staff_Dolg";
            this.staffDolgDataGridViewTextBoxColumn.HeaderText = "Должность сотрудника";
            this.staffDolgDataGridViewTextBoxColumn.Name = "staffDolgDataGridViewTextBoxColumn";
            this.staffDolgDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffDolgDataGridViewTextBoxColumn.Width = 200;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "Staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "Адрес сотрудника";
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffAddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // staffNumberDataGridViewTextBoxColumn
            // 
            this.staffNumberDataGridViewTextBoxColumn.DataPropertyName = "Staff_Number";
            this.staffNumberDataGridViewTextBoxColumn.HeaderText = "Номер сотрудника";
            this.staffNumberDataGridViewTextBoxColumn.Name = "staffNumberDataGridViewTextBoxColumn";
            this.staffNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffZPDataGridViewTextBoxColumn
            // 
            this.staffZPDataGridViewTextBoxColumn.DataPropertyName = "Staff_ZP";
            this.staffZPDataGridViewTextBoxColumn.HeaderText = "З/П сотрудника";
            this.staffZPDataGridViewTextBoxColumn.Name = "staffZPDataGridViewTextBoxColumn";
            this.staffZPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Staff_ID
            // 
            this.Staff_ID.DataPropertyName = "Staff_ID";
            this.Staff_ID.HeaderText = "Staff_ID";
            this.Staff_ID.Name = "Staff_ID";
            this.Staff_ID.ReadOnly = true;
            this.Staff_ID.Visible = false;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dataDitrix;
            // 
            // dataDitrix
            // 
            this.dataDitrix.DataSetName = "DataDitrix";
            this.dataDitrix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // DeletBtn
            // 
            this.DeletBtn.Location = new System.Drawing.Point(361, 202);
            this.DeletBtn.Name = "DeletBtn";
            this.DeletBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletBtn.TabIndex = 2;
            this.DeletBtn.Text = "Удалить";
            this.DeletBtn.UseVisualStyleBackColor = true;
            this.DeletBtn.Click += new System.EventHandler(this.DeletBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(597, 202);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // StaffViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(1014, 278);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeletBtn);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр сотрудников";
            this.Activated += new System.EventHandler(this.StaffViewForm_Activated);
            this.Load += new System.EventHandler(this.ViewStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridView StaffDGV;
        private DataDitrix dataDitrix;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DataDitrixTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button DeletBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDolgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffZPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
    }
}