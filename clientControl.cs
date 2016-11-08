using System;
using System.Drawing;
using System.Windows.Forms;

namespace BikeStreet
{

    public partial class clientControl : UserControl
    {
        cClient currentClient = new cClient();
        BindingSource bindsrcClient = new BindingSource(); //источник для DataGrid для клиентов
        clientList clientList = new clientList(); //список слинетов

        BindingSource bindsrcHire = new BindingSource(); //источник для DataGrid для взятого оборудования
        listHire hireList = new listHire(); //список взятого оборудования для клиента

        public clientControl()
        {
            InitializeComponent();
            currentClient = new cClient();
           // initClient(); //Включить эту херню перед релизом и офнуть в клике по форме

            #region Rental Grid View
            
            bindsrcHire.DataSource = hireList.viewHireList;///список чего взял чел
            rentalDGV.AutoGenerateColumns = false;
            rentalDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDescription[] hireDGVdsc = new dgvDescription[]{
                new dgvDescription(0, "all_equip", "all_equip", "Что взял", 4),
                new dgvDescription(0, "megaDATE", "megaDATE", "С/По", 1),
            };
            trash.makeDataGridColumns(rentalDGV, hireDGVdsc, true);
            rentalDGV.DataSource = bindsrcHire;
            //viewHire();
            #endregion
        }

        public clientControl(cClient Client)
        {
           /* InitializeComponent();
            currentClient = Client;
            editClient();*/
        }

        public void viewHire(int id_client)
        {
            rentalDGV.Rows.Clear();
            hireList.getList(id_client);
            bindsrcHire.ResetBindings(true);
            rentalDGV.Refresh();
        }

        private void initClient()
        {
            fioComboBox.DataSource = null;
            fioComboBox.Items.Clear();
            bindsrcClient.DataSource = clientList.clients;
            clientList.getClientList();
            fioComboBox.DataSource = bindsrcClient;
            fioComboBox.DisplayMember = "fio";
            fioComboBox.ValueMember = "id_client";
            fioComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;


            //fioComboBox.Refresh();
        }

        private void saveClient_Click(object sender, EventArgs e)
        {
            currentClient.fio = fioComboBox.Text;
            currentClient.phone = phoneText.Text;
            currentClient.address = addressText.Text;
            currentClient.passport = passportText.Text;
           // (this.Parent as TabPage).Text = currentClient.fio;
            if(currentClient.save()) MessageBox.Show("Сохранилось, збс", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            initClient();
            editClient();
            winterRentalButton.Enabled = true;
        }

        void editClient()
        {
            fioComboBox.Text = currentClient.fio;
            phoneText.Text = currentClient.phone;
            addressText.Text = currentClient.address;
            passportText.Text = currentClient.passport;
            winterRentalButton.Enabled = true;
            saveClient.Enabled = true;
            viewHire(currentClient.id_client);
        }

        void clearClient()
        {
            currentClient = new cClient();
            phoneText.Text = addressText.Text = passportText.Text = fioComboBox.Text= "";
            rentalDGV.Rows.Clear();
        }

        private void closeClient_Click(object sender, EventArgs e)
        {
           /* TabControl parentTabPage = ((this.Parent as TabPage).Parent as TabControl);
            parentTabPage.TabPages.Remove(this.Parent as TabPage);*/
        }

        private void fioComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentClient = new cClient((int)fioComboBox.SelectedValue);
            editClient();
        }

        private void fioComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && fioComboBox.SelectedValue!= null)
            {
                currentClient = new cClient((int)fioComboBox.SelectedValue);
                editClient();
            }
            if (fioComboBox.Text.Length > 3) saveClient.Enabled = true;
            else saveClient.Enabled = false;

        }

        private void clientControl_Click(object sender, EventArgs e)
        {
            if (fioComboBox.Items.Count == 0)
            {
                initClient();
            }
        }

        private void newClient_Click(object sender, EventArgs e)
        {
            clearClient();
            saveClient.Enabled = false;
            winterRentalButton.Enabled = false;
        }

        private void winterRentalButton_Click(object sender, EventArgs e)
        {
            if (currentClient.id_client!=-1)
            {
                winterRentalForm wr = new winterRentalForm(currentClient);
                wr.ShowDialog();
                viewHire(currentClient.id_client);
            }
            else MessageBox.Show("Выбери клиента", "Клиент не клиент", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void rentalDGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridView grid = (sender as DataGridView);
            if ((e.RowIndex > -1) && (e.RowIndex < grid.RowCount))
            {
                int color = (rentalDGV.Rows[e.RowIndex].DataBoundItem as viewHire).returned;
                if (color == 1) rentalDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
                else rentalDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
            }
        }

        private void rentalDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.Rows[e.RowIndex].Selected)
            {
                int width = dgv.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed);
                Rectangle r = dgv.GetRowDisplayRectangle(e.RowIndex, false);
                var rect = new Rectangle(r.X, r.Y, width - 1, r.Height - 1);
                ControlPaint.DrawBorder(e.Graphics, rect,
                    Color.Black, 0, ButtonBorderStyle.Solid,
                    Color.Black, 2, ButtonBorderStyle.Solid,
                    Color.Black, 0, ButtonBorderStyle.Solid,
                    Color.Black, 2, ButtonBorderStyle.Solid);
            }
        }

        private void returnedButton_Click(object sender, EventArgs e)
        {
                if (rentalDGV.SelectedCells.Count > 0)
                {
                cContractsHire currentContract = new cContractsHire((rentalDGV.Rows[rentalDGV.SelectedCells[0].RowIndex].DataBoundItem as viewHire).id_contract_hire);
                    if (currentContract.returned != 1)
                    {
                        currentContract.returned = 1;
                        currentContract.save();
                        foreach (cEquipment i in currentContract.getEquipment())
                        {
                            i.addStock();
                        }

                        viewHire(currentClient.id_client);
                    }
            }
        }

        private void rentalDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((rentalDGV.CurrentRow != null) && (e.RowIndex == rentalDGV.CurrentRow.Index))
            {
                double _coef = 0.95; //Коэффициент оттенения
                Color _color = rentalDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                if (_color.R == 0 && _color.G == 0 && _color.B == 0)
                    _color = Color.White;
                int _r = (Math.Round(_color.R * _coef) > 255 ? 255 : (int)Math.Round(_color.R * _coef)),
                    _g = (Math.Round(_color.G * _coef) > 255 ? 255 : (int)Math.Round(_color.G * _coef)),
                    _b = (Math.Round(_color.B * _coef) > 255 ? 255 : (int)Math.Round(_color.B * _coef));
                rentalDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, _r, _g, _b);
            }
        }

        private void printContractButton_Click(object sender, EventArgs e)
        {
            if (rentalDGV.SelectedCells.Count > 0)
            {
                cContractsHire currentContract = new cContractsHire((rentalDGV.Rows[rentalDGV.SelectedCells[0].RowIndex].DataBoundItem as viewHire).id_contract_hire);
                cPrintContract PC = new cPrintContract(currentClient, currentContract);
            }
            
        }
    }
}
