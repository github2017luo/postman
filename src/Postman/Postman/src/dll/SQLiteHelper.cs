using System;
using System.Data;
using System.Data.SQLite;

namespace Postman.src.dll
{
    class SQLiteHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        private static string CONSTR = "Data Source=postman.db;Version=3;Pooling=False;Max Pool Size=100;";
        
        public static DataTable select(string statement)
        {
            DataTable result = null;
            using (SQLiteConnection con = new SQLiteConnection(CONSTR))
            {
                try
                {
                    con.Open();
                    DataTable temp = new DataTable();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(statement, con);
                    sda.Fill(temp);
                    result = temp;
                }
                catch (Exception ex)
                {
                    result = null;
                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }

        public static int execute(string statement)
        {
            int count = -1;
            using (SQLiteConnection con = new SQLiteConnection(CONSTR))
            {
                try
                {
                    con.Open();
                    SQLiteCommand com = new SQLiteCommand(statement, con);
                    count = com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    count = -1;
                }
                finally
                {
                    con.Close();
                }
            }
            return count;
        }
    }
}
