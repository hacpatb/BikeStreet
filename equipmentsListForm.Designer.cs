namespace BikeStreet
{
    partial class equipmentsListForm
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
            this.equipmentDGV = new System.Windows.Forms.DataGridView();
            this.chooseEquipButton = new System.Windows.Forms.Button();
            this.serachTextBox = new System.Windows.Forms.TextBox();
            this.serachButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).BeginInit();
            this.SuspendLayout();
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
            this.equipmentDGV.Location = new System.Drawing.Point(12, 38);
            this.equipmentDGV.MultiSelect = false;
            this.equipmentDGV.Name = "equipmentDGV";
            this.equipmentDGV.RowHeadersVisible = false;
            this.equipmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentDGV.Size = new System.Drawing.Size(605, 187);
            this.equipmentDGV.TabIndex = 26;
            this.equipmentDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equipmentDGV_CellDoubleClick);
            // 
            // chooseEquipButton
            // 
            this.chooseEquipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseEquipButton.Location = new System.Drawing.Point(623, 38);
            this.chooseEquipButton.Name = "chooseEquipButton";
            this.chooseEquipButton.Size = new System.Drawing.Size(75, 38);
            this.chooseEquipButton.TabIndex = 27;
            this.chooseEquipButton.Text = "Выбрать снарягу";
            this.chooseEquipButton.UseVisualStyleBackColor = true;
            this.chooseEquipButton.Click += new System.EventHandler(this.chooseEquipButton_Click);
            // 
            // serachTextBox
            // 
            this.serachTextBox.Location = new System.Drawing.Point(12, 12);
            this.serachTextBox.Name = "serachTextBox";
            this.serachTextBox.Size = new System.Drawing.Size(179, 20);
            this.serachTextBox.TabIndex = 1;
            this.serachTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serachTextBox_KeyPress);
            this.serachTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.serachTextBox_KeyUp);
            // 
            // serachButton
            // 
            this.serachButton.Location = new System.Drawing.Point(197, 12);
            this.serachButton.Name = "serachButton";
            this.serachButton.Size = new System.Drawing.Size(75, 20);
            this.serachButton.TabIndex = 29;
            this.serachButton.Text = "Поиск";
            this.serachButton.UseVisualStyleBackColor = true;
            this.serachButton.Click += new System.EventHandler(this.serachButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(278, 11);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(153, 21);
            this.typeComboBox.TabIndex = 30;
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeComboBox_SelectedValueChanged);
            // 
            // equipmentsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 237);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.serachButton);
            this.Controls.Add(this.serachTextBox);
            this.Controls.Add(this.chooseEquipButton);
            this.Controls.Add(this.equipmentDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "equipmentsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список оборудования";
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView equipmentDGV;
        private System.Windows.Forms.Button chooseEquipButton;
        private System.Windows.Forms.TextBox serachTextBox;
        private System.Windows.Forms.Button serachButton;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}