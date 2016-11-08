namespace BikeStreet
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListTab = new System.Windows.Forms.TabControl();
            this.contractListTab = new System.Windows.Forms.TabPage();
            this.periodDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.returnedCheckBox = new System.Windows.Forms.CheckBox();
            this.newContractButton = new System.Windows.Forms.Button();
            this.returnedButton = new System.Windows.Forms.Button();
            this.contractDGV = new System.Windows.Forms.DataGridView();
            this.editClientTab = new System.Windows.Forms.TabPage();
            this.equipmentListTab = new System.Windows.Forms.TabPage();
            this.inStockCheckBox = new System.Windows.Forms.CheckBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serachEquipTextBox = new System.Windows.Forms.TextBox();
            this.editEquipmentButton = new System.Windows.Forms.Button();
            this.delEquipmentButton = new System.Windows.Forms.Button();
            this.newEquipmentButton = new System.Windows.Forms.Button();
            this.equipmentDGV = new System.Windows.Forms.DataGridView();
            this.clientListTab = new System.Windows.Forms.TabPage();
            this.delClient = new System.Windows.Forms.Button();
            this.serachButton = new System.Windows.Forms.Button();
            this.serachTextBox = new System.Windows.Forms.TextBox();
            this.newClient = new System.Windows.Forms.Button();
            this.clientDGV = new System.Windows.Forms.DataGridView();
            this.clientControl1 = new BikeStreet.clientControl();
            this.ListTab.SuspendLayout();
            this.contractListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDGV)).BeginInit();
            this.editClientTab.SuspendLayout();
            this.equipmentListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).BeginInit();
            this.clientListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTab
            // 
            this.ListTab.Controls.Add(this.contractListTab);
            this.ListTab.Controls.Add(this.editClientTab);
            this.ListTab.Controls.Add(this.equipmentListTab);
            this.ListTab.Controls.Add(this.clientListTab);
            this.ListTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListTab.Location = new System.Drawing.Point(0, 0);
            this.ListTab.Name = "ListTab";
            this.ListTab.SelectedIndex = 0;
            this.ListTab.Size = new System.Drawing.Size(844, 429);
            this.ListTab.TabIndex = 2;
            this.ListTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.ListTab_Selected);
            // 
            // contractListTab
            // 
            this.contractListTab.BackColor = System.Drawing.SystemColors.Control;
            this.contractListTab.Controls.Add(this.periodDateTimePicker);
            this.contractListTab.Controls.Add(this.returnedCheckBox);
            this.contractListTab.Controls.Add(this.newContractButton);
            this.contractListTab.Controls.Add(this.returnedButton);
            this.contractListTab.Controls.Add(this.contractDGV);
            this.contractListTab.Location = new System.Drawing.Point(4, 22);
            this.contractListTab.Name = "contractListTab";
            this.contractListTab.Padding = new System.Windows.Forms.Padding(3);
            this.contractListTab.Size = new System.Drawing.Size(836, 403);
            this.contractListTab.TabIndex = 3;
            this.contractListTab.Text = "Прокат";
            // 
            // periodDateTimePicker
            // 
            this.periodDateTimePicker.Location = new System.Drawing.Point(233, 8);
            this.periodDateTimePicker.Name = "periodDateTimePicker";
            this.periodDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.periodDateTimePicker.TabIndex = 17;
            this.periodDateTimePicker.Value = new System.DateTime(2016, 2, 2, 0, 0, 0, 0);
            this.periodDateTimePicker.ValueChanged += new System.EventHandler(this.periodDateTimePicker_ValueChanged);
            // 
            // returnedCheckBox
            // 
            this.returnedCheckBox.AutoSize = true;
            this.returnedCheckBox.Location = new System.Drawing.Point(150, 11);
            this.returnedCheckBox.Name = "returnedCheckBox";
            this.returnedCheckBox.Size = new System.Drawing.Size(77, 17);
            this.returnedCheckBox.TabIndex = 16;
            this.returnedCheckBox.Text = "В прокате";
            this.returnedCheckBox.UseVisualStyleBackColor = true;
            this.returnedCheckBox.CheckedChanged += new System.EventHandler(this.returnedCheckBox_CheckedChanged);
            // 
            // newContractButton
            // 
            this.newContractButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.newContractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newContractButton.Location = new System.Drawing.Point(3, 4);
            this.newContractButton.Name = "newContractButton";
            this.newContractButton.Size = new System.Drawing.Size(120, 30);
            this.newContractButton.TabIndex = 15;
            this.newContractButton.Text = "Новый прокат";
            this.newContractButton.UseVisualStyleBackColor = false;
            this.newContractButton.Click += new System.EventHandler(this.newContractButton_Click);
            // 
            // returnedButton
            // 
            this.returnedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnedButton.BackColor = System.Drawing.Color.YellowGreen;
            this.returnedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnedButton.Location = new System.Drawing.Point(712, 4);
            this.returnedButton.Name = "returnedButton";
            this.returnedButton.Size = new System.Drawing.Size(120, 30);
            this.returnedButton.TabIndex = 14;
            this.returnedButton.Text = "Вернуть";
            this.returnedButton.UseVisualStyleBackColor = false;
            this.returnedButton.Click += new System.EventHandler(this.returnedButton_Click);
            // 
            // contractDGV
            // 
            this.contractDGV.AllowUserToAddRows = false;
            this.contractDGV.AllowUserToDeleteRows = false;
            this.contractDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contractDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contractDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contractDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.contractDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contractDGV.GridColor = System.Drawing.Color.Gray;
            this.contractDGV.Location = new System.Drawing.Point(3, 38);
            this.contractDGV.MultiSelect = false;
            this.contractDGV.Name = "contractDGV";
            this.contractDGV.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.contractDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contractDGV.Size = new System.Drawing.Size(830, 357);
            this.contractDGV.TabIndex = 13;
            this.contractDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.contractDGV_CellFormatting);
            this.contractDGV.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.contractDGV_RowPostPaint);
            this.contractDGV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.contractDGV_RowPrePaint);
            // 
            // editClientTab
            // 
            this.editClientTab.Controls.Add(this.clientControl1);
            this.editClientTab.Location = new System.Drawing.Point(4, 22);
            this.editClientTab.Name = "editClientTab";
            this.editClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.editClientTab.Size = new System.Drawing.Size(836, 403);
            this.editClientTab.TabIndex = 1;
            this.editClientTab.Text = "Клиент";
            // 
            // equipmentListTab
            // 
            this.equipmentListTab.Controls.Add(this.inStockCheckBox);
            this.equipmentListTab.Controls.Add(this.typeComboBox);
            this.equipmentListTab.Controls.Add(this.button1);
            this.equipmentListTab.Controls.Add(this.serachEquipTextBox);
            this.equipmentListTab.Controls.Add(this.editEquipmentButton);
            this.equipmentListTab.Controls.Add(this.delEquipmentButton);
            this.equipmentListTab.Controls.Add(this.newEquipmentButton);
            this.equipmentListTab.Controls.Add(this.equipmentDGV);
            this.equipmentListTab.Location = new System.Drawing.Point(4, 22);
            this.equipmentListTab.Name = "equipmentListTab";
            this.equipmentListTab.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentListTab.Size = new System.Drawing.Size(836, 403);
            this.equipmentListTab.TabIndex = 2;
            this.equipmentListTab.Text = "Оборудование";
            // 
            // inStockCheckBox
            // 
            this.inStockCheckBox.AutoSize = true;
            this.inStockCheckBox.Location = new System.Drawing.Point(451, 9);
            this.inStockCheckBox.Name = "inStockCheckBox";
            this.inStockCheckBox.Size = new System.Drawing.Size(77, 17);
            this.inStockCheckBox.TabIndex = 34;
            this.inStockCheckBox.Text = "В наличии";
            this.inStockCheckBox.UseVisualStyleBackColor = true;
            this.inStockCheckBox.CheckedChanged += new System.EventHandler(this.inStockCheckBox_CheckedChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(274, 6);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(153, 21);
            this.typeComboBox.TabIndex = 33;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeComboBox_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 32;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serachEquipTextBox
            // 
            this.serachEquipTextBox.Location = new System.Drawing.Point(8, 7);
            this.serachEquipTextBox.Name = "serachEquipTextBox";
            this.serachEquipTextBox.Size = new System.Drawing.Size(179, 20);
            this.serachEquipTextBox.TabIndex = 31;
            this.serachEquipTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.serachEquipTextBox_KeyUp);
            // 
            // editEquipmentButton
            // 
            this.editEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editEquipmentButton.Location = new System.Drawing.Point(758, 62);
            this.editEquipmentButton.Name = "editEquipmentButton";
            this.editEquipmentButton.Size = new System.Drawing.Size(75, 23);
            this.editEquipmentButton.TabIndex = 7;
            this.editEquipmentButton.Text = "Изменить";
            this.editEquipmentButton.UseVisualStyleBackColor = true;
            this.editEquipmentButton.Click += new System.EventHandler(this.editEquipmentButton_Click);
            // 
            // delEquipmentButton
            // 
            this.delEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delEquipmentButton.BackColor = System.Drawing.Color.Red;
            this.delEquipmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delEquipmentButton.Location = new System.Drawing.Point(758, 108);
            this.delEquipmentButton.Name = "delEquipmentButton";
            this.delEquipmentButton.Size = new System.Drawing.Size(75, 23);
            this.delEquipmentButton.TabIndex = 6;
            this.delEquipmentButton.Text = "Удалить";
            this.delEquipmentButton.UseVisualStyleBackColor = false;
            this.delEquipmentButton.Click += new System.EventHandler(this.delEquipment_Click);
            // 
            // newEquipmentButton
            // 
            this.newEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newEquipmentButton.Location = new System.Drawing.Point(758, 33);
            this.newEquipmentButton.Name = "newEquipmentButton";
            this.newEquipmentButton.Size = new System.Drawing.Size(75, 23);
            this.newEquipmentButton.TabIndex = 5;
            this.newEquipmentButton.Text = "Добавить";
            this.newEquipmentButton.UseVisualStyleBackColor = true;
            this.newEquipmentButton.Click += new System.EventHandler(this.newEquipment_Click);
            // 
            // equipmentDGV
            // 
            this.equipmentDGV.AllowUserToAddRows = false;
            this.equipmentDGV.AllowUserToDeleteRows = false;
            this.equipmentDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.equipmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.equipmentDGV.Location = new System.Drawing.Point(3, 33);
            this.equipmentDGV.MultiSelect = false;
            this.equipmentDGV.Name = "equipmentDGV";
            this.equipmentDGV.RowHeadersVisible = false;
            this.equipmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentDGV.Size = new System.Drawing.Size(749, 367);
            this.equipmentDGV.TabIndex = 1;
            this.equipmentDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentDGV_CellDoubleClick);
            // 
            // clientListTab
            // 
            this.clientListTab.Controls.Add(this.delClient);
            this.clientListTab.Controls.Add(this.serachButton);
            this.clientListTab.Controls.Add(this.serachTextBox);
            this.clientListTab.Controls.Add(this.newClient);
            this.clientListTab.Controls.Add(this.clientDGV);
            this.clientListTab.Location = new System.Drawing.Point(4, 22);
            this.clientListTab.Name = "clientListTab";
            this.clientListTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientListTab.Size = new System.Drawing.Size(836, 403);
            this.clientListTab.TabIndex = 0;
            this.clientListTab.Text = "Клиенты";
            // 
            // delClient
            // 
            this.delClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delClient.Location = new System.Drawing.Point(758, 62);
            this.delClient.Name = "delClient";
            this.delClient.Size = new System.Drawing.Size(75, 23);
            this.delClient.TabIndex = 4;
            this.delClient.Text = "Удалить";
            this.delClient.UseVisualStyleBackColor = true;
            this.delClient.Click += new System.EventHandler(this.delClient_Click);
            // 
            // serachButton
            // 
            this.serachButton.Location = new System.Drawing.Point(258, 6);
            this.serachButton.Name = "serachButton";
            this.serachButton.Size = new System.Drawing.Size(75, 20);
            this.serachButton.TabIndex = 3;
            this.serachButton.Text = "Поиск";
            this.serachButton.UseVisualStyleBackColor = true;
            this.serachButton.Click += new System.EventHandler(this.serachButton_Click);
            // 
            // serachTextBox
            // 
            this.serachTextBox.Location = new System.Drawing.Point(3, 7);
            this.serachTextBox.Name = "serachTextBox";
            this.serachTextBox.Size = new System.Drawing.Size(249, 20);
            this.serachTextBox.TabIndex = 2;
            // 
            // newClient
            // 
            this.newClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newClient.Location = new System.Drawing.Point(758, 33);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(75, 23);
            this.newClient.TabIndex = 1;
            this.newClient.Text = "Добавить";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // clientDGV
            // 
            this.clientDGV.AllowUserToAddRows = false;
            this.clientDGV.AllowUserToDeleteRows = false;
            this.clientDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clientDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientDGV.Location = new System.Drawing.Point(3, 33);
            this.clientDGV.MultiSelect = false;
            this.clientDGV.Name = "clientDGV";
            this.clientDGV.RowHeadersVisible = false;
            this.clientDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDGV.Size = new System.Drawing.Size(749, 367);
            this.clientDGV.TabIndex = 0;
            this.clientDGV.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clientDGV_CellMouseDoubleClick);
            // 
            // clientControl1
            // 
            this.clientControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl1.Location = new System.Drawing.Point(3, 3);
            this.clientControl1.Name = "clientControl1";
            this.clientControl1.Size = new System.Drawing.Size(830, 397);
            this.clientControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 429);
            this.Controls.Add(this.ListTab);
            this.Name = "Main";
            this.Text = "BikeStreet";
            this.ListTab.ResumeLayout(false);
            this.contractListTab.ResumeLayout(false);
            this.contractListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractDGV)).EndInit();
            this.editClientTab.ResumeLayout(false);
            this.equipmentListTab.ResumeLayout(false);
            this.equipmentListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).EndInit();
            this.clientListTab.ResumeLayout(false);
            this.clientListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl ListTab;
        private System.Windows.Forms.TabPage clientListTab;
        private System.Windows.Forms.DataGridView clientDGV;
        private System.Windows.Forms.TabPage editClientTab;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.Button serachButton;
        private System.Windows.Forms.TextBox serachTextBox;
        private System.Windows.Forms.TabPage equipmentListTab;
        private System.Windows.Forms.DataGridView equipmentDGV;
        private System.Windows.Forms.Button delClient;
        private System.Windows.Forms.Button delEquipmentButton;
        private System.Windows.Forms.Button newEquipmentButton;
        private clientControl clientControl1;
        private System.Windows.Forms.TabPage contractListTab;
        private System.Windows.Forms.DataGridView contractDGV;
        private System.Windows.Forms.Button returnedButton;
        private System.Windows.Forms.Button newContractButton;
        private System.Windows.Forms.Button editEquipmentButton;
        private System.Windows.Forms.CheckBox returnedCheckBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serachEquipTextBox;
        private System.Windows.Forms.CheckBox inStockCheckBox;
        private System.Windows.Forms.DateTimePicker periodDateTimePicker;
    }
}

