namespace Main_Form
{
    partial class StaffAddForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.FIOtextBox = new System.Windows.Forms.TextBox();
            this.DolgTextBox = new System.Windows.Forms.TextBox();
            this.AddressStaffTextBox = new System.Windows.Forms.TextBox();
            this.NumberStaffTextBox = new System.Windows.Forms.TextBox();
            this.ZPStaffTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление ФИО сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добавление должности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добавление адреса сотрудника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Добавленние номера сотрудника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Заработая плата сотрудника";
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(12, 274);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(197, 274);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FIOtextBox
            // 
            this.FIOtextBox.Location = new System.Drawing.Point(12, 30);
            this.FIOtextBox.Name = "FIOtextBox";
            this.FIOtextBox.Size = new System.Drawing.Size(260, 20);
            this.FIOtextBox.TabIndex = 7;
            // 
            // DolgTextBox
            // 
            this.DolgTextBox.Location = new System.Drawing.Point(12, 76);
            this.DolgTextBox.Name = "DolgTextBox";
            this.DolgTextBox.Size = new System.Drawing.Size(260, 20);
            this.DolgTextBox.TabIndex = 8;
            // 
            // AddressStaffTextBox
            // 
            this.AddressStaffTextBox.Location = new System.Drawing.Point(12, 127);
            this.AddressStaffTextBox.Name = "AddressStaffTextBox";
            this.AddressStaffTextBox.Size = new System.Drawing.Size(260, 20);
            this.AddressStaffTextBox.TabIndex = 9;
            // 
            // NumberStaffTextBox
            // 
            this.NumberStaffTextBox.Location = new System.Drawing.Point(12, 181);
            this.NumberStaffTextBox.Name = "NumberStaffTextBox";
            this.NumberStaffTextBox.Size = new System.Drawing.Size(260, 20);
            this.NumberStaffTextBox.TabIndex = 10;
            // 
            // ZPStaffTextBox
            // 
            this.ZPStaffTextBox.Location = new System.Drawing.Point(12, 233);
            this.ZPStaffTextBox.Name = "ZPStaffTextBox";
            this.ZPStaffTextBox.Size = new System.Drawing.Size(260, 20);
            this.ZPStaffTextBox.TabIndex = 11;
            // 
            // StaffAddForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(302, 311);
            this.Controls.Add(this.ZPStaffTextBox);
            this.Controls.Add(this.NumberStaffTextBox);
            this.Controls.Add(this.AddressStaffTextBox);
            this.Controls.Add(this.DolgTextBox);
            this.Controls.Add(this.FIOtextBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaffAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление сотрудника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffAddForm_FormClosing);
            this.Shown += new System.EventHandler(this.StaffAddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox FIOtextBox;
        private System.Windows.Forms.TextBox DolgTextBox;
        private System.Windows.Forms.TextBox AddressStaffTextBox;
        private System.Windows.Forms.TextBox NumberStaffTextBox;
        private System.Windows.Forms.TextBox ZPStaffTextBox;
    }
}