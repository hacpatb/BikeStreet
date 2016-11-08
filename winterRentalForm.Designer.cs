namespace BikeStreet
{
    partial class winterRentalForm
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
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.periodBox = new System.Windows.Forms.GroupBox();
            this.addDayButton = new System.Windows.Forms.Button();
            this.endTime = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.Label();
            this.endDateTime = new System.Windows.Forms.DateTimePicker();
            this.saveHireButtom = new System.Windows.Forms.Button();
            this.printContract = new System.Windows.Forms.Button();
            this.equipmentDGV = new System.Windows.Forms.DataGridView();
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.delEquipmentButton = new System.Windows.Forms.Button();
            this.pledgeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rentNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.periodBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateTime
            // 
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTime.Location = new System.Drawing.Point(33, 19);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(146, 20);
            this.startDateTime.TabIndex = 1;
            // 
            // periodBox
            // 
            this.periodBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.periodBox.Controls.Add(this.addDayButton);
            this.periodBox.Controls.Add(this.endTime);
            this.periodBox.Controls.Add(this.startTime);
            this.periodBox.Controls.Add(this.endDateTime);
            this.periodBox.Controls.Add(this.startDateTime);
            this.periodBox.Location = new System.Drawing.Point(12, 212);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(300, 93);
            this.periodBox.TabIndex = 21;
            this.periodBox.TabStop = false;
            this.periodBox.Text = "Период";
            // 
            // addDayButton
            // 
            this.addDayButton.Location = new System.Drawing.Point(198, 19);
            this.addDayButton.Name = "addDayButton";
            this.addDayButton.Size = new System.Drawing.Size(75, 23);
            this.addDayButton.TabIndex = 3;
            this.addDayButton.Text = "+ День";
            this.addDayButton.UseVisualStyleBackColor = true;
            this.addDayButton.Click += new System.EventHandler(this.addDayButton_Click);
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Location = new System.Drawing.Point(6, 59);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(21, 13);
            this.endTime.TabIndex = 21;
            this.endTime.Text = "По";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(6, 22);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(14, 13);
            this.startTime.TabIndex = 21;
            this.startTime.Text = "С";
            // 
            // endDateTime
            // 
            this.endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTime.Location = new System.Drawing.Point(33, 56);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(146, 20);
            this.endDateTime.TabIndex = 2;
            // 
            // saveHireButtom
            // 
            this.saveHireButtom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveHireButtom.Location = new System.Drawing.Point(21, 318);
            this.saveHireButtom.Name = "saveHireButtom";
            this.saveHireButtom.Size = new System.Drawing.Size(75, 23);
            this.saveHireButtom.TabIndex = 6;
            this.saveHireButtom.Text = "В прокат!!1";
            this.saveHireButtom.UseVisualStyleBackColor = true;
            this.saveHireButtom.Click += new System.EventHandler(this.saveHireButtom_Click);
            // 
            // printContract
            // 
            this.printContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.printContract.Enabled = false;
            this.printContract.Location = new System.Drawing.Point(237, 318);
            this.printContract.Name = "printContract";
            this.printContract.Size = new System.Drawing.Size(75, 23);
            this.printContract.TabIndex = 7;
            this.printContract.Text = "Печать";
            this.printContract.UseVisualStyleBackColor = true;
            this.printContract.Click += new System.EventHandler(this.printContract_Click);
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
            this.equipmentDGV.Location = new System.Drawing.Point(12, 12);
            this.equipmentDGV.MultiSelect = false;
            this.equipmentDGV.Name = "equipmentDGV";
            this.equipmentDGV.RowHeadersVisible = false;
            this.equipmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentDGV.Size = new System.Drawing.Size(767, 194);
            this.equipmentDGV.TabIndex = 25;
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addEquipmentButton.Location = new System.Drawing.Point(785, 12);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(75, 35);
            this.addEquipmentButton.TabIndex = 26;
            this.addEquipmentButton.Text = "Добавить экипировку";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // delEquipmentButton
            // 
            this.delEquipmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delEquipmentButton.Location = new System.Drawing.Point(785, 169);
            this.delEquipmentButton.Name = "delEquipmentButton";
            this.delEquipmentButton.Size = new System.Drawing.Size(75, 37);
            this.delEquipmentButton.TabIndex = 27;
            this.delEquipmentButton.Text = "Убрать экипировку";
            this.delEquipmentButton.UseVisualStyleBackColor = true;
            this.delEquipmentButton.Click += new System.EventHandler(this.delEquipmentButton_Click);
            // 
            // pledgeComboBox
            // 
            this.pledgeComboBox.FormattingEnabled = true;
            this.pledgeComboBox.Items.AddRange(new object[] {
            "Паспорт РФ",
            "Водительское удостоверение",
            "Деньги",
            "Пенсионное удостоверение",
            "Загранпаспорт"});
            this.pledgeComboBox.Location = new System.Drawing.Point(414, 228);
            this.pledgeComboBox.Name = "pledgeComboBox";
            this.pledgeComboBox.Size = new System.Drawing.Size(201, 21);
            this.pledgeComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Предмет залога";
            // 
            // rentNumeric
            // 
            this.rentNumeric.Location = new System.Drawing.Point(414, 255);
            this.rentNumeric.Maximum = new decimal(new int[] {
            66666666,
            0,
            0,
            0});
            this.rentNumeric.Name = "rentNumeric";
            this.rentNumeric.Size = new System.Drawing.Size(91, 20);
            this.rentNumeric.TabIndex = 5;
            this.rentNumeric.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Арендная плата";
            // 
            // winterRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 353);
            this.Controls.Add(this.rentNumeric);
            this.Controls.Add(this.pledgeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printContract);
            this.Controls.Add(this.delEquipmentButton);
            this.Controls.Add(this.addEquipmentButton);
            this.Controls.Add(this.equipmentDGV);
            this.Controls.Add(this.saveHireButtom);
            this.Controls.Add(this.periodBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "winterRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Зимний прокат";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winterRental_FormClosing);
            this.Load += new System.EventHandler(this.winterRental_Load);
            this.periodBox.ResumeLayout(false);
            this.periodBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.GroupBox periodBox;
        private System.Windows.Forms.Label endTime;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.DateTimePicker endDateTime;
        private System.Windows.Forms.Button saveHireButtom;
        private System.Windows.Forms.Button printContract;
        private System.Windows.Forms.DataGridView equipmentDGV;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.Button delEquipmentButton;
        private System.Windows.Forms.ComboBox pledgeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rentNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addDayButton;
    }
}