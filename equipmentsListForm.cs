using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BikeStreet
{
    public partial class equipmentsListForm : Form
    {
        BindingSource bindsrcEquipment = new BindingSource(); //источник для DataGrid для клиентов
        equipmentList equipmentList = new equipmentList(); //список слинетов

        cEquipment currentEquip = new cEquipment();

        int currentEquiomentInContract = -1;

        public equipmentsListForm(int equioment_in_contract)
        {
            
            InitializeComponent();
            currentEquiomentInContract = equioment_in_contract;
            #region Equipment Grid View
            equipmentList.getEquipmentList(inStock:1);
            bindsrcEquipment.DataSource = equipmentList.equipments;
            equipmentDGV.AutoGenerateColumns = false;
            equipmentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] equipmentDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "brand", "brand", "Марка", 2),
                new dgvDescription(0, "model", "model", "Модель", 2),
                new dgvDescription(0, "color", "color", "Цвет", 2),
                new dgvDescription(0, "size", "size", "Размер", 1),
                new dgvDescription(0, "number", "number", "Сер №", 2),
                new dgvDescription(0, "in_stock", "in_stock", "Остаток", 1),
            };
            trash.makeDataGridColumns(equipmentDGV, equipmentDGVdsc, true);
            equipmentDGV.DataSource = bindsrcEquipment;
            #endregion

            initType();
        }

        private void initType()
        {
            List<cType> typeList = cType.getType();
            typeComboBox.DataSource = typeList;
            typeComboBox.ValueMember = "id_type";
            typeComboBox.DisplayMember = "name";
        }

        public void viewEquipments()
        {
            int type = ((cType)typeComboBox.SelectedItem).id_type;
            equipmentDGV.Rows.Clear();
            equipmentList.getEquipmentList(searchByAllFields: serachTextBox.Text, inStock:1, type: type);
            bindsrcEquipment.ResetBindings(true);
            //equipmentDGV.Refresh();
        }

        private void chooseEquipButton_Click(object sender, EventArgs e)
        {
            if (equipmentDGV.SelectedCells.Count > 0)
            {
                currentEquip = equipmentDGV.Rows[equipmentDGV.SelectedCells[0].RowIndex].DataBoundItem as cEquipment;
                if (currentEquip.addToContract(currentEquiomentInContract))
                {
                    winterRentalForm frm = (winterRentalForm)this.Owner;
                    frm.viewEquipmentContract(frm.currentClient.id_client);
                    frm.IsSaved = false;
                }

            }
            viewEquipments();
        }

        private void serachButton_Click(object sender, EventArgs e)
        {
            viewEquipments();
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
             viewEquipments();
        }

        private void equipmentDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            chooseEquipButton.PerformClick();
        }

        private void serachTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void serachTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) viewEquipments();
        }
    }
}
