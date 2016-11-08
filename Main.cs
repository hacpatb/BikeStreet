using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BikeStreet
{
    public partial class Main : Form
    {
        cClient currentClient = new cClient();
        BindingSource bindsrcClient = new BindingSource(); //источник для DataGrid для клиентов
        clientList clientList = new clientList(); //список слинетов*/

        BindingSource bindsrcEquipment = new BindingSource(); //источник для DataGrid для оборудования
        equipmentList equipmentList = new equipmentList(); //список оборудования

        BindingSource bindsrcContract = new BindingSource(); //источник для DataGrid для контрактов
        listHire contractList = new listHire(); //список взятого оборудования для клиента

        public Main()
        {
            InitializeComponent();
           
            #region Client Grid View
            bindsrcClient.DataSource = clientList.clients;
            clientDGV.AutoGenerateColumns = false;
            clientDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] clientDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "fio", "fio", "ФИО", 150),
                new dgvDescription(0, "phone", "phone", "Телефон", 120),
                new dgvDescription(0, "address", "address", "Адрес", 200),
                new dgvDescription(0, "passport", "passport", "Паспортные данные", 180),
            };
            trash.makeDataGridColumns(clientDGV, clientDGVdsc);
            clientDGV.DataSource = bindsrcClient;
           // viewClient();
            #endregion

            #region Equipment Grid View
           
            bindsrcEquipment.DataSource = equipmentList.equipments;
            equipmentDGV.AutoGenerateColumns = false;
            equipmentDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] equipmentDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "brand", "brand", "Марка", 130),
                new dgvDescription(0, "model", "model", "Модель", 140),
                new dgvDescription(0, "color", "color", "Цвет", 140),
                new dgvDescription(0, "size", "size", "Размер", 40),
                new dgvDescription(0, "number", "number", "Сер №", 140),
                new dgvDescription(0, "in_stock", "in_stock", "Остаток", 45)

            };
            trash.makeDataGridColumns(equipmentDGV, equipmentDGVdsc,true);
            equipmentDGV.DataSource = bindsrcEquipment;
            viewEquipment();

            #endregion

            #region Contract Grid View
           // contractList.getList(-1);
            bindsrcContract.DataSource = contractList.viewHireList;
            contractDGV.AutoGenerateColumns = false;
            contractDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] contractDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "fio", "fio", "Клиент", 2),
                new dgvDescription(0, "phone", "phone", "Тельчик", 2),
                new dgvDescription(0, "all_equip", "all_equip", "Что взял", 6),
                new dgvDescription(0, "megaDATE", "megaDATE", "С/По", 2)

            };
            trash.makeDataGridColumns(contractDGV, contractDGVdsc, true);
            contractDGV.DataSource = bindsrcContract;
            viewContract();
            periodDateTimePicker.Value = DateTime.Now.Date;
            #endregion

            // mainTab.TabPages.Remove(editClientTab);
            ListTab.TabPages.Remove(clientListTab);

            
        }
        #region Клиенты
        public void viewClient()
        {
            clientDGV.Rows.Clear();
            clientList.getClientList(searchByAllFields: serachTextBox.Text);
            bindsrcClient.ResetBindings(true);
            clientDGV.Refresh();
        }
        private void clientDGV_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (clientDGV.SelectedCells.Count > 0)
            {
                TabPage newTabPage = new TabPage();
                currentClient = clientDGV.Rows[clientDGV.SelectedCells[0].RowIndex].DataBoundItem as cClient;
                clientControl newClient = new clientControl(currentClient);
                newTabPage.Controls.Add(newClient);
                newTabPage.Text = currentClient.fio;
                ListTab.TabPages.Insert(ListTab.TabCount, newTabPage);
                ListTab.SelectedTab = newTabPage;
            }
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            TabPage newTabPage = new TabPage();
            clientControl newClient = new clientControl();
            newTabPage.Controls.Add(newClient);
            newTabPage.Text = "Новый клиент";
            ListTab.TabPages.Insert(ListTab.TabCount, newTabPage);
            ListTab.SelectedTab = newTabPage;
        }

        private void serachButton_Click(object sender, EventArgs e)
        {
                viewClient();
        }

        private void delClient_Click(object sender, EventArgs e)
        {
          
        }
        #endregion

        #region Оборудование

        private void initType()
        {
            List<cType> typeList = cType.getType();
            typeComboBox.DataSource = typeList;
            typeComboBox.ValueMember = "id_type";
            typeComboBox.DisplayMember = "name";
        }
        public void viewEquipment()
        {
            if (typeComboBox.SelectedItem != null)
            {
                int type = ((cType)typeComboBox.SelectedItem).id_type;
                equipmentDGV.Rows.Clear();
                equipmentList.getEquipmentList(searchByAllFields: serachEquipTextBox.Text, inStock: (inStockCheckBox.Checked) ? 1 : -2, type: type);
                bindsrcEquipment.ResetBindings(true);
                //equipmentDGV.Refresh();
            }
        }

        private void newEquipment_Click(object sender, EventArgs e)
        {
            addEquipmentForm AEF = new addEquipmentForm();
            AEF.Owner = this;
            AEF.ShowDialog();
            viewEquipment();
        }

        private void delEquipment_Click(object sender, EventArgs e)
        {
            if (equipmentDGV.SelectedCells.Count > 0)
            {
                cEquipment currentEquioment = new cEquipment((equipmentDGV.Rows[equipmentDGV.SelectedCells[0].RowIndex].DataBoundItem as cEquipment).id_equipment);
                DialogResult result = MessageBox.Show("Вы действительно хотите удалить это?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    currentEquioment.delete();
                    viewEquipment();
                } 
            }
        }

        private void editEquipmentButton_Click(object sender, EventArgs e)
        {
            cEquipment currentEquioment = new cEquipment((equipmentDGV.Rows[equipmentDGV.SelectedCells[0].RowIndex].DataBoundItem as cEquipment).id_equipment);
            addEquipmentForm AEF = new addEquipmentForm(currentEquioment);
            AEF.Owner = this;
            AEF.ShowDialog();
            viewEquipment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewEquipment();
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            viewEquipment();
        }

        private void inStockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            viewEquipment();
        }

        private void equipmentDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editEquipmentButton.PerformClick();
        }

        private void serachEquipTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) viewEquipment();
        }

        #endregion

        #region Контракты

        public void viewContract()
        {
            contractDGV.Rows.Clear();
      
            int period = (int)(periodDateTimePicker.Value - new DateTime(1970, 1, 1)).TotalSeconds;

            //лимит 60 строк
            contractList.getList(-1,returned: (returnedCheckBox.Checked) ? -1 : -2, period: period);
            bindsrcContract.ResetBindings(true);
           // contractDGV.Refresh();
        }

        private void periodDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            viewContract();
        }

        private void returnedButton_Click(object sender, EventArgs e)
        {
            if (contractDGV.SelectedCells.Count > 0)
            {
                cContractsHire currentContract = new cContractsHire((contractDGV.Rows[contractDGV.SelectedCells[0].RowIndex].DataBoundItem as viewHire).id_contract_hire);
                if (currentContract.returned != 1)
                {
                    currentContract.returned = 1;
                    currentContract.save();
                    foreach (cEquipment i in currentContract.getEquipment()) {
                        i.addStock();
                    }

                    viewContract();
                }
            }
        }

        private void contractDGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = (sender as DataGridView);
            if ((e.RowIndex > -1) && (e.RowIndex < grid.RowCount))
            {
              
                int color = (contractDGV.Rows[e.RowIndex].DataBoundItem as viewHire).returned;
                if (color == 1) contractDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                else contractDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
            
        }
        private void contractDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed);
                Rectangle r = dgv.GetRowDisplayRectangle(e.RowIndex, false);
                var rect = new Rectangle(r.X , r.Y, width - 1, r.Height - 1);
                ControlPaint.DrawBorder(e.Graphics, rect,
                    Color.Black, 0, ButtonBorderStyle.Solid,
                    Color.Black, 2, ButtonBorderStyle.Solid,
                    Color.Black, 0, ButtonBorderStyle.Solid,
                    Color.Black, 2, ButtonBorderStyle.Solid);
            }
        }

        private void newContractButton_Click(object sender, EventArgs e)
        {
            ListTab.SelectTab("editClientTab");
        }

        private void returnedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            viewContract();
        }

        #endregion

        private void ListTab_Selected(object sender, TabControlEventArgs e)
        {
            //обновить при выбори табы
            if(ListTab.SelectedTab.Name == "contractListTab") viewContract();
            if (ListTab.SelectedTab.Name == "equipmentListTab")
            {
                viewEquipment();
                initType();

            }
        }

        private void contractDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((contractDGV.CurrentRow != null) && (e.RowIndex == contractDGV.CurrentRow.Index))
            {
                double _coef = 0.95; //Коэффициент оттенения
                Color _color = contractDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                if (_color.R == 0 && _color.G == 0 && _color.B == 0)
                    _color = Color.White;
                int _r = (Math.Round(_color.R * _coef) > 255 ? 255 : (int)Math.Round(_color.R * _coef)),
                    _g = (Math.Round(_color.G * _coef) > 255 ? 255 : (int)Math.Round(_color.G * _coef)),
                    _b = (Math.Round(_color.B * _coef) > 255 ? 255 : (int)Math.Round(_color.B * _coef));
                contractDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, _r, _g, _b);
            }
        }

    }
}
