using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace BikeStreet
{
    class cPrintContract
    {
        private Word.Application wordApp;
        private Word.Document doc;
        string brand, color, size, number;
        double cost=0;

        public cPrintContract(cClient client, cContractsHire contract)
        {
            equipmentList EL = new equipmentList();
            EL.getEquipmentList(contract.equipment_in_contract);
            DateTime startDateTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(contract.start_time);
            int startHours = startDateTime.Hour;
            int startMin = startDateTime.Minute;
            string startDay = startDateTime.Date.ToString("dd-MM-yyyy");
            string startDate = String.Format("с {0:00}:{1:00} {2} г., ", startHours, startMin, startDay);

            DateTime endDateTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(contract.end_time);
            int endHours = endDateTime.Hour;
            int endMin = endDateTime.Minute;
            string endDay = endDateTime.Date.ToString("dd-MM-yyyy");
            string endDate = String.Format("по {0:00}:{1:00} {2} г.", endHours, endMin, endDay);

            int length = EL.equipments.Count;
            string simb = "";

            foreach (cEquipment i in EL.equipments)
            {
                if (length != 1) simb = ", ";
                else simb = "";
                brand += (!string.IsNullOrEmpty(i.brand)) ? i.brand+"("+i.model+")" + simb : "";
                color += i.color + simb;
                size += i.size + simb;
                number += (!string.IsNullOrEmpty(i.number)) ? i.number + simb : "";
                cost += i.cost;
                length--;

            }
            try
            {
                wordApp = new Word.Application();
                doc = wordApp.Documents.Add(Application.StartupPath + @"\Dogovor_prokata_snaryazhenia.dotx");
                trash.replaceBookmark(doc, "date",DateTime.Now.Date.ToString("dd MMMM yyyyг."));
                trash.replaceBookmark(doc, "fio", " " + client.fio);
                trash.replaceBookmark(doc, "address", Environment.NewLine + client.address);
                trash.replaceBookmark(doc, "passport", Environment.NewLine + client.passport);
                trash.replaceBookmark(doc, "phone", client.phone);
                trash.replaceBookmark(doc, "brand", " " + brand);
                trash.replaceBookmark(doc, "color", " " + color);
                trash.replaceBookmark(doc, "size", " " + size);
                trash.replaceBookmark(doc, "number", " " + number);
                trash.replaceBookmark(doc, "cost", " " + String.Format("{0:N}  руб.", cost));
                trash.replaceBookmark(doc, "time", " " + startDate + endDate);
                trash.replaceBookmark(doc, "pledge", " " + contract.object_of_pledge);
                trash.replaceBookmark(doc, "rent", " " + String.Format("{0:N}  руб.", contract.rent));
                trash.replaceBookmark(doc, "date1", DateTime.Now.Date.ToString("dd MMMM yyyyг."));

                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка формирования счета", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doc = null;
                wordApp = null;
                GC.Collect();
            }

        }

        public cPrintContract(cClient client, equipmentList equipmentList, DateTimePicker startDateTime, DateTimePicker endDateTime, string pledge, double rent)
        {
            int startHours = startDateTime.Value.Hour;
            int startMin = startDateTime.Value.Minute;
            string startDay = startDateTime.Value.Date.ToString("dd-MM-yyyy");
            string startDate = String.Format("с {0:00}:{1:00} {2} г., ", startHours , startMin, startDay);

            int endHours = endDateTime.Value.Hour;
            int endMin = endDateTime.Value.Minute;
            string endDay = endDateTime.Value.Date.ToString("dd-MM-yyyy");
            string endDate = String.Format("по {0:00}:{1:00} {2} г.", endHours, endMin, endDay);

            int length = equipmentList.equipments.Count;
            string simb = "";

            foreach (cEquipment i in equipmentList.equipments)
            {
                if (length != 1) simb = ", ";
                else simb = "";
                brand += (!string.IsNullOrEmpty(i.brand)) ? i.brand + "(" + i.model + ")" + simb : "";
                color += i.color + simb; 
                size += i.size + simb;
                number += (!string.IsNullOrEmpty(i.number)) ? i.number + simb : "";
                cost += i.cost;
                length--;

            }
            try
            {
                wordApp = new Word.Application();
                doc = wordApp.Documents.Add(Application.StartupPath + @"\Dogovor_prokata_snaryazhenia.dotx");
                trash.replaceBookmark(doc, "date", DateTime.Now.Date.ToString("dd MMMM yyyyг."));
                trash.replaceBookmark(doc, "fio"," "+client.fio);
                trash.replaceBookmark(doc, "address", Environment.NewLine + client.address); 
                trash.replaceBookmark(doc, "passport", Environment.NewLine +client.passport);
                trash.replaceBookmark(doc, "phone", client.phone);
                trash.replaceBookmark(doc, "brand"," " + brand);
                trash.replaceBookmark(doc, "color"," " + color);
                trash.replaceBookmark(doc, "size"," " + size);
                trash.replaceBookmark(doc, "number"," " + number);
                trash.replaceBookmark(doc, "cost"," " + String.Format("{0:N}  руб.", cost));
                trash.replaceBookmark(doc, "time", " " + startDate+ endDate);
                trash.replaceBookmark(doc, "pledge", " " + pledge);
                trash.replaceBookmark(doc, "rent", " " + String.Format("{0:N}  руб.", rent));
                trash.replaceBookmark(doc, "date1", DateTime.Now.Date.ToString("dd MMMM yyyyг."));

                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка формирования счета", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doc = null;
                wordApp = null;
                GC.Collect();
            }
        }
    }
}
