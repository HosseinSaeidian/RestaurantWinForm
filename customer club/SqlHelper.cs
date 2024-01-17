using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace customer_club.Class
{
    public static class SqlHelper
    {

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
                MessageBox.Show("Your connection to the database could not be established"  , "info" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }

        }


        public static void CommandMethod(string query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = ConnectionMethod();



        }







    }
}
