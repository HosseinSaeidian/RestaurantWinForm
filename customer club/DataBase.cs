using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace customer_club
{
    public class DataBase
    {



        public static SqlConnection ConnectionMethod()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = "data source = . ; initial catalog = FastFooddata ; Integrated Security = SSPI";
                connect.Open();
                return connect;
            }

            catch (Exception ex)
            {
                throw;

            }
        }

        public static SqlCommand CommandMethod(string query)
        {
            return CommandMethod(query , null);
        }

        public static SqlCommand CommandMethod(string query, params SqlParameter[] parameter)
        {

            SqlCommand command = new SqlCommand();
            if (parameter != null)
            command.Parameters.AddRange(parameter);
            command.CommandText = query;
            command.Connection = ConnectionMethod();
            return command;
        }


        public static SqlCommand CommandMethodThree(string query , string parameter , object value)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionMethod();
            command.CommandText = query;
            command.Parameters.AddWithValue(parameter, value);
            return command;
        }

        public static SqlDataReader ExecuteReader(string query)
        {
            return CommandMethod(query).ExecuteReader();
        }


        public static void ExecuteReader(string query, SqlParameter parameter)
        {
            CommandMethod(query, parameter).ExecuteReader();
        }


        public static void ExcuteNonQuery(string query)
        {
            CommandMethod(query).ExecuteNonQuery();
        }


        public static void ExcuteNonQuery(string query, params SqlParameter[] parameter)
        {
            CommandMethod(query, parameter).ExecuteNonQuery() ;
        
        }



    }
}
