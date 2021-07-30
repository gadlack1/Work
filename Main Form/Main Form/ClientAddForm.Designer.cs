namespace Main_Form
{
    partial class ClientAddForm
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
            this.FIOClientTextBox = new System.Windows.Forms.TextBox();
            this.CityClientTextBox = new System.Windows.Forms.TextBox();
            this.AddressClientTextBox = new System.Windows.Forms.TextBox();
            this.NumberClientTextBox = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адресс клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер клиента";
            // 
            // FIOClientTextBox
            // 
            this.FIOClientTextBox.Location = new System.Drawing.Point(15, 26);
            this.FIOClientTextBox.Name = "FIOClientTextBox";
            this.FIOClientTextBox.Size = new System.Drawing.Size(209, 20);
            this.FIOClientTextBox.TabIndex = 4;
            // 
            // CityClientTextBox
            // 
            this.CityClientTextBox.Location = new System.Drawing.Point(15, 75);
            this.CityClientTextBox.Name = "CityClientTextBox";
            this.CityClientTextBox.Size = new System.Drawing.Size(209, 20);
            this.CityClientTextBox.TabIndex = 5;
            // 
            // AddressClientTextBox
            // 
            this.AddressClientTextBox.Location = new System.Drawing.Point(15, 129);
            this.AddressClientTextBox.Name = "AddressClientTextBox";
            this.AddressClientTextBox.Size = new System.Drawing.Size(209, 20);
            this.AddressClientTextBox.TabIndex = 6;
            // 
            // NumberClientTextBox
            // 
            this.NumberClientTextBox.Location = new System.Drawing.Point(15, 181);
            this.NumberClientTextBox.Name = "NumberClientTextBox";
            this.NumberClientTextBox.Size = new System.Drawing.Size(206, 20);
            this.NumberClientTextBox.TabIndex = 7;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(18, 232);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 8;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(148, 231);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ClientAddForm
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(250, 270);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.NumberClientTextBox);
            this.Controls.Add(this.AddressClientTextBox);
            this.Controls.Add(this.CityClientTextBox);
            this.Controls.Add(this.FIOClientTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientAddForm_FormClosing);
            this.Shown += new System.EventHandler(this.ClientAddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIOClientTextBox;
        private System.Windows.Forms.TextBox CityClientTextBox;
        private System.Windows.Forms.TextBox AddressClientTextBox;
        private System.Windows.Forms.TextBox NumberClientTextBox;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}