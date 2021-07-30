namespace Main_Form
{
    partial class OrderedViewForm
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
            this.OrderedDGV = new System.Windows.Forms.DataGridView();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KolVo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeletBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderedDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderedDGV
            // 
            this.OrderedDGV.AllowUserToAddRows = false;
            this.OrderedDGV.AllowUserToDeleteRows = false;
            this.OrderedDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderedDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductType,
            this.KolVo,
            this.Price,
            this.Sale,
            this.ID});
            this.OrderedDGV.Location = new System.Drawing.Point(22, 26);
            this.OrderedDGV.Name = "OrderedDGV";
            this.OrderedDGV.ReadOnly = true;
            this.OrderedDGV.RowHeadersWidth = 20;
            this.OrderedDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderedDGV.Size = new System.Drawing.Size(540, 150);
            this.OrderedDGV.TabIndex = 0;
            this.OrderedDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderedDGV_CellDoubleClick);
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "Тип продукции";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 200;
            // 
            // KolVo
            // 
            this.KolVo.HeaderText = "Количество";
            this.KolVo.Name = "KolVo";
            this.KolVo.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Sale
            // 
            this.Sale.HeaderText = "Скидка";
            this.Sale.Name = "Sale";
            this.Sale.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(248, 193);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 1;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeletBtn
            // 
            this.DeletBtn.Location = new System.Drawing.Point(122, 193);
            this.DeletBtn.Name = "DeletBtn";
            this.DeletBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletBtn.TabIndex = 2;
            this.DeletBtn.Text = "Удалить";
            this.DeletBtn.UseVisualStyleBackColor = true;
            this.DeletBtn.Click += new System.EventHandler(this.DeletBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(369, 193);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // OrderedViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(589, 237);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeletBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.OrderedDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderedViewForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр заказано";
            this.Activated += new System.EventHandler(this.OrderedViewForm_Activated);
            this.Shown += new System.EventHandler(this.OrderedViewForm_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.OrderedDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderedDGV;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button DeletBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn KolVo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}