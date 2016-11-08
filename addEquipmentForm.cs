using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BikeStreet
{
    public partial class addEquipmentForm : Form
    {
        cEquipment currentEquip = new cEquipment();
        public addEquipmentForm()
        {
            InitializeComponent();
            initType();
           
        }
        public addEquipmentForm(cEquipment equipment)
        {
            InitializeComponent();
            initType();
            currentEquip = equipment;
            iniEquipment();

        }
        private void initType()
        {
            List<cType> typeList= cType.getType();
            typeComboBox.DataSource = typeList;
            typeComboBox.ValueMember = "id_type";
            typeComboBox.DisplayMember = "name";

        }

        private void iniEquipment()
        {
            brandTextBox.Text = currentEquip.brand;
            modelTextBox.Text = currentEquip.model;
            sizeTextBox.Text = currentEquip.size;
            colorTextBox.Text = currentEquip.color;
            costNumeric.Value = (decimal)currentEquip.cost; 
            numberTextBox.Text = currentEquip.number;
            inStockNumeric.Value = currentEquip.in_stock;
            typeComboBox.SelectedValue = currentEquip.type;
        }

        private void saveEquip()
        {
            currentEquip.brand = brandTextBox.Text;
            currentEquip.model = modelTextBox.Text;
            currentEquip.size = sizeTextBox.Text.Replace(',','.');
            currentEquip.color = colorTextBox.Text;
            currentEquip.cost = (double)costNumeric.Value;
            currentEquip.number = numberTextBox.Text;
            currentEquip.in_stock = (int)inStockNumeric.Value;
            currentEquip.type = (int)typeComboBox.SelectedValue;
            if (currentEquip.save()) { MessageBox.Show("Сохранилось, збс", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            iniEquipment();
        }

        private void closeEquipment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validate()
        {
            if (String.IsNullOrEmpty(brandTextBox.Text) || String.IsNullOrEmpty(sizeTextBox.Text)) return false;
            return true;
        }
        
        private void saveEquipment_Click(object sender, EventArgs e)
        {

            if(validate()) saveEquip();
            else MessageBox.Show("Заполни обязательные поля", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // this.Close();
        }
    }
}
