using System;
using System.Collections.Generic;
using System.Windows.Forms;

//using Finisar.SQLite;
using System.Data.SQLite;
using System.Collections;

namespace BikeStreet
{
    public class cContractsHire
    {
        public int id_contract_hire { get; set; }
        public int id_client { get; set; }
        public int equipment_in_contract { get; set; }
        public string object_of_pledge { get; set; }
        public double rent { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public int returned { get; set; }

        public cContractsHire()
        {
            id_contract_hire = -1;
            returned = -1;
            db db = new db();
            if (db.dbOpen())
            {
                equipment_in_contract = 1 + Convert.ToInt32(db.executeScalar("SELECT equioment_in_contract FROM equioments_in_contract ORDER by equioment_in_contract DESC "));
            }
            db.dbClose();
        }

        public cContractsHire(int id)
        {
            id_contract_hire = -1;

            db db = new db();
            SQLiteDataReader dbRdr;

            try
            {
                if (!db.dbOpen()) throw new Exception();
                dbRdr = db.getReader("SELECT * FROM contracts_hire WHERE id_contract_hire = " + id);
                dbRdr.Read();

                setHire(dbRdr);

                dbRdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения из базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id_contract_hire = -1;
            }
            finally { db.dbClose(); }
        }

        public void setHire(SQLiteDataReader dbRdr)
        {
            id_contract_hire = Convert.ToInt32(dbRdr["id_contract_hire"]);
            id_client = Convert.ToInt32(dbRdr["id_client"]);
            equipment_in_contract = Convert.ToInt32(dbRdr["equipment_in_contract"]);
            object_of_pledge = Convert.ToString(dbRdr["object_of_pledge"]);
            rent = Convert.ToDouble(dbRdr["rent"]);
            start_time = Convert.ToInt32(dbRdr["start_time"]);
            end_time = Convert.ToInt32(dbRdr["end_time"]);
            returned = Convert.ToInt32(dbRdr["returned"]);
        }

        public string getQuery(string type)
        {
            string formatQuery = "";

            switch (type)
            {
                case "i":
                    formatQuery = "INSERT INTO contracts_hire (id_client, equipment_in_contract, start_time, end_time, returned, object_of_pledge, rent) "
                        + "VALUES (@id_client, @equipment_in_contract, @start_time, @end_time, @returned, @object_of_pledge, @rent) ";
                    break;
                case "u":
                    formatQuery = "UPDATE contracts_hire SET id_client = @id_client , equipment_in_contract = @equipment_in_contract, start_time = @start_time, end_time = @end_time, returned = @returned, object_of_pledge = @object_of_pledge, rent = @rent " +
                                "WHERE id_contract_hire = {0}";
                    break;
            }
            return string.Format(formatQuery, id_contract_hire);
        }

        public bool save()
        {
            db db = new db();
            if (!db.dbOpen()) return false;

            string saveQuery = "";

            if (id_contract_hire < 0) saveQuery = getQuery("i");
            else saveQuery = getQuery("u");

            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@id_client", id_client),
                    new DictionaryEntry("@equipment_in_contract", equipment_in_contract),
                    new DictionaryEntry("@object_of_pledge", object_of_pledge),
                    new DictionaryEntry("@rent", rent),
                    new DictionaryEntry("@start_time", start_time),
                    new DictionaryEntry("@end_time", end_time),
                    new DictionaryEntry("@returned", returned)
                ))
            { db.dbClose(); return false; }
            if (id_contract_hire < 0)
            {
                id_contract_hire = Convert.ToInt32(db.executeScalar("SELECT last_insert_rowid()"));
            }
            db.dbClose();

            return true;
        }

        public bool delete()
        {
            db db = new db();
            if (!db.dbOpen()) return false;
            if (!db.executeQuery("DELETE FROM contracts_hire WHERE id_contract_hire = " + id_contract_hire)) { db.dbClose(); return false; }
            db.dbClose();
            return true;
        }


        public List<cEquipment> getEquipment()
        {
            List<cEquipment> equipList = new List<cEquipment>();
            db db;
            SQLiteDataReader dbRdr;
            cEquipment equip;
            equipList.Clear();
            string query = "SELECT * FROM equipments ";
            query += "INNER JOIN equioments_in_contract ON equipments.id_equipment = equioments_in_contract.id_equipment ";
            query += String.Format("WHERE equioments_in_contract.equioment_in_contract = {0} ", equipment_in_contract);
            db = new db();
            try
            {
                if (!db.dbOpen()) throw new Exception("Ошибка подключения к БД.");
                dbRdr = db.getReader(query);
                while (dbRdr.Read())
                {
                    equip = new cEquipment();
                    equip.setEquipment(dbRdr);
                    equipList.Add(equip);
                }
                dbRdr.Close();
                db.dbClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения из базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.dbClose(); }


            return equipList;
        }
    }

    class viewHire
    {

        public int id_contract_hire { get; set; }
        public int id_client { get; set; }
        public int equipment_in_contract { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }

        public string megaDATE { get; set; }
  
        public string fio { get; set; }

        public string phone { get; set; }

        public string all_equip { get; set; }

        public int returned;

        public viewHire()
        {
            id_contract_hire = -1;
        }
        
        public void setView(SQLiteDataReader dbRdr)
        {
            id_contract_hire = Convert.ToInt32(dbRdr["id_contract_hire"]);
            id_client = Convert.ToInt32(dbRdr["id_client"]);
            id_contract_hire = Convert.ToInt32(dbRdr["id_contract_hire"]);
            DateTime sDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(Convert.ToInt32(dbRdr["start_time"]));
            start_time = sDate.ToString("dd-MM-yyyy HH:mm");

            DateTime eDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(Convert.ToInt32(dbRdr["end_time"]));
            end_time = eDate.ToString("dd-MM-yyyy HH:mm");

            megaDATE = "C " + start_time + System.Environment.NewLine + "По "+end_time;

   
            fio = Convert.ToString(dbRdr["fio"]);
            phone = Convert.ToString(dbRdr["phone"]);

            all_equip = Convert.ToString(dbRdr["all_equip"]).Replace(',','\n');

            returned = Convert.ToInt32(dbRdr["returned"]);
        }

    }

    class listHire
    {
        public List<viewHire> viewHireList;

        public listHire()
        {
            viewHireList = new List<viewHire>();
        }

        public void getList(int id_client, int returned = -2, int period = -1)
        {
            db db;
            SQLiteDataReader dbRdr;
            viewHire viewItem;
            viewHireList.Clear();
            string query = "SELECT *,GROUP_CONCAT('Бренд: ' || brand ||' - '|| model || ' Цвет: ' || color || '  Размер: ' || size ) as all_equip FROM contracts_hire ";
            query += "INNER JOIN equioments_in_contract ON contracts_hire.equipment_in_contract = equioments_in_contract.equioment_in_contract ";
            query += "INNER JOIN equipments ON equioments_in_contract.id_equipment = equipments.id_equipment  ";
            query += "INNER JOIN clients ON contracts_hire.id_client = clients.id_client ";
            List<string> wheres = new List<string>();

            if (id_client > 0) wheres.Add(String.Format("clients.id_client = {0} ", id_client));
            if (returned != -2) wheres.Add(String.Format("returned = {0} ", returned));
            if (period != -1) wheres.Add(String.Format("start_time >= {0} ", period));

            if (wheres.Count > 0)
                query += "WHERE " + string.Join(" AND ", wheres.ToArray());
            
            query += "GROUP by equioments_in_contract.equioment_in_contract ";
            query += "ORDER by start_time DESC ";
           // query += "LIMIT 60 ";
            db = new db();
            try
            {
                if (!db.dbOpen()) throw new Exception("Ошибка подключения к БД.");
                dbRdr = db.getReader(query);
                while (dbRdr.Read())
                {
                    viewItem = new viewHire();
                    viewItem.setView(dbRdr);
                    viewHireList.Add(viewItem);
                }
                dbRdr.Close();
                db.dbClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения из базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { db.dbClose(); }
        }
    }
}
