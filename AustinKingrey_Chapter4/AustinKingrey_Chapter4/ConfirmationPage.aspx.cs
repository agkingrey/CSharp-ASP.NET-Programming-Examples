using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AustinKingrey_Chapter4
{
    public partial class ConfirmationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //set unob. valid. mode to none, and grab all the data from the default.aspx.cs
            //page and enter it into the textboxes here, casting them to strings
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            //here I'm going to convert sales num to decimal, and then to currency
            string formattedSalesNum = (string)Session["salesNum"];
            decimal finalFormat = decimal.Parse(formattedSalesNum);
            lblSalesPrice.Text = finalFormat.ToString("c");

            lblDiscountAmt.Text = (string)Session["discountNum"];
            lblTotalPrice.Text = (string)Session["totalNum"];
               
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}