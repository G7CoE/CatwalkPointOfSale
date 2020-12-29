using System;
using System.Configuration;
using System.Data; 
using System.Data.SqlClient; 
using System.Threading.Tasks; 
 
namespace PointOfSale
{
    static class Helper
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        /// Set the connection, command, and then execute the command with non query. 
        public static Int32 ExecuteNonQuery(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect  
                    // type is only for OLE DB.   
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }

        /// Set the connection, command, and then execute the command and only return one value. 
        public static Object ExecuteScalar(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// Set the connection, command, and then execute the command with query and return the reader. 
        public static SqlDataReader ExecuteReader(String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the  
                // IDataReader is closed. 
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }

        public static DataTable LoadSql (string sql)
        {
            DataTable dt = new DataTable();
            dt.Load(Helper.ExecuteReader(sql, System.Data.CommandType.Text));
            return dt;
        }


        #region TypeParse
        public static decimal DecimalParse(string val)
        {
            if (decimal.TryParse(val, out decimal x))
                return x;
            else
                return 0;
        }

        public static decimal? NDecimalParse(string val)
        {
            if (decimal.TryParse(val, out decimal x))
                return x;
            else
                return null;
        }

        public static DateTime DateParse(string val)
        {
            if (DateTime.TryParse(val, out DateTime x))
                return x;
            else
                return DateTime.MinValue;
        }
        public static DateTime? NDateParse(string val)
        {
            if (DateTime.TryParse(val, out DateTime x))
            {
                if (x == DateTime.MinValue)
                    return null;
                else
                    return x;
            }
            else
                return null;
        }
        public static int? IntParse(string val)
        {
            if (Int32.TryParse(val, out int x))
                return x;
            else
                return 0;
        }

        public static int? NIntParse(string val)
        {
            if (Int32.TryParse(val, out int x))
                return x;
            else
                return null;
        }

		public static bool BoolParse(string val)
        {
            if (val == "1")
                return true;
            else
                return false;
        }

        #endregion
        public static T DirectCast<T>(object o) where T : class
        {
            T value = o as T;
            if (value == null && o != null)
            {
                throw new InvalidCastException();
            }
            return value;
        }
    }
}