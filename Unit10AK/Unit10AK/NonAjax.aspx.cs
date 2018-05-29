using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit10AK
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void nonAjaxBtn_Click(object sender, EventArgs e)
        {
            nonAjaxlbl.Text ="This page is updating everything, because it's non Ajax, everytime you click the button." + DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}