using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/** =========================================================

 Austin Kingrey

 Windows 10
 Microsoft Visual Studio 2015 Community

 CIS 174

 Unit 3 Programming Assignment

 This program builds on the last two weeks work, but I'm not building a second confirmation page
to confirm the data.  I used session to hold on to variables over seperate web states.
 Also, I used session to hold a boolean value to make sure the user calulates before verifying

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace AustinKingrey_Chapter4
{ 
    public partial class Default : System.Web.UI.Page
    {
        //my boolean for button clicks
        bool button1WasClicked= false;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            //This line is added to remove unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        //event handler for button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            //setting to true
            button1WasClicked = true;
            //block will only run if validated
            if (IsValid)
            {
                
                //sets value of sales price to the sales price text box
                decimal salesPrice =
                    Convert.ToDecimal(txtSalesPrice.Text);

                //sets value of discount percent to discount percent text box
                decimal discountPercentage =
                    Convert.ToDecimal(txtDiscountPercentage.Text);

                //calling the CalculateDiscountAmount method using the data the programs collected, returning the results to the user
                decimal discountAmount = this.CalculateDiscountAmount(salesPrice, discountPercentage);
                lblDiscountAmt.Text = discountAmount.ToString("c");

                //now I am calling my CalculateFinalPrice to display with the user data I've collected, and returning it to the user
                decimal finalPrice = this.CalculateFinalPrice(salesPrice, discountPercentage);

                lblTotalPrice.Text = finalPrice.ToString("c");
                
                //saving session state of my boolean, before page reset
                Session["button1"] = button1WasClicked;
            }
            
        }

        //A method that will calculate amount discounted using user input
        protected decimal CalculateDiscountAmount(decimal salesPrice, decimal discountPercentage)
        {
            //an adjusted discount percentage
            decimal adjustedDiscountPercentage = .01m * discountPercentage;

            //calculating the amount discounted
            decimal discountAmount = salesPrice * adjustedDiscountPercentage;

            return discountAmount;
        }

        //A method that will calculate final price using future user input
        protected decimal CalculateFinalPrice(decimal salesPrice, decimal discountPercentage)
        {
            //My adjusted discount percentage to use in my formula
            decimal adjustedDiscountPercentage = .01m * discountPercentage;

            //now to multiply the sales price by the adjusted discount perc.
            decimal finalPrice = salesPrice - (salesPrice * adjustedDiscountPercentage);

            return finalPrice;
        }

        //confirm button click event handler
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (Session["button1"] != null)
            {
                button1WasClicked = (bool)Session["button1"];
            }
            
            //if statement seeing if calculate was clicked, if so, continue on with storing data
            //if false, tell user to calculate before confirming
            if (button1WasClicked== true)
            {
                //using session to store data between states
                Session["salesNum"] = txtSalesPrice.Text;
                Session["discountNum"] = lblDiscountAmt.Text;
                Session["totalNum"] = lblTotalPrice.Text;
                Response.Redirect("ConfirmationPage.aspx");
                //using session to reset to false and save after button click
                button1WasClicked = false;
                Session["button1"] = button1WasClicked;

            }
            else
            {
                lblConfirmation.Text = "Be Sure to click calculate before hitting confirm.";
            }
            
        }
    }
}
