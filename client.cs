using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Collections;

namespace BikeStreet
{
    public class cClient
    {
        public int id_client { get; set; }
        public string fio { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string passport { get; set; }

        public cClient()
        {
            id_client = -1;
        }
        public cClient(int id)
        {
            id_client = -1;

            db db = new db();
            SQLiteDataReader dbRdr;

            try
            {
                if (!db.dbOpen()) throw new Exception();
                dbRdr = db.getReader("SELECT * FROM clients WHERE id_client = " + id);
                dbRdr.Read();

                setClient(dbRdr);

                dbRdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения из базы данных: " + ex.Message, "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id_client = -1;
            }
            finally { db.dbClose(); }
        }

        public void setClient(SQLiteDataReader dbRdr)
        {
            id_client = Convert.ToInt32(dbRdr["id_client"]);
            fio = Convert.ToString(dbRdr["fio"]);
            phone = Convert.ToString(dbRdr["phone"]);
            address = Convert.ToString(dbRdr["address"]);
            passport = Convert.ToString(dbRdr["passport"]);
        }

        public string getQuery(string type)
        {
            string formatQuery = "";

            switch (type)
            {
                case "i":
                    formatQuery = "INSERT INTO clients (fio, phone, address, passport )"
                        + "VALUES (@fio, @phone, @address, @passport)";
                    break;
                case "u":
                    formatQuery = "UPDATE clients SET fio = @fio , phone = @phone, address = @address, passport = @passport " +
                                "WHERE id_client = {0}";
                    break;
            }
            return string.Format(formatQuery, id_client);
        }
        
        public bool save()
        {
            db db = new db();
            if (!db.dbOpen()) return false;

            string saveQuery = "";

            if (id_client < 0) saveQuery = getQuery("i");
            else saveQuery = getQuery("u");

            if (!db.executeParamQuery(saveQuery,
                    new DictionaryEntry("@fio", fio),
                    new DictionaryEntry("@phone", phone),
                    new DictionaryEntry("@address", address),
                    new DictionaryEntry("@passport", passport)

                ))
            { db.dbClose(); return false; }
            if (id_client < 0)
            {
                id_client = Convert.ToInt32(db.executeScalar("SELECT last_insert_rowid()"));
            }
            db.dbClose();

            return true;
        }

        public bool delete()
        {
            db db = new db();
            if (!db.dbOpen()) return false;
            if (!db.executeQuery("DELETE FROM clients WHERE id_client = " + id_client)) { db.dbClose(); return false; }
            db.dbClose();
            return true;
        }
    }

    class clientList
    {
        public ArrayList clients;
        public clientList()
        {
            clients = new ArrayList();
        }

        public void getClientList(string searchByAllFields = "")
        {
            db db;
            SQLiteDataReader dbRdr;
            cClient c;
            clients.Clear();
            string query = "SELECT * FROM clients ";
            List<string> wheres = new List<string>();
            if(searchByAllFields!="") wheres.Add(String.Format("(fio || phone || address || passport) like '%{0}%'", searchByAllFields));
            if (wheres.Count > 0)
                query += "WHERE " + string.Join(" AND ", wheres.ToArray());

            query += " ORDER BY fio";

            db = new db();
            try
            {
                if (!db.dbOpen()) throw new Exception("Ошибка подключения к БД.");
                dbRdr = db.getReader(query);
                while (dbRdr.Read())
                {
                    c = new cClient();
                    c.setClient(dbRdr);
                    clients.Add(c);
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
