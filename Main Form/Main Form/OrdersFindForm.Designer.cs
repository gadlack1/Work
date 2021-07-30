namespace Main_Form
{
    partial class OrdersFindForm
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DateVersionRadioBtn = new System.Windows.Forms.RadioButton();
            this.DatePlacementRadioButton = new System.Windows.Forms.RadioButton();
            this.ClientFIORadioButton = new System.Windows.Forms.RadioButton();
            this.OrderedRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(12, 266);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(179, 266);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите строку поиска";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(16, 30);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(238, 20);
            this.FindTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DateVersionRadioBtn);
            this.groupBox1.Controls.Add(this.DatePlacementRadioButton);
            this.groupBox1.Controls.Add(this.ClientFIORadioButton);
            this.groupBox1.Controls.Add(this.OrderedRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(16, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поля для поиска";
            // 
            // DateVersionRadioBtn
            // 
            this.DateVersionRadioBtn.AutoSize = true;
            this.DateVersionRadioBtn.Location = new System.Drawing.Point(7, 132);
            this.DateVersionRadioBtn.Name = "DateVersionRadioBtn";
            this.DateVersionRadioBtn.Size = new System.Drawing.Size(126, 17);
            this.DateVersionRadioBtn.TabIndex = 3;
            this.DateVersionRadioBtn.TabStop = true;
            this.DateVersionRadioBtn.Text = "по дате исполнения";
            this.DateVersionRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DatePlacementRadioButton
            // 
            this.DatePlacementRadioButton.AutoSize = true;
            this.DatePlacementRadioButton.Location = new System.Drawing.Point(7, 99);
            this.DatePlacementRadioButton.Name = "DatePlacementRadioButton";
            this.DatePlacementRadioButton.Size = new System.Drawing.Size(131, 17);
            this.DatePlacementRadioButton.TabIndex = 2;
            this.DatePlacementRadioButton.TabStop = true;
            this.DatePlacementRadioButton.Text = "по дате размещения";
            this.DatePlacementRadioButton.UseVisualStyleBackColor = true;
            // 
            // ClientFIORadioButton
            // 
            this.ClientFIORadioButton.AutoSize = true;
            this.ClientFIORadioButton.Location = new System.Drawing.Point(7, 66);
            this.ClientFIORadioButton.Name = "ClientFIORadioButton";
            this.ClientFIORadioButton.Size = new System.Drawing.Size(111, 17);
            this.ClientFIORadioButton.TabIndex = 1;
            this.ClientFIORadioButton.TabStop = true;
            this.ClientFIORadioButton.Text = "по ФИО клиента";
            this.ClientFIORadioButton.UseVisualStyleBackColor = true;
            // 
            // OrderedRadioBtn
            // 
            this.OrderedRadioBtn.AutoSize = true;
            this.OrderedRadioBtn.Location = new System.Drawing.Point(6, 31);
            this.OrderedRadioBtn.Name = "OrderedRadioBtn";
            this.OrderedRadioBtn.Size = new System.Drawing.Size(102, 17);
            this.OrderedRadioBtn.TabIndex = 0;
            this.OrderedRadioBtn.TabStop = true;
            this.OrderedRadioBtn.Text = "по коду заказа";
            this.OrderedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // OrdersFindForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(266, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersFindForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ClientFIORadioButton;
        private System.Windows.Forms.RadioButton OrderedRadioBtn;
        private System.Windows.Forms.RadioButton DateVersionRadioBtn;
        private System.Windows.Forms.RadioButton DatePlacementRadioButton;
    }
}