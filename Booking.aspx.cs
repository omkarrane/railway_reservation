using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RailwayBL;
using Classes;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                //populatedrop1();
                //dropdestination.Items.Insert(0, "Select");
                DateTime dt = DateTime.Today;
                TextBox3.Text = dt.ToString("d");
                CompareValidator1.ValueToCompare = DateTime.Now.ToShortDateString();
                Label8.Text = "Hello "+Session["userid"].ToString();
            }

        }
        public void populatedrop1()
        {
            dropsource.Items.Clear();
            dropsource.Items.Add("MUMBAI");
            dropsource.Items.Add("CHENNAI");
            dropsource.Items.Add("GANGTOK");
            dropsource.Items.Add("HYDERABAD");
            dropsource.Items.Add("AHMEDABAD");
            dropsource.Items.Add("BENGALURU");
            dropsource.Items.Add("KOLKATA");
            dropsource.Items.Add("NAGPUR");
            dropsource.Items.Add("DELHI");
            dropsource.Items.Add("SRINAGAR");
            
            dropsource.Items.Insert(0, "Select");
        }

        protected void dropsource_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatedrop2();
        }

        public void populatedrop2()
        {
            dropdestination.Items.Clear();
            if (dropsource.Text == "MUMBAI")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("CHENNAI");
                dropdestination.Items.Add("AHMEDABAD");
                dropdestination.Items.Add("BENGALURU");
                dropdestination.Items.Add("KOLKATA");
                dropdestination.Items.Add("NAGPUR");
                dropdestination.Items.Add("DELHI");
            }
            if (dropsource.Text == "CHENNAI")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");               
                dropdestination.Items.Add("HYDERABAD");               
                dropdestination.Items.Add("BENGALURU");
                dropdestination.Items.Add("KOLKATA");
               
            }
            if (dropsource.Text == "Gangtok")
            {
                dropdestination.Items.Clear();               
                dropdestination.Items.Add("KOLKATA");
               
            }
            if (dropsource.Text == "HYDERABAD")
            {
                dropdestination.Items.Clear();                
                dropdestination.Items.Add("CHENNAI");               
                dropdestination.Items.Add("BENGALURU");
                dropdestination.Items.Add("KOLKATA");
                dropdestination.Items.Add("NAGPUR");
               
            }
            if (dropsource.Text == "AHMEDABAD")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");              
                dropdestination.Items.Add("BENGALURU");              
                dropdestination.Items.Add("DELHI");
               
            }
            if (dropsource.Text == "BENGALURU")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");
                dropdestination.Items.Add("CHENNAI");
                dropdestination.Items.Add("HYDERABAD");
                dropdestination.Items.Add("AHMEDABAD");
                dropdestination.Items.Add("NAGPUR");
            }
            if (dropsource.Text == "KOLKATA")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");
                dropdestination.Items.Add("CHENNAI");
                dropdestination.Items.Add("GANGTOK");
                dropdestination.Items.Add("HYDERABAD");
                dropdestination.Items.Add("NAGPUR");
                dropdestination.Items.Add("DELHI");
            }
            if (dropsource.Text == "NAGPUR")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");
                dropdestination.Items.Add("HYDERABAD");
                dropdestination.Items.Add("BENGALURU");
                dropdestination.Items.Add("KOLKATA");
            }
            if (dropsource.Text == "DELHI")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("MUMBAI");
                dropdestination.Items.Add("AHMEDABAD");
                dropdestination.Items.Add("KOLKATA");
                dropdestination.Items.Add("SRINAGAR");
            }
            if (dropsource.Text == "SRINAGAR")
            {
                dropdestination.Items.Clear();
                dropdestination.Items.Add("DELHI");
            }
            dropdestination.Items.Insert(0,"Select");
        }

        protected void dropdestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatedrop3();
        }

        public void populatedrop3()
        {
            droptrain.Items.Clear();
            if (dropsource.Text=="MUMBAI" && dropdestination.Text == "DELHI")
            {                
                droptrain.Items.Add("22633");
            }
            if (dropsource.Text == "DELHI" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("22634");
            }
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("12322");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("12321");
            }
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "CHENNAI")
            {
                droptrain.Items.Add("11041");
            }
            if (dropsource.Text == "CHENNAI" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("11042");
            }
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "AHMEDABAD")
            {
                droptrain.Items.Add("22955");
            }
            if (dropsource.Text == "AHMEDABAD" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("22956");
            }
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "NAGPUR")
            {
                droptrain.Items.Add("12105");
            }
            if (dropsource.Text == "NAGPUR" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("12106");
            }
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "BENGALURU")
            {
                droptrain.Items.Add("11301");
            }
            if (dropsource.Text == "BENGALURU" && dropdestination.Text == "MUMBAI")
            {
                droptrain.Items.Add("11302");
            }
            if (dropsource.Text == "DELHI" && dropdestination.Text == "SRINAGAR")
            {
                droptrain.Items.Add("14033");
            }
            if (dropsource.Text == "SRINAGAR" && dropdestination.Text == "DELHI")
            {
                droptrain.Items.Add("14034");
            }
            if (dropsource.Text == "DELHI" && dropdestination.Text == "AHMEDABAD")
            {
                droptrain.Items.Add("19403");
            }
            if (dropsource.Text == "AHMEDABAD" && dropdestination.Text == "DELHI")
            {
                droptrain.Items.Add("19404");
            }
            if (dropsource.Text == "GANGTOK" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("12524");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "GANGTOK")
            {
                droptrain.Items.Add("12525");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "NAGPUR")
            {
                droptrain.Items.Add("12410");
            }
            if (dropsource.Text == "NAGPUR" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("12409");
            }
            if (dropsource.Text == "BENGALURU" && dropdestination.Text == "NAGPUR")
            {
                droptrain.Items.Add("12295");
            }
            if (dropsource.Text == "NAGPUR" && dropdestination.Text == "BENGALURU")
            {
                droptrain.Items.Add("12296");
            }
            if (dropsource.Text == "BENGALURU" && dropdestination.Text == "CHENNAI")
            {
                droptrain.Items.Add("16022");
            }
            if (dropsource.Text == "CHENNAI" && dropdestination.Text == "BENGALURU")
            {
                droptrain.Items.Add("16023");
            }
            if (dropsource.Text == "CHENNAI" && dropdestination.Text == "HYDERABAD")
            {
                droptrain.Items.Add("12760");
            }
            if (dropsource.Text == "HYDERABAD" && dropdestination.Text == "CHENNAI")
            {
                droptrain.Items.Add("12761");
            }
            if (dropsource.Text == "HYDERABAD" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("12764");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "HYDERABAD")
            {
                droptrain.Items.Add("12763");
            }
            if (dropsource.Text == "CHENNAI" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("12503");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "CHENNAI")
            {
                droptrain.Items.Add("12504");
            }
            if (dropsource.Text == "AHMEDABAD" && dropdestination.Text == "BENGALURU")
            {
                droptrain.Items.Add("16501");
            }
            if (dropsource.Text == "BENGALURU" && dropdestination.Text == "AHMEDABAD")
            {
                droptrain.Items.Add("16502");
            }
            if (dropsource.Text == "DELHI" && dropdestination.Text == "KOLKATA")
            {
                droptrain.Items.Add("10600");
            }
            if (dropsource.Text == "KOLKATA" && dropdestination.Text == "DELHI")
            {
                droptrain.Items.Add("10601");
            }
            if (dropsource.Text == "HYDERABAD" && dropdestination.Text == "NAGPUR")
            {
                droptrain.Items.Add("12477");
            }
            if (dropsource.Text == "NAGPUR" && dropdestination.Text == "HYDERABAD")
            {
                droptrain.Items.Add("12478");
            }
            if (dropsource.Text == "HYDERABAD" && dropdestination.Text == "BENGALURU")
            {
                droptrain.Items.Add("12501");
            }
            if (dropsource.Text == "BENGALURU" && dropdestination.Text == "HYDERABAD")
            {
                droptrain.Items.Add("12502");
            }
            droptrain.Items.Insert(0, "SELECT");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RailwayBUL rbl = new RailwayBUL();
            Customer_Add a = new Customer_Add();
            a.train_id = int.Parse(droptrain.Text);
            a.train_nop = int.Parse(TextBox2.Text);
            a.train_ac = RadioButtonList1.SelectedValue;
            a.dateofbooking = DateTime.Parse(TextBox3.Text);
            int i = rbl.Add_Customer(a);
            int ast=getbookid();
            if (i > 0)
            {
                //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language ='javascript'>alert('Booking Successful')</script>");
                //b = objadd.DisplayBookingID();
                //Response.Write(b);
                Page page = HttpContext.Current.CurrentHandler as Page;
                string script = string.Format("alert('Your Booking is Successful and Your Booking ID is {0}');", ast);
                if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                {
                    page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true);
                }
            }
        }


        public int getbookid()
        {
            SqlConnection conn;
            SqlCommand cmd;

            int aq=19;

            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn = new SqlConnection();
            try
            {

                Customer_Add cust = new Customer_Add();
                conn.ConnectionString = conStr;
                conn.Open();
                cmd = new SqlCommand("SP_BOOKID_TEAM3", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    cust.bookid = int.Parse(dr["BOOKING_ID"].ToString());
                    aq = cust.bookid;                  
                }
            }
            catch (Exception ex)
            {
            }

            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return aq;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            dropsource.Text = "SELECT";
            dropdestination.Items.Clear();
            droptrain.Items.Clear();
            TextBox2.Text = "";
            DateTime dt = DateTime.Today;
            TextBox3.Text = dt.ToString("d");
            RadioButtonList1.SelectedValue = "1";
        }

        protected void droptrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (droptrain.Text == "22633")
            {
                Train_Name.Text = "Nizamuddin Express";
            }
            if (droptrain.Text == "22634")
            {
                Train_Name.Text = "Nizamuddin Express";
            }
            if (droptrain.Text == "12322")
            {
                Train_Name.Text = "Howrah Mail";
            }
            if (droptrain.Text == "12321")
            {
                Train_Name.Text = "Howrah Mail";
            }
            if (droptrain.Text == "11041")
            {
                Train_Name.Text = "Chennai Express ";
            }
            if (droptrain.Text == "11042")
            {
                Train_Name.Text = "Chennai Express";
            }
            if (droptrain.Text == "22955")
            {
                Train_Name.Text = "Kutch Express ";
            }
            if (droptrain.Text == "22956")
            {
                Train_Name.Text = "Kutch Express";
            }
            if (droptrain.Text == "12105")
            {
                Train_Name.Text = "Vidharbha Passenger ";
            }
            if (droptrain.Text == "12106")
            {
                Train_Name.Text = "Vidharbha Passenge";
            }
            if (droptrain.Text == "11301")
            {
                Train_Name.Text = "Udyan Express";
            }
            if (droptrain.Text == "11302")
            {
                Train_Name.Text = "Udyan Express";
            }
            if (droptrain.Text == "14033")
            {
                Train_Name.Text = "Jammu Mail";
            }
            if (droptrain.Text == "14034")
            {
                Train_Name.Text = "Jammu Mail";
            }
            if (droptrain.Text == "19403")
            {
                Train_Name.Text = "Sultanpur Express";
            }
            if (droptrain.Text == "19404")
            {
                Train_Name.Text = "Sultanpur Express";
            }
            if (droptrain.Text == "12524")
            {
                Train_Name.Text = "Indrayani Express";
            }
            if (droptrain.Text == "12525")
            {
                Train_Name.Text = "Indrayani Express";
            }
            if (droptrain.Text == "12410")
            {
                Train_Name.Text = "Kolkata Express";
            }
            if (droptrain.Text == "12409")
            {
                Train_Name.Text = "Kolkata Express";
            }
            if (droptrain.Text == "12295")
            {
                Train_Name.Text = "Sanghamitra Express";
            }
            if (droptrain.Text == "12296")
            {
                Train_Name.Text = "Sanghamitra Express";
            }
            if (droptrain.Text == "16022")
            {
                Train_Name.Text = "Kaveri Express";
            }
            if (droptrain.Text == "16023")
            {
                Train_Name.Text = "Kaveri Express";
            }
            if (droptrain.Text == "12760")
            {
                Train_Name.Text = "Charminar Passenger";
            }
            if (droptrain.Text == "12761")
            {
                Train_Name.Text = "Charminar Passenger";
            }
            if (droptrain.Text == "12764")
            {
                Train_Name.Text = "Durga Express";
            }
            if (droptrain.Text == "12763")
            {
                Train_Name.Text = "Durga Express";
            }
            if (droptrain.Text == "12503")
            {
                Train_Name.Text = "Chennai Passenger";
            }
            if (droptrain.Text == "12504")
            {
                Train_Name.Text = "Chennai Passenger";
            }
            if (droptrain.Text == "16501")
            {
                Train_Name.Text = "Bengaluru Special Express";
            }
            if (droptrain.Text == "16502")
            {
                Train_Name.Text = "Bengaluru Special Express";
            }
            if (droptrain.Text == "10600")
            {
                Train_Name.Text = "Rajdhani Express";
            }
            if (droptrain.Text == "10601")
            {
                Train_Name.Text = "Rajdhani Express";
            }
            if (droptrain.Text == "12477")
            {
                Train_Name.Text = "Nagpur Passenger";
            }
            if (droptrain.Text == "12478")
            {
                Train_Name.Text = "Nagpur Passenger";
            }
            if (droptrain.Text == "12501")
            {
                Train_Name.Text = "Hyderabad Mail";
            }
            if (droptrain.Text == "12502")
            {
                Train_Name.Text = "Hyderabad Mail";
            }
        }
    }
}