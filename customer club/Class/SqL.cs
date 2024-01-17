using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace customer_club.Class
{
    public static class SqL
    {
        #region Dialog and Event

        public delegate void ConnectionMessageHandler();
        public event ConnectionMessageHandler OnMyEvent;

        #endregion



        #region Methods

        public static void ConnectionMethod()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = "data source = . ; initial catalog = FastFooddata ; Integrated Security = SSPI";
                connect.Open();
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public static void CommandMethod(string query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;



        }




        #endregion



    }
}
