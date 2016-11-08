namespace BikeStreet
{
    partial class addEquipmentForm
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
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.saveEquipment = new System.Windows.Forms.Button();
            this.closeEquipment = new System.Windows.Forms.Button();
            this.inStockNumeric = new System.Windows.Forms.NumericUpDown();
            this.costNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // brandTextBox
            // 
            this.brandTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "BlackFire"});
            this.brandTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.brandTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.brandTextBox.Location = new System.Drawing.Point(137, 35);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(162, 20);
            this.brandTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(137, 61);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(162, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(137, 113);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(162, 20);
            this.colorTextBox.TabIndex = 5;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(137, 87);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(162, 20);
            this.sizeTextBox.TabIndex = 4;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(137, 139);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(162, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бренд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Размер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Цвет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Серийный номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Оценочная стоимость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Количество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Тип";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(137, 8);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(162, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // saveEquipment
            // 
            this.saveEquipment.Location = new System.Drawing.Point(12, 242);
            this.saveEquipment.Name = "saveEquipment";
            this.saveEquipment.Size = new System.Drawing.Size(75, 23);
            this.saveEquipment.TabIndex = 9;
            this.saveEquipment.Text = "Сохранить";
            this.saveEquipment.UseVisualStyleBackColor = true;
            this.saveEquipment.Click += new System.EventHandler(this.saveEquipment_Click);
            // 
            // closeEquipment
            // 
            this.closeEquipment.Location = new System.Drawing.Point(224, 242);
            this.closeEquipment.Name = "closeEquipment";
            this.closeEquipment.Size = new System.Drawing.Size(75, 23);
            this.closeEquipment.TabIndex = 10;
            this.closeEquipment.Text = "Закрыть";
            this.closeEquipment.UseVisualStyleBackColor = true;
            this.closeEquipment.Click += new System.EventHandler(this.closeEquipment_Click);
            // 
            // inStockNumeric
            // 
            this.inStockNumeric.Location = new System.Drawing.Point(137, 191);
            this.inStockNumeric.Name = "inStockNumeric";
            this.inStockNumeric.Size = new System.Drawing.Size(61, 20);
            this.inStockNumeric.TabIndex = 8;
            // 
            // costNumeric
            // 
            this.costNumeric.Location = new System.Drawing.Point(137, 165);
            this.costNumeric.Maximum = new decimal(new int[] {
            666666666,
            0,
            0,
            0});
            this.costNumeric.Name = "costNumeric";
            this.costNumeric.Size = new System.Drawing.Size(162, 20);
            this.costNumeric.TabIndex = 7;
            this.costNumeric.ThousandsSeparator = true;
            // 
            // addEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 280);
            this.Controls.Add(this.costNumeric);
            this.Controls.Add(this.inStockNumeric);
            this.Controls.Add(this.closeEquipment);
            this.Controls.Add(this.saveEquipment);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.brandTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addEquipmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Карточка снаряжения";
            ((System.ComponentModel.ISupportInitialize)(this.inStockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button saveEquipment;
        private System.Windows.Forms.Button closeEquipment;
        private System.Windows.Forms.NumericUpDown inStockNumeric;
        private System.Windows.Forms.NumericUpDown costNumeric;
    }
}