using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using Classes;
using RailwayBL;
using RailwayDL;


namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadGrid()
        {
            int book = int.Parse(TextBox1.Text);
            RailwayBUL rld = new RailwayBUL();
            List<Customer_Add> lstcust = rld.ViewTrain(book);
            GridView1.DataSource = lstcust;
            GridView1.DataBind();
        }
        protected void bla_RowCreated(object sender, GridViewRowEventArgs e)
        {
            del();
        }
        public void del()
        {
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            string bookid = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            string s = "Delete from TBL_BOOKING_TEAM3 where BOOKING_ID=" + bookid;
            SqlCommand cmd = new SqlCommand(s, conn);
            conn.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Page page = HttpContext.Current.CurrentHandler as Page;
                string script = string.Format("alert('Your Delete is Successful');");

                if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                {
                    page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true);
                }
            }
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            Customer_Add c = new Customer_Add();
            RailwayDAL dl = new RailwayDAL();
            c.bookid = int.Parse(TextBox1.Text);
            TextBox trainid = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            c.train_id = int.Parse(trainid.Text);
            TextBox trainnop = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            c.train_nop = Convert.ToInt32(trainnop.Text);
            TextBox trainac = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            c.train_ac = trainac.Text;            
            conn.Open();
            int i = dl.Update(c, c.bookid);
            if (i > 0)
            {
                Page page = HttpContext.Current.CurrentHandler as Page;
                string script = string.Format("alert('Your Update is Successful');");
                if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                {
                    page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true);
                }
            }
            conn.Close();
            GridView1.EditIndex = -1;
            LoadGrid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGrid();
        }
    }
}