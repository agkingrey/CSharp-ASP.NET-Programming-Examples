using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit10AK
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ajaxBtn_Click(object sender, EventArgs e)
        {
            ajaxLbl.Text ="Hello, world - this is a fresh message from ASP.Net AJAX!, the time right now is: " + DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}