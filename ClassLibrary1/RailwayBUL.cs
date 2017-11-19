using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using RailwayDL;


namespace RailwayBL
{
    public class RailwayBUL
    {
        public int Add_Customer(Customer_Add a)
        {
            RailwayDAL r = new RailwayDAL();
            int j = r.Add_Customer(a);
            return j;
        }
        public List<Customer_Add> ViewTrain(int BookID)
        {
            List<Customer_Add> cust = new List<Customer_Add>();
            RailwayDAL rd = new RailwayDAL();
            cust = rd.ViewTrain(BookID);
            return cust;
        }
        public int Update(Customer_Add cust,int bookid)
        {
            RailwayDAL rld = new RailwayDAL();
            int i=0;
            i = rld.Update(cust,bookid);
            return i; 
        }
    }
}
