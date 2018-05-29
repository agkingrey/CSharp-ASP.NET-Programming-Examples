<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AustinKingrey_Unit1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chapter 2 Assignment</title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            width: 208px;
        }
        .auto-style3 {
            width: 208px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
    </style>
</head>
<body>
    <h1>Price Quotation</h1>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Sales Price:</td>
                <td>
                    <asp:TextBox ID="txtSalesPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Discount Percentage:</td>
                <td>
                    <asp:TextBox ID="txtDiscountPercentage" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Discount Amount:</td>
                <td class="auto-style4">
                    <asp:Label ID="lblDiscountAmt" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Total Price:</td>
                <td>
                    <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalculate" runat="server" Height="20px" OnClick="btnCalculate_Click" Text="Calculate" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSalesPrice" runat="server" ControlToValidate="txtSalesPrice" Display="Dynamic" ErrorMessage="Please enter a value in the sales price field." ForeColor="Red"></asp:RequiredFieldValidator>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorDiscountPercentage" runat="server" ControlToValidate="txtDiscountPercentage" Display="Dynamic" ErrorMessage="Please enter a value in the discount percentage field." ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <asp:RangeValidator ID="RangeValidatorSalesPrice" runat="server" ControlToValidate="txtSalesPrice" Display="Dynamic" ErrorMessage="Please enter a value between 10 and 1000 for sale price." ForeColor="Red" MaximumValue="1000" MinimumValue="10" Type="Currency"></asp:RangeValidator>
        <p>
            <asp:RangeValidator ID="RangeValidatorDiscountPercentage" runat="server" ControlToValidate="txtDiscountPercentage" Display="Dynamic" ErrorMessage="Please enter a discount percentage between 10 and 50." ForeColor="Red" MaximumValue="50" MinimumValue="10" Type="Double"></asp:RangeValidator>
&nbsp;</p>
    </form>
</body>
</html>
