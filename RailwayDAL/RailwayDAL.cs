using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RailwayDL
{
    public class RailwayDAL
    {
        public int Add_Customer(Customer_Add cadd)
        {
            int ret = 0;
            int ret1 = 0;
            /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);            
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into TBL_TRAIN_TEAM3 values(@TRAIN_ID,@TRAIN_NAME,@TRAIN_FROM,@TRAIN_TO)";
            cmd.Parameters.AddWithValue("@TRAIN_ID", cadd.train_id);
            cmd.Parameters.AddWithValue("@TRAIN_NAME", cadd.train_name);
            cmd.Parameters.AddWithValue("@TRAIN_FROM", cadd.train_from);
            cmd.Parameters.AddWithValue("@TRAIN_TO", cadd.train_to);
            cmd.Parameters.AddWithValue("@USER_ID", cadd.user_id);
            //cmd.Parameters.AddWithValue("@DATEOFBOOKING", cadd.dateofbooking);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            ret = cmd.ExecuteNonQuery();            
            conn.Close();*/
            


            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString);
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "Insert into TBL_BOOKING_TEAM3(AC,TRAIN_ID,NO_PASS,DATEOFBOOKING) values(@AC,@TRAIN_ID,@NO_PASS,@DATEOFBOOKING)";
            cmd1.Parameters.AddWithValue("@AC", cadd.train_ac);
            cmd1.Parameters.AddWithValue("@TRAIN_ID", cadd.train_id);
            cmd1.Parameters.AddWithValue("@NO_PASS", cadd.train_nop);
            cmd1.Parameters.AddWithValue("@DATEOFBOOKING", cadd.dateofbooking);
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn1;
            ret1 = cmd1.ExecuteNonQuery();
            conn1.Close();
            ret = ret + ret1;
            
                return ret;
        }



        public List<Customer_Add> ViewTrain(int BookID)
        {
            SqlConnection conn;
            SqlCommand cmd;
            List<Customer_Add> lstcust = new List<Customer_Add>();



            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn = new SqlConnection();
            try
            {

                Customer_Add cust = new Customer_Add();
                conn.ConnectionString = conStr;
                conn.Open();
                cmd = new SqlCommand("SP_VIEW_TEAM3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BOOKING_ID", BookID));

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cust.bookid = BookID;
                    cust.train_id = int.Parse(dr["TRAIN_ID"].ToString());
                    cust.train_ac = dr["AC"].ToString();
                    cust.train_nop = int.Parse(dr["NO_PASS"].ToString());
                    cust.dateofbooking = DateTime.Parse(dr["DATEOFBOOKING"].ToString());
                    lstcust.Add(cust);
                }
                return lstcust;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public int Update(Customer_Add cust,int bookid)
        { 

            SqlConnection cn = null;
            SqlCommand cmd;
            int i = 0;

            try
            {

                string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                cn = new SqlConnection();
                cn.ConnectionString = conStr;
                cn.Open();
                cmd = new SqlCommand("SP_UPDATE_TEAM3", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BOOKING_ID", bookid));
                cmd.Parameters.Add(new SqlParameter("@TRAIN_ID", cust.train_id));
                cmd.Parameters.Add(new SqlParameter("@NO_PASS", cust.train_nop));
                i = cmd.ExecuteNonQuery();

                return i;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

            }


        }

    }
}
