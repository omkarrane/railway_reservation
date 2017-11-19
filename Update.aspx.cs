using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;
using RailwayBL;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }
        protected void btnFind_Click(object sender, EventArgs e)
        {
            RailwayBUL objDB = new RailwayBUL();
            List<Customer_Add> lsttrain = new List<Customer_Add>();
            lsttrain = objDB.ViewTrain(int.Parse(TextBox1.Text));
            droptrain.Items.Clear();
            dropsource.Items.Clear();
            dropdestination.Items.Clear();
            foreach (Customer_Add objtrain in lsttrain)
            {
                droptrain.Items.Add(objtrain.train_id.ToString());
                //dropsource.Items.Add(objtrain.train_from);
                //dropdestination.Items.Add(objtrain.train_to);
                TextBox2.Text = objtrain.train_nop.ToString();
            }
            populatedrop1();
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
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatedrop2();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public void populatedrop3()
        {
            droptrain.Items.Clear();
            if (dropsource.Text == "MUMBAI" && dropdestination.Text == "DELHI")
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
            if (dropsource.Text == "GANGTOK")
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
        }

        protected void dropdestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatedrop3();
        }

        protected void dropsource_SelectedIndexChanged(object sender, EventArgs e)
        {
            populatedrop2();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int i;
            try
            {
                Customer_Add objTrain = new Customer_Add();
                RailwayBUL objBL = new RailwayBUL();
                int bookid = int.Parse(TextBox1.Text);
                objTrain.train_id = int.Parse(droptrain.Text);
                objTrain.train_nop = int.Parse(TextBox2.Text);

                i = objBL.Update(objTrain,bookid);

                if (i > 0)
                {
                    //ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language ='javascript'>alert('Booking Successful')</script>");
                    //b = objadd.DisplayBookingID();
                    //Response.Write(b);
                    Page page = HttpContext.Current.CurrentHandler as Page;
                    string script = string.Format("alert('Your Update is Successful');");
                    if (page != null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
                    {
                        page.ClientScript.RegisterClientScriptBlock(page.GetType(), "alert", script, true);
                    }
                }
            }

            catch (Exception ex)
            {

            }
        }
    }
}