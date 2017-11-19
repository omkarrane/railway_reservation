using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using System.Data.SqlClient;
using Classes;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            string user = userid.Text;
            string password = userpass.Text;
            string check="*df  ";
            SqlConnection conn;
            SqlCommand cmd;
            string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            conn = new SqlConnection();
            try
            {
                conn.ConnectionString = conStr;
                conn.Open();
                cmd = new SqlCommand("SP_LOGIN", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NAME", user);

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    check = dr["PASSWORD"].ToString();
                }
                if (check == password)
                {
                    Response.Redirect("Home.aspx");
                }
                else if(check != password)
                {
                    Page page = HttpContext.Current.CurrentHandler as Page;
                    string script = string.Format("alert('Invalid Credentials');");
                    if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                    {
                        page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true);
                    }
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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            userid.Text = "";
            userpass.Text = "";            
        }       
    }
}