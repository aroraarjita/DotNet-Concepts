using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClasses
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Arjita";
            C1.LastName = "Arora";

            string FullName1 = C1.GetFullName();
            Response.Write("Full Name = "+FullName1);
            Response.Write("<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Arjita";
            C2.LastName = "Arora";
            string FullName2 = C2.GetFullName();
            Response.Write("Full Name = " + FullName2);

            Response.Write("<br/>");



        }
    }
}