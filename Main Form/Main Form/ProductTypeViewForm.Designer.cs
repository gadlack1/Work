namespace Main_Form
{
    partial class ProductTypeViewForm
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ProductTypeDGV = new System.Windows.Forms.DataGridView();
            this.ProductType_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDitrix = new Main_Form.DataDitrix();
            this.productTypeTableAdapter = new Main_Form.DataDitrixTableAdapters.ProductTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(22, 223);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 0;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseBtn.Location = new System.Drawing.Point(204, 223);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(387, 223);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ProductTypeDGV
            // 
            this.ProductTypeDGV.AllowUserToAddRows = false;
            this.ProductTypeDGV.AllowUserToDeleteRows = false;
            this.ProductTypeDGV.AutoGenerateColumns = false;
            this.ProductTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTypeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeTypeDataGridViewTextBoxColumn,
            this.productTypeDescriptionDataGridViewTextBoxColumn,
            this.ProductType_ID});
            this.ProductTypeDGV.DataSource = this.productTypeBindingSource;
            this.ProductTypeDGV.Location = new System.Drawing.Point(22, 26);
            this.ProductTypeDGV.Name = "ProductTypeDGV";
            this.ProductTypeDGV.ReadOnly = true;
            this.ProductTypeDGV.RowHeadersWidth = 20;
            this.ProductTypeDGV.Size = new System.Drawing.Size(440, 150);
            this.ProductTypeDGV.TabIndex = 3;
            this.ProductTypeDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductTypeDGV_CellDoubleClick);
            // 
            // ProductType_ID
            // 
            this.ProductType_ID.DataPropertyName = "ProductType_ID";
            this.ProductType_ID.HeaderText = "ProductType_ID";
            this.ProductType_ID.Name = "ProductType_ID";
            this.ProductType_ID.ReadOnly = true;
            this.ProductType_ID.Visible = false;
            // 
            // productTypeTypeDataGridViewTextBoxColumn
            // 
            this.productTypeTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType_Type";
            this.productTypeTypeDataGridViewTextBoxColumn.HeaderText = "Вид продукта";
            this.productTypeTypeDataGridViewTextBoxColumn.Name = "productTypeTypeDataGridViewTextBoxColumn";
            this.productTypeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // productTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.productTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductType_Description";
            this.productTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание продукта";
            this.productTypeDescriptionDataGridViewTextBoxColumn.Name = "productTypeDescriptionDataGridViewTextBoxColumn";
            this.productTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.productTypeDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.dataDitrix;
            // 
            // dataDitrix
            // 
            this.dataDitrix.DataSetName = "DataDitrix";
            this.dataDitrix.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ProductTypeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(502, 278);
            this.Controls.Add(this.ProductTypeDGV);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DeleteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductTypeViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр типа продукта";
            this.Activated += new System.EventHandler(this.ProductTypeViewForm_Activated);
            this.Load += new System.EventHandler(this.ProductTypeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDitrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridView ProductTypeDGV;
        private DataDitrix dataDitrix;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private DataDitrixTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType_ID;
    }
}