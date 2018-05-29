﻿using System;
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

 Unit 1 Programming Assignment

 This program takes two entered values by the user(Sales Price and discount percent) and returns
 the amount discounted and the final sales price.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.

=========================================================== **/

namespace AustinKingrey_Unit1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This line is added to remove unobtrusive validation
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        //event handler for Button Click
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            //Only calculates if entries are valid
            if(IsValid)
            {
                //sets value of sales price to the sales price text box
                int salesPrice =
                    Convert.ToInt32(txtSalesPrice.Text);

                //sets value of discount percent to discount percent text box
                decimal discountPercentage =
                    Convert.ToDecimal(txtDiscountPercentage.Text);

                //calling the CalculateDiscountAmount method using the data the programs collected, returning the results to the user
                decimal discountAmount = this.CalculateDiscountAmount(salesPrice, discountPercentage);
                lblDiscountAmt.Text = discountAmount.ToString("c");

                //now I am calling my CalculateFinalPrice to display with the user data I've collected, and returning it to the user
                decimal finalPrice = this.CalculateFinalPrice(salesPrice, discountPercentage);

                lblTotalPrice.Text = finalPrice.ToString("c");
            }
        }

        //A method that will calculate amount discounted using user input
        protected decimal CalculateDiscountAmount(int salesPrice, decimal discountPercentage)
        {
            //an adjusted discount percentage
            decimal adjustedDiscountPercentage = .01m * discountPercentage;

            //calculating the amount discounted
            decimal discountAmount = salesPrice * adjustedDiscountPercentage;

            return discountAmount;
        }

        //A method that will calculate final price using future user input
        protected decimal CalculateFinalPrice (int salesPrice, decimal discountPercentage)
        {
            //My adjusted discount percentage to use in my formula
            decimal adjustedDiscountPercentage = .01m * discountPercentage;

            //now to multiply the sales price by the adjusted discount perc.
            decimal finalPrice = salesPrice - (salesPrice * adjustedDiscountPercentage);

            return finalPrice;
        }
    }
}