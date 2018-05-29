<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmationPage.aspx.cs" Inherits="AustinKingrey_Chapter4.ConfirmationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirmation Page</title>
    <%--Meta tag and references to the bootstap css files and the javasccript--%>
     <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Main.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <%--Fluid container for use on multiple sizes of devices.--%>
    <div class="container-fluid">
    <form id="form1" runat="server">
     <%--Now to build labels and empty labels to put my information into--%>
    <div class =" form-group">
        <asp:Label ID="lblSalesPriceLabel" runat="server" Text="Sales Price:"></asp:Label>
        <asp:Label ID="lblSalesPrice" runat="server"></asp:Label>
    </div>
    <div class ="form-group">
        <asp:Label ID="lblDiscountAmtLabel" runat="server" Text="Discount Amount:    "></asp:Label>
        <asp:Label ID="lblDiscountAmt" runat="server"></asp:Label>
    </div>
    <div class ="form-group">
        <asp:Label ID="lblTotalPriceLabel" runat="server" Text="Total Price:    "></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server"></asp:Label>
    </div>
        <%--Button to Return back to default--%>
    <div>
        <asp:Button ID="btnReturn" runat="server" Text="Return" BackColor="Lime" OnClick="btnReturn_Click" PostBackUrl="~/Default.aspx" />
    </div>

    </form></div>
</body>
</html>
