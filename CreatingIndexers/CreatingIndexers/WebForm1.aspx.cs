using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreatingIndexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Before Update");
            Response.Write("Name of the employee with Id 2 = " + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of the employee with Id 5 = " + company[5]);
            Response.Write("<br/>");


            Response.Write("Name of the employee with Id 8 = " + company[8]);
            Response.Write("<br/>");


            company[2] = "2nd employee name changed";
            company[5] = "5th employee name changed";
            company[8] = "8th employee name changed";

            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("After Update");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Name of the employee with Id 2 = " + company[2]);
            Response.Write("<br/>");

            Response.Write("Name of the employee with Id 5 = " + company[5]);
            Response.Write("<br/>");


            Response.Write("Name of the employee with Id 8 = " + company[8]);
            Response.Write("<br/>");


            Response.Write("<br/>");
            Response.Write("<br/>");

            Response.Write("Before Update");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Total Male Employees:" + company["Male"]);
            Response.Write("Total Female Employees:" + company["Female"]);

            company["Male"] = "Female";


            Response.Write("After Update");
            Response.Write("<br/>");
            Response.Write("<br/>");
            Response.Write("Total Male Employees:" + company["Male"]);
            Response.Write("Total Female Employees:" + company["Female"]);





        }
    }
}