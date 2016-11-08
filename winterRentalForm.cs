using System;
using System.Windows.Forms;

namespace BikeStreet
{
    public partial class winterRentalForm : Form
    {
        cContractsHire currentHire = new cContractsHire();
        public cClient currentClient = new cClient();

        BindingSource bindsrcEquipment = new BindingSource(); //источник для DataGrid для клиентов
        equipmentList equipmentList = new equipmentList(); //список слинетов

        cEquipment currentEquip = new cEquipment();

        public bool IsSaved = false;

        public winterRentalForm(cClient Client)
        {
            InitializeComponent();
            currentClient = Client;
            #region Equipment Grid View
            equipmentList.getEquipmentList(currentHire.equipment_in_contract);
            bindsrcEquipment.DataSource = equipmentList.equipments;
            equipmentDGV.AutoGenerateColumns = false;
            equipmentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] equipmentDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "brand", "brand", "Марка", 130),
                new dgvDescription(0, "model", "model", "Модель", 130),
                new dgvDescription(0, "color", "color", "Цвет", 140),
                new dgvDescription(0, "size", "size", "Размер", 140),
                new dgvDescription(0, "number", "number", "Сер №", 140),
                new dgvDescription(0, "cost", "cost", "Стоимость", 140),
            };
            trash.makeDataGridColumns(equipmentDGV, equipmentDGVdsc,true);
            equipmentDGV.DataSource = bindsrcEquipment;
            #endregion
        }

        public void viewEquipmentContract(int id_client)
        {
            equipmentDGV.Rows.Clear();
            equipmentList.getEquipmentList(currentHire.equipment_in_contract);
            bindsrcEquipment.ResetBindings(true);
           // equipmentDGV.Refresh();
        }

        private void winterRental_Load(object sender, EventArgs e)
        {
            startDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
            endDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        private void saveHireButtom_Click(object sender, EventArgs e)
        {
            var a = startDateTime.Value - endDateTime.Value;
            if (rentNumeric.Value == 0 || String.IsNullOrEmpty(pledgeComboBox.Text) || a.Hours == 0 || equipmentDGV.Rows.Count == 0)
                MessageBox.Show("Заполни обязательные поля", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else {
                currentHire.id_client = currentClient.id_client;
                currentHire.start_time = (int)(startDateTime.Value - new DateTime(1970, 1, 1)).TotalSeconds;
                currentHire.end_time = (int)(endDateTime.Value - new DateTime(1970, 1, 1)).TotalSeconds;
                currentHire.object_of_pledge = pledgeComboBox.Text;
                currentHire.rent = (double)rentNumeric.Value;
                if (currentHire.save())
                {
                    MessageBox.Show("Сохранилось, збс", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printContract.Enabled = true;
                    IsSaved = true;
                }
            }
        }

        private void printContract_Click(object sender, EventArgs e)
        {
            if (!IsSaved) MessageBox.Show("Что-то поменялось, сохраните ещё раз", "Изменения", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                cPrintContract p = new cPrintContract(currentClient, equipmentList, startDateTime, endDateTime, pledgeComboBox.Text, (double)rentNumeric.Value);
            }
        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            equipmentsListForm EL = new equipmentsListForm(currentHire.equipment_in_contract);
            EL.Owner = this;
            EL.ShowDialog();
        }

        private void delEquipmentButton_Click(object sender, EventArgs e)
        {
            if (equipmentDGV.SelectedCells.Count > 0)
            {
                currentEquip = equipmentDGV.Rows[equipmentDGV.SelectedCells[0].RowIndex].DataBoundItem as cEquipment;
                currentEquip.delInContract(currentHire.equipment_in_contract);
                currentEquip.addStock();
                IsSaved = false;
                viewEquipmentContract(currentClient.id_client);
            }
        }

        private void winterRental_FormClosing(object sender, FormClosingEventArgs e)
        {
            //При закрыт формы
            if(!IsSaved && equipmentDGV.Rows.Count > 0)
            {
                foreach (DataGridViewRow i in equipmentDGV.Rows)
                {
                    currentEquip = i.DataBoundItem as cEquipment;
                    currentEquip.addStock();
                }
                currentHire.delete();
            }

            if (equipmentDGV.Rows.Count == 0) currentHire.delete();
        }

        private void addDayButton_Click(object sender, EventArgs e)
        {
            endDateTime.Value = endDateTime.Value.AddDays(1);
        }
    }
}
