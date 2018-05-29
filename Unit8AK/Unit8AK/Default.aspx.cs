using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit8AK
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //validation for row updated to make sure two people dont update at the same time
        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            int x = Convert.ToInt32(e.NewValues["OnHand"]);

            if (e.Exception != null)
            {
                lblError.Text = DataBaseErrorMessage(e.Exception.Message);
                e.ExceptionHandled = true;
                e.KeepInEditMode = true;
            }
            else if (e.AffectedRows == 0)
            {
                lblError.Text = ConcurrencyErrorMessage();
            }
            else if(x<0)
            {
                e.KeepInEditMode = true;
                lblError.Text = "Please enter in a non negative integer.";
            }
        }

        private string ConcurrencyErrorMessage()
        {
            return "Another user may have upgraded that category simultaneously." + "Please Try Again";
        }

        private string DataBaseErrorMessage(string message)
        {
            return $"<b>A database error has occured:</b> {message}";
        }

    }
}