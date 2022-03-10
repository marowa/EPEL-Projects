using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EPEL_Projects.Data
{
    public class DataAccessLayer
    {
        public static DataTable ExecuteSelect(string query, Dictionary<string, object> parameter,
           bool isProcedure)
        {
            SqlConnection con = new SqlConnection("Data Source=68.71.130.74,1533;Initial Catalog=technyte_Shipping;User ID=IsraaCS;Password=xBx6_9a6;Encrypt=False");
            SqlCommand com = new SqlCommand(query, con);
            if (isProcedure == true)
                com.CommandType = CommandType.StoredProcedure;

            if (parameter != null)
            {
                foreach (var item in parameter)
                {
                    com.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            //execute Command
            SqlDataAdapter adapt = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
        //Function Implement DML (insert - update - delete)
        public static int ExecuteDML
            (string query, Dictionary<string, object> parameter, bool isProcedure)
        {
            SqlConnection con = new SqlConnection("Data Source=68.71.130.74,1533;Initial Catalog=technyte_Shipping;User ID=IsraaCS;Password=xBx6_9a6;Encrypt=False");
            SqlCommand com = new SqlCommand(query, con);
            if (isProcedure == true)
                com.CommandType = CommandType.StoredProcedure;

            if (parameter != null)
            {
                foreach (var item in parameter)
                {
                    com.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            //execute Command
            con.Open();
            int no = com.ExecuteNonQuery();
            con.Close();

            return no;
        }
    }
}
