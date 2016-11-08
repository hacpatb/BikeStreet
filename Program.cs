using System;
using System.Windows.Forms;
using System.Data;

namespace BikeStreet
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
       public static void connect()
        {
          /*  SQLiteConnection conn = new SQLiteConnection("Data Source=BikeStreeetBD.db; Version=3;");

            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE `lol` (`lol`	INTEGER);";
            cmd.ExecuteNonQuery();*/
        }
    }
}
