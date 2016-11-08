namespace BikeStreet
{
    partial class clientControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.saveClient = new System.Windows.Forms.Button();
            this.fioLable = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phoneLable = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.passportText = new System.Windows.Forms.TextBox();
            this.addressLable = new System.Windows.Forms.Label();
            this.passportLable = new System.Windows.Forms.Label();
            this.closeClient = new System.Windows.Forms.Button();
            this.fioComboBox = new System.Windows.Forms.ComboBox();
            this.newClient = new System.Windows.Forms.Button();
            this.winterRentalButton = new System.Windows.Forms.Button();
            this.rentalDGV = new System.Windows.Forms.DataGridView();
            this.summerRentalButton = new System.Windows.Forms.Button();
            this.returnedButton = new System.Windows.Forms.Button();
            this.printContractButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveClient
            // 
            this.saveClient.Location = new System.Drawing.Point(239, 193);
            this.saveClient.Name = "saveClient";
            this.saveClient.Size = new System.Drawing.Size(75, 23);
            this.saveClient.TabIndex = 6;
            this.saveClient.Text = "Сохранить";
            this.saveClient.UseVisualStyleBackColor = true;
            this.saveClient.Click += new System.EventHandler(this.saveClient_Click);
            // 
            // fioLable
            // 
            this.fioLable.AutoSize = true;
            this.fioLable.Location = new System.Drawing.Point(23, 17);
            this.fioLable.Name = "fioLable";
            this.fioLable.Size = new System.Drawing.Size(34, 13);
            this.fioLable.TabIndex = 2;
            this.fioLable.Text = "ФИО";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(63, 40);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(251, 20);
            this.phoneText.TabIndex = 2;
            // 
            // phoneLable
            // 
            this.phoneLable.AutoSize = true;
            this.phoneLable.Location = new System.Drawing.Point(8, 43);
            this.phoneLable.Name = "phoneLable";
            this.phoneLable.Size = new System.Drawing.Size(49, 13);
            this.phoneLable.TabIndex = 2;
            this.phoneLable.Text = "Тельчик";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(63, 66);
            this.addressText.Multiline = true;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(251, 44);
            this.addressText.TabIndex = 3;
            // 
            // passportText
            // 
            this.passportText.Location = new System.Drawing.Point(63, 129);
            this.passportText.Multiline = true;
            this.passportText.Name = "passportText";
            this.passportText.Size = new System.Drawing.Size(251, 58);
            this.passportText.TabIndex = 4;
            // 
            // addressLable
            // 
            this.addressLable.AutoSize = true;
            this.addressLable.Location = new System.Drawing.Point(19, 69);
            this.addressLable.Name = "addressLable";
            this.addressLable.Size = new System.Drawing.Size(38, 13);
            this.addressLable.TabIndex = 2;
            this.addressLable.Text = "Адрес";
            // 
            // passportLable
            // 
            this.passportLable.AutoSize = true;
            this.passportLable.Location = new System.Drawing.Point(8, 113);
            this.passportLable.Name = "passportLable";
            this.passportLable.Size = new System.Drawing.Size(111, 13);
            this.passportLable.TabIndex = 2;
            this.passportLable.Text = "Паспортные данные";
            // 
            // closeClient
            // 
            this.closeClient.Location = new System.Drawing.Point(643, 14);
            this.closeClient.Name = "closeClient";
            this.closeClient.Size = new System.Drawing.Size(75, 23);
            this.closeClient.TabIndex = 5;
            this.closeClient.Text = "Закрыть";
            this.closeClient.UseVisualStyleBackColor = true;
            this.closeClient.Visible = false;
            this.closeClient.Click += new System.EventHandler(this.closeClient_Click);
            // 
            // fioComboBox
            // 
            this.fioComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fioComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fioComboBox.FormattingEnabled = true;
            this.fioComboBox.Location = new System.Drawing.Point(63, 13);
            this.fioComboBox.Name = "fioComboBox";
            this.fioComboBox.Size = new System.Drawing.Size(251, 21);
            this.fioComboBox.TabIndex = 1;
            this.fioComboBox.SelectionChangeCommitted += new System.EventHandler(this.fioComboBox_SelectionChangeCommitted);
            this.fioComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fioComboBox_KeyUp);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(11, 193);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(75, 23);
            this.newClient.TabIndex = 5;
            this.newClient.Text = "Новый";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // winterRentalButton
            // 
            this.winterRentalButton.Location = new System.Drawing.Point(6, 18);
            this.winterRentalButton.Name = "winterRentalButton";
            this.winterRentalButton.Size = new System.Drawing.Size(75, 23);
            this.winterRentalButton.TabIndex = 7;
            this.winterRentalButton.Text = "Зима";
            this.winterRentalButton.UseVisualStyleBackColor = true;
            this.winterRentalButton.Click += new System.EventHandler(this.winterRentalButton_Click);
            // 
            // rentalDGV
            // 
            this.rentalDGV.AllowUserToAddRows = false;
            this.rentalDGV.AllowUserToDeleteRows = false;
            this.rentalDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rentalDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rentalDGV.Location = new System.Drawing.Point(0, 230);
            this.rentalDGV.MultiSelect = false;
            this.rentalDGV.Name = "rentalDGV";
            this.rentalDGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rentalDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.rentalDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalDGV.Size = new System.Drawing.Size(734, 214);
            this.rentalDGV.TabIndex = 12;
            this.rentalDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.rentalDGV_CellFormatting);
            this.rentalDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.rentalDGV_RowPostPaint);
            this.rentalDGV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.rentalDGV_RowPrePaint);
            // 
            // summerRentalButton
            // 
            this.summerRentalButton.Location = new System.Drawing.Point(6, 47);
            this.summerRentalButton.Name = "summerRentalButton";
            this.summerRentalButton.Size = new System.Drawing.Size(75, 23);
            this.summerRentalButton.TabIndex = 8;
            this.summerRentalButton.Text = "Лето";
            this.summerRentalButton.UseVisualStyleBackColor = true;
            // 
            // returnedButton
            // 
            this.returnedButton.Location = new System.Drawing.Point(6, 104);
            this.returnedButton.Name = "returnedButton";
            this.returnedButton.Size = new System.Drawing.Size(75, 23);
            this.returnedButton.TabIndex = 9;
            this.returnedButton.Text = "Вернуть";
            this.returnedButton.UseVisualStyleBackColor = true;
            this.returnedButton.Click += new System.EventHandler(this.returnedButton_Click);
            // 
            // printContractButton
            // 
            this.printContractButton.Location = new System.Drawing.Point(6, 142);
            this.printContractButton.Name = "printContractButton";
            this.printContractButton.Size = new System.Drawing.Size(75, 23);
            this.printContractButton.TabIndex = 13;
            this.printContractButton.Text = "Печать";
            this.printContractButton.UseVisualStyleBackColor = true;
            this.printContractButton.Click += new System.EventHandler(this.printContractButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveClient);
            this.groupBox1.Controls.Add(this.fioLable);
            this.groupBox1.Controls.Add(this.phoneLable);
            this.groupBox1.Controls.Add(this.addressLable);
            this.groupBox1.Controls.Add(this.passportLable);
            this.groupBox1.Controls.Add(this.phoneText);
            this.groupBox1.Controls.Add(this.newClient);
            this.groupBox1.Controls.Add(this.addressText);
            this.groupBox1.Controls.Add(this.fioComboBox);
            this.groupBox1.Controls.Add(this.passportText);
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 225);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.winterRentalButton);
            this.groupBox2.Controls.Add(this.summerRentalButton);
            this.groupBox2.Controls.Add(this.printContractButton);
            this.groupBox2.Controls.Add(this.returnedButton);
            this.groupBox2.Location = new System.Drawing.Point(340, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 175);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Прокат";
            // 
            // clientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rentalDGV);
            this.Controls.Add(this.closeClient);
            this.Name = "clientControl";
            this.Size = new System.Drawing.Size(734, 444);
            this.Click += new System.EventHandler(this.clientControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.rentalDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveClient;
        private System.Windows.Forms.Label fioLable;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phoneLable;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox passportText;
        private System.Windows.Forms.Label addressLable;
        private System.Windows.Forms.Label passportLable;
        private System.Windows.Forms.Button closeClient;
        private System.Windows.Forms.ComboBox fioComboBox;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button winterRentalButton;
        private System.Windows.Forms.DataGridView rentalDGV;
        private System.Windows.Forms.Button summerRentalButton;
        private System.Windows.Forms.Button returnedButton;
        private System.Windows.Forms.Button printContractButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
