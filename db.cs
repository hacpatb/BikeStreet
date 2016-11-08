using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Finisar.SQLite;
using System.Data.SQLite;
//using System.Data.Common;
using System.Windows.Forms;
using System.Collections;
using System.Data;



namespace BikeStreet
{
    class db
    {
        private SQLiteConnection dbConn = null;
        private SQLiteCommand dbCmd = null;
       // private SQLiteTransaction dbTr = null;

        public db()
        {
            dbConn = new SQLiteConnection("Data Source=BikeStreeetBD.db; Version=3;");
            dbCmd = new SQLiteCommand();
        }

        public bool dbOpen()
        {
            if (dbConn == null) return false;
            try
            {
                dbConn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void dbClose()
        {
            try { dbConn.Close(); }
            catch { }
        }

        public SQLiteDataReader getReader(string query)
        {
            if (dbConn != null)
            {
                dbCmd.Connection = dbConn;
                dbCmd.CommandText = query;
                dbCmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    return dbCmd.ExecuteReader();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            return null;
        }
        public SQLiteDataAdapter getAdapter(string query)
        {
            return new SQLiteDataAdapter(query, (SQLiteConnection)dbConn);
        }
        public bool executeQuery(string query)
        {
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = query;
            dbCmd.CommandType = System.Data.CommandType.Text;

            try
            {
                dbCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        public bool executeParamQuery(string query, params DictionaryEntry[] args)
        {
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = query;
            dbCmd.CommandType = System.Data.CommandType.Text;
            dbCmd.Parameters.Clear();

            foreach (DictionaryEntry de in args)
            {
                DbType type = (DbType)Enum.Parse(typeof(DbType), de.Value.GetType().Name);
                SQLiteParameter param = new SQLiteParameter(de.Key.ToString(), type);
                param.Value = de.Value;
                dbCmd.Parameters.Add(param);
            }
            try
            {
                dbCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        public object executeScalar(string query)
        {
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = query;
            dbCmd.CommandType = System.Data.CommandType.Text;
            try
            {
                return dbCmd.ExecuteScalar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return null;
        }

    }
}
