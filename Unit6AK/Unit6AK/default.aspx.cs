using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit6AK
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            lblConfirmationMessage.Text = "";

            //here I'll repopulate my text boxes if available when reloading
            if (Session["reservation"] != null)
            {
                Reservation refill = (Reservation)Session["reservation"];
                txtArrivalDate.Text = refill.ArrivalDate.ToString("MM/dd/yyyy");
                txtDepartureDate.Text = refill.DepartureDate.ToString("MM/dd/yyyy");
                ddlPeople.Text = refill.NoOfPeople.ToString();
                txtSpecialRequests.Text = refill.SpecialRequests;
                txtFirstName.Text = refill.FirstName;
                txtLastName.Text = refill.LastName;
                txtEmailAddress.Text = refill.Email;
                txtPhoneNumber.Text = refill.Phone;
            }

            if (!IsPostBack)
            {
                //Set Date and Check King RadioButton
                txtArrivalDate.Text = DateTime.Today.ToShortDateString();
                rdoKing.Checked = true;

                //add items to ddlPeople DropDown and ddlPreferredMethod dropdown
                ddlPeople.Items.Add("1");
                ddlPeople.Items.Add("2");
                ddlPeople.Items.Add("3");
                ddlPeople.Items.Add("4");


                ddlPreferredMethod.Items.Add("Email");
                ddlPreferredMethod.Items.Add("Telephone");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Here I'll use validation controls  , then grab the results from the user
            if (IsValid)
            {
                //creating a new reservation object to store the data
                Reservation res = new Reservation();

                //storing textboxes into object
                res.ArrivalDate = DateTime.Parse(txtArrivalDate.Text);
                res.DepartureDate = DateTime.Parse(txtDepartureDate.Text);

                //hereI'm going to calculate number of days and save into object
                TimeSpan tsDays = res.DepartureDate - res.ArrivalDate;
                int days = tsDays.Days;
                res.NoOfDays = days;

                //number of people
                res.NoOfPeople = int.Parse(ddlPeople.Text);

                //logic for which radio button checked then adding it to object 
                String bbedType = "null";
                if (rdoKing.Checked == true)
                {
                    bbedType = "King";
                }
                else if (rdoOneQueen.Checked == true)
                {
                    bbedType = "One Queen";
                }
                else if (rdoTwoQueens.Checked == true)
                {
                    bbedType = "Two Queens";
                }
                res.BedType = bbedType;

                //more for my object
                res.SpecialRequests = txtSpecialRequests.Text;
                res.FirstName = txtFirstName.Text;
                res.LastName = txtLastName.Text;
                res.Email = txtEmailAddress.Text;
                res.Phone = txtPhoneNumber.Text;
                res.PreferredMethod = ddlPreferredMethod.Text;

                //save object to session
                Session["reservation"] = res;
                Response.Redirect("Confirmation.aspx");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtArrivalDate.Text = "";
            txtDepartureDate.Text = "";
            txtSpecialRequests.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
        }
    }
}