//using Finisar.SQLite;
using System.Data.SQLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BikeStreet
{
    public class cEquipment
    {
        public int id_equipment { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public string number { get; set; }
        public double cost { get; set; }
        public int in_stock { get; set; }
        public int type { get; set; }

        public cEquipment()
        {
            id_equipment = -1;
        }

        public cEquipment(int id)
        {
            id_equipment = -1;

            db db = new db();
            SQLiteDataReader dbRdr;

            try
            {
                if (!db.dbOpen()) throw new Exception();
                dbRdr = db.getReader("SELECT * FROM equipments WHERE id_equipment = " + id);
                dbRdr.Read();

                setEquipment(dbRdr);

                dbRdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения из базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id_equipment = -1;
            }
            finally { db.dbClose(); }
        }


        public void setEquipment(SQLiteDataReader dbRdr)
        {
            id_equipment = Convert.ToInt32(dbRdr["id_equipment"]);
            brand = Convert.ToString(dbRdr["brand"]);
            model = Convert.ToString(dbRdr["model"]);
            color = Convert.ToString(dbRdr["color"]);
            size = Convert.ToString(dbRdr["size"]);
            number = Convert.ToString(dbRdr["number"]);
            cost = Convert.ToDouble(dbRdr["cost"]);
            in_stock = Convert.ToInt32(dbRdr["in_stock"]);
            type = Convert.ToInt32(dbRdr["type"]);
        }

    public string getQuery(string type)
        {
            string formatQuery = "";

            switch (type)
            {
                case "i":
                    formatQuery = "INSERT INTO equipments (brand, model, color, size, number, cost, in_stock, type ) "
                        + "VALUES (@brand, @model, @color, @size, @number, @cost, @in_stock, @type)";
                    break;
                case "u":
                    formatQuery = "UPDATE equipments SET brand = @brand , model=@model, color = @color, size = @size, number = @number, cost = @cost, in_stock = @in_stock, type = @type " +
                                "WHERE id_equipment = {0}";
                    break;
            }
            return string.Format(formatQuery, id_equipment);
        }

        public bool save()
        {
            db db = new db();
            if (!db.dbOpen()) return false;

            string saveQuery = "";

            if (id_equipment < 0) saveQuery = getQuery("i");
            else saveQuery = getQuery("u");

            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@brand", brand),
                    new DictionaryEntry("@model", model), 
                    new DictionaryEntry("@color", color),
                    new DictionaryEntry("@size", size),
                    new DictionaryEntry("@number", number),
                    new DictionaryEntry("@cost", cost),
                    new DictionaryEntry("@in_stock", in_stock),
                    new DictionaryEntry("@type", type)

                ))
            { db.dbClose(); return false; }
            if (id_equipment < 0)
            {
                id_equipment = Convert.ToInt32(db.executeScalar("SELECT last_insert_rowid()"));
            }
            db.dbClose();

            return true;
        }

        public bool delete()
        {
            db db = new db();
            if (!db.dbOpen()) return false;
            if (!db.executeQuery("DELETE FROM equipments WHERE id_equipment = " + id_equipment)) { db.dbClose(); return false; }
            db.dbClose();
            return true;
        }

        public bool reduceStock()
        {
            db db = new db();
            if (!db.dbOpen()) return false;

            string saveQuery = string.Format("UPDATE equipments SET in_stock = @in_stock  WHERE id_equipment = {0}", id_equipment);


            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@in_stock", in_stock - 1)
                ))
            { db.dbClose(); return false; }
            db.dbClose();

            return true;
        }

        public bool addStock()
        {
            db db = new db();
            if (!db.dbOpen()) return false;
            in_stock = Convert.ToInt32(db.executeScalar(string.Format("SELECT in_stock FROM equipments WHERE id_equipment = {0}", id_equipment)));

            string saveQuery = string.Format("UPDATE equipments SET in_stock = @in_stock  WHERE id_equipment = {0}", id_equipment);
            

            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@in_stock", in_stock + 1)
                ))
            { db.dbClose(); return false; }
            db.dbClose();

            return true;
        }

        public bool addToContract(int equioment_in_contract)
        {
            db db = new db();
            if (!db.dbOpen()) return false;

            string saveQuery = string.Format("INSERT INTO equioments_in_contract(equioment_in_contract, id_equipment) "
                      + "VALUES (@equioment_in_contract, @id_equipment); UPDATE equipments SET in_stock = @in_stock  WHERE id_equipment = {0}", id_equipment); 

            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@equioment_in_contract", equioment_in_contract),
                    new DictionaryEntry("@id_equipment", id_equipment),
                    new DictionaryEntry("@in_stock", in_stock-1)
                ))
            { db.dbClose(); return false; }
           /* if (id_equipment < 0)
            {
                id_equipment = Convert.ToInt32(db.executeScalar("SELECT last_insert_rowid()"));
            }*/
            db.dbClose();

            return true;
        }

        public bool delInContract(int equipment_in_contract)
        {
            db db = new db();
            SQLiteDataReader dbRdr;
            if (!db.dbOpen()) return false;
            List<int> id_equip_in_contr = new List<int>();
            dbRdr = db.getReader(String.Format("SELECT id_equioment_in_contract FROM equioments_in_contract WHERE  id_equipment = {0} AND equioment_in_contract = {1};", id_equipment, equipment_in_contract));
            while (dbRdr.Read())
            {
                int id_equioment_in_contract = Convert.ToInt32(dbRdr["id_equioment_in_contract"]);
                id_equip_in_contr.Add(id_equioment_in_contract);
            }
            dbRdr.Close();
            string query = String.Format("DELETE FROM equioments_in_contract WHERE id_equipment = {0} AND equioment_in_contract = {1} AND id_equioment_in_contract = {2}; ", id_equipment, equipment_in_contract, id_equip_in_contr[0]);
            if (!db.executeParamQuery(query,
                   new DictionaryEntry("@in_stock", in_stock + 1)
               ))
            { db.dbClose(); return false; }
            db.dbClose();
            return true;
           // "UPDATE equipments SET in_stock = @in_stock WHERE id_equipment = {0} "
        }
    }
    class equipmentList
    {
        public ArrayList equipments;
        public equipmentList()
        {
            equipments = new ArrayList();
        }
        public void getEquipmentList(int equipment_in_contract)
        {
            db db;
            SQLiteDataReader dbRdr;
            cEquipment e;
            equipments.Clear();

            string query = "SELECT * FROM equipments ";
            query += "INNER JOIN equioments_in_contract ON equipments.id_equipment = equioments_in_contract.id_equipment ";
            query += string.Format("WHERE equioments_in_contract.equioment_in_contract = {0} ", equipment_in_contract);

            db = new db();
            try
            {
                if (!db.dbOpen()) throw new Exception("Ошибка подключения к БД.");
                dbRdr = db.getReader(query);
                while (dbRdr.Read())
                {
                    e = new cEquipment();
                    e.setEquipment(dbRdr);
                    equipments.Add(e);
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

        public void getEquipmentList(string searchByAllFields = "", int inStock = -2, int type = 0)
        {
            db db;
            SQLiteDataReader dbRdr;
            cEquipment e;
            equipments.Clear();
            string query = "SELECT * FROM equipments ";
            List<string> wheres = new List<string>();
            if (searchByAllFields != "") wheres.Add(String.Format("(brand || model || color || size || number) like '%{0}%'", searchByAllFields));
            if (inStock != -2) wheres.Add(String.Format("in_stock >= '{0}'", inStock));
            if(type != 0) wheres.Add(String.Format("type = '{0}'", type));
            if (wheres.Count > 0)
                query += "WHERE " + string.Join(" AND ", wheres.ToArray());
            db = new db();
            try
            {
                if (!db.dbOpen()) throw new Exception("Ошибка подключения к БД.");
                dbRdr = db.getReader(query);
                while (dbRdr.Read())
                {
                    e = new cEquipment();
                    e.setEquipment(dbRdr);
                    equipments.Add(e);
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
