using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Ultity
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

        public SqlConnection OpenDB()
        {
            conn = new SqlConnection(@"Server=DESKTOP-0NQ14HE\SQLEXPRESS;database=QLSVIEN;uid=sa;pwd=123");
            return conn;
        }
        public static void OpenConnection()
        {
            string sql= @"Server=DESKTOP-0NQ14HE\SQLEXPRESS;database=QLSVIEN;uid=sa;pwd=123";
            try
            {
                conn = new SqlConnection(sql);
                conn.Open();
            }catch(SqlException Ex)
            {
                throw new Exception(Ex.Message);
            }
        }
        public static void DisConnection()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public static DataTable getDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            da.Dispose();
            cmd.Dispose();
            return table;
        }
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
