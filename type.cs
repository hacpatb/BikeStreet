//using Finisar.SQLite;
using System.Data.SQLite;
using System;
using System.Collections.Generic;

namespace BikeStreet
{
    class cType
    {
        public int id_type { get; set; }
        public string name { get; set; }

        public cType()
        {
            id_type = -1;
        }

        public void setType(SQLiteDataReader dbRdr)
        {
            id_type = Convert.ToInt32(dbRdr["id_type"]);
            name = Convert.ToString(dbRdr["name"]);

        }

        public string getQuery(string type)
        {
            /* string formatQuery = "";

             switch (type)
             {
                 case "i":
                     formatQuery = "INSERT INTO Referens (OwnerRef, AliasRef, NameRef, ShortNameRef, TurnRef) "
                         + "VALUES (@OwnerRef, @AliasRef, @NameRef, @ShortNameRef, @TurnRef)";
                     break;
                 case "u":
                     formatQuery = "UPDATE Referens SET OwnerRef = @OwnerRef, AliasRef = @AliasRef, NameRef = @NameRef, ShortNameRef = @ShortNameRef, TurnRef = @TurnRef "
                     + "WHERE IdRef = {0}";
                     break;
             }
             return string.Format(formatQuery, id_type);*/
            return "kj";
        }

        public bool save()
        {
          /*  db db = new db(1);
            if (!db.dbOpen()) return false;

            string saveQuery = "";

            if (IdRef == -1) saveQuery = getQuery("i");
            else saveQuery = getQuery("u");

            if (!db.executeParamQuery(saveQuery, new DictionaryEntry("OwnerRef", OwnerRef), new DictionaryEntry("AliasRef", AliasRef), new DictionaryEntry("ShortNameRef", ShortNameRef), new DictionaryEntry("TurnRef", TurnRef), new DictionaryEntry("NameRef", NameRef))) { db.dbClose(); return false; }
            if (IdRef == -1) IdRef = commonFunctions.toInt(db.executeScalar("SELECT LAST_INSERT_ID()"));
            db.dbClose();*/
            return true;
        }

        public static List<cType> getType()
        {
            List<cType> lst = new List<cType>();
            SQLiteDataReader dbRdr;
            db db = new db();
            cType r;
            if (!db.dbOpen()) throw new Exception("Ошибка подключения к базе данных.");
            dbRdr = db.getReader("SELECT * FROM types");
            if (dbRdr == null) return lst;
            while (dbRdr.Read())
            {
                r = new cType();
                r.setType(dbRdr);
                lst.Add(r);
            }
            dbRdr.Close();
            db.dbClose();
            return lst;
        }
    }
  
}
