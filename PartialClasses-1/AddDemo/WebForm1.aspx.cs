using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SamplePartialClass obj = new SamplePartialClass();

        }
    }

    public interface ICustomer
    {
       void CustomerMethod();
    }

    public interface IEmployee
    {
        void EmployeeMethod();
    }
}