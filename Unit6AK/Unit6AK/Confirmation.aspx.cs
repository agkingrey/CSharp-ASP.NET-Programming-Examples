using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Unit6AK
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //on page load, im grabbing my session state(and the object inside)
            Reservation reservation = (Reservation)Session["reservation"];

            //populate the labels with my object
            lblFName.Text = reservation.FirstName;
            lblLName.Text = reservation.LastName;
            lblEmail.Text = reservation.Email;
            lblPhone.Text = reservation.Phone;
            lblPreffered.Text = reservation.PreferredMethod;
            lblArrival.Text = reservation.ArrivalDate.ToString("MM/dd/yyyy");
            lblDeparture.Text = reservation.DepartureDate.ToString("MM/dd/yyyy");
            lblDays.Text = reservation.NoOfDays.ToString();
            lblPeople.Text = reservation.NoOfPeople.ToString();
            lblBed.Text = reservation.BedType;
            lblRequest.Text = reservation.SpecialRequests;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //create my two cookies for first name and email
            HttpCookie nameCookie = new HttpCookie("FirstName", lblFName.Text);
            HttpCookie emailCookie = new HttpCookie("Email", lblEmail.Text);

            //set the exp. date to 6 months from now
            nameCookie.Expires = DateTime.Now.AddMonths(6);
            emailCookie.Expires = DateTime.Now.AddMonths(6);
            lblConfirmMessage.Text = "Thank you for your request. We'll Get back to you within 24 hours.";
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {

        }
    }
}