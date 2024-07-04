using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 = " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 = " + Session["Session2"].ToString());


            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("select * from [SchoolDB].[dbo].[Student]",connection);
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    Response.Write("Id =  " + rdr[0].ToString() + " ");
                    Response.Write("Name = " + rdr["StudentName"].ToString());
                    Response.Write("<br/>");
                }
            }


        }
    }
}