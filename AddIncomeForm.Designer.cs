namespace Lab2
{
    partial class AddIncomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbIncomeType = new System.Windows.Forms.ComboBox();
            this.panelSalary = new System.Windows.Forms.Panel();
            this.nudSalarySum = new System.Windows.Forms.NumericUpDown();
            this.dtpSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDividend = new System.Windows.Forms.Panel();
            this.nudDividendSum = new System.Windows.Forms.NumericUpDown();
            this.nudDividendAccount = new System.Windows.Forms.NumericUpDown();
            this.dtpDividendDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRent = new System.Windows.Forms.Panel();
            this.nudRentSum = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtObjectType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelSalary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarySum)).BeginInit();
            this.panelDividend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDividendSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDividendAccount)).BeginInit();
            this.panelRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentSum)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIncomeType
            // 
            this.cmbIncomeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncomeType.FormattingEnabled = true;
            this.cmbIncomeType.Location = new System.Drawing.Point(12, 12);
            this.cmbIncomeType.Name = "cmbIncomeType";
            this.cmbIncomeType.Size = new System.Drawing.Size(200, 21);
            this.cmbIncomeType.TabIndex = 0;
            this.cmbIncomeType.SelectedIndexChanged += new System.EventHandler(this.cmbIncomeType_SelectedIndexChanged);
            // 
            // panelSalary
            // 
            this.panelSalary.Controls.Add(this.nudSalarySum);
            this.panelSalary.Controls.Add(this.dtpSalaryDate);
            this.panelSalary.Controls.Add(this.label1);
            this.panelSalary.Controls.Add(this.label2);
            this.panelSalary.Location = new System.Drawing.Point(12, 39);
            this.panelSalary.Name = "panelSalary";
            this.panelSalary.Size = new System.Drawing.Size(200, 100);
            this.panelSalary.TabIndex = 1;
            // 
            // nudSalarySum
            // 
            this.nudSalarySum.Location = new System.Drawing.Point(70, 33);
            this.nudSalarySum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSalarySum.Name = "nudSalarySum";
            this.nudSalarySum.Size = new System.Drawing.Size(120, 20);
            this.nudSalarySum.TabIndex = 3;
            // 
            // dtpSalaryDate
            // 
            this.dtpSalaryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalaryDate.Location = new System.Drawing.Point(70, 7);
            this.dtpSalaryDate.Name = "dtpSalaryDate";
            this.dtpSalaryDate.Size = new System.Drawing.Size(120, 20);
            this.dtpSalaryDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сумма";
            // 
            // panelDividend
            // 
            this.panelDividend.Controls.Add(this.nudDividendSum);
            this.panelDividend.Controls.Add(this.nudDividendAccount);
            this.panelDividend.Controls.Add(this.dtpDividendDate);
            this.panelDividend.Controls.Add(this.label3);
            this.panelDividend.Controls.Add(this.label4);
            this.panelDividend.Controls.Add(this.label5);
            this.panelDividend.Location = new System.Drawing.Point(12, 39);
            this.panelDividend.Name = "panelDividend";
            this.panelDividend.Size = new System.Drawing.Size(200, 100);
            this.panelDividend.TabIndex = 2;
            this.panelDividend.Visible = false;
            // 
            // nudDividendSum
            // 
            this.nudDividendSum.Location = new System.Drawing.Point(70, 59);
            this.nudDividendSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDividendSum.Name = "nudDividendSum";
            this.nudDividendSum.Size = new System.Drawing.Size(120, 20);
            this.nudDividendSum.TabIndex = 5;
            // 
            // nudDividendAccount
            // 
            this.nudDividendAccount.Location = new System.Drawing.Point(70, 33);
            this.nudDividendAccount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudDividendAccount.Name = "nudDividendAccount";
            this.nudDividendAccount.Size = new System.Drawing.Size(120, 20);
            this.nudDividendAccount.TabIndex = 4;
            // 
            // dtpDividendDate
            // 
            this.dtpDividendDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDividendDate.Location = new System.Drawing.Point(70, 7);
            this.dtpDividendDate.Name = "dtpDividendDate";
            this.dtpDividendDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDividendDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "№ счета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Сумма";
            // 
            // panelRent
            // 
            this.panelRent.Controls.Add(this.nudRentSum);
            this.panelRent.Controls.Add(this.txtName);
            this.panelRent.Controls.Add(this.txtObjectType);
            this.panelRent.Controls.Add(this.txtAddress);
            this.panelRent.Controls.Add(this.label6);
            this.panelRent.Controls.Add(this.label7);
            this.panelRent.Controls.Add(this.label8);
            this.panelRent.Controls.Add(this.label9);
            this.panelRent.Location = new System.Drawing.Point(12, 39);
            this.panelRent.Name = "panelRent";
            this.panelRent.Size = new System.Drawing.Size(200, 100);
            this.panelRent.TabIndex = 3;
            this.panelRent.Visible = false;
            // 
            // nudRentSum
            // 
            this.nudRentSum.Location = new System.Drawing.Point(70, 85);
            this.nudRentSum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRentSum.Name = "nudRentSum";
            this.nudRentSum.Size = new System.Drawing.Size(120, 20);
            this.nudRentSum.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtObjectType
            // 
            this.txtObjectType.Location = new System.Drawing.Point(70, 33);
            this.txtObjectType.Name = "txtObjectType";
            this.txtObjectType.Size = new System.Drawing.Size(120, 20);
            this.txtObjectType.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(70, 7);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(120, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Тип";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Имя";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Сумма";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(137, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddIncomeForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(224, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelRent);
            this.Controls.Add(this.panelDividend);
            this.Controls.Add(this.panelSalary);
            this.Controls.Add(this.cmbIncomeType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавить доход";
            this.panelSalary.ResumeLayout(false);
            this.panelSalary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalarySum)).EndInit();
            this.panelDividend.ResumeLayout(false);
            this.panelDividend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDividendSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDividendAccount)).EndInit();
            this.panelRent.ResumeLayout(false);
            this.panelRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentSum)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cmbIncomeType;
        private System.Windows.Forms.Panel panelSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSalaryDate;
        private System.Windows.Forms.NumericUpDown nudSalarySum;
        private System.Windows.Forms.Panel panelDividend;
        private System.Windows.Forms.NumericUpDown nudDividendSum;
        private System.Windows.Forms.NumericUpDown nudDividendAccount;
        private System.Windows.Forms.DateTimePicker dtpDividendDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRent;
        private System.Windows.Forms.NumericUpDown nudRentSum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtObjectType;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}