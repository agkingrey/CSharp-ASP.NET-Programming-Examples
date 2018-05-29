<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AustinKingrey_Unit2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Chapter 3 Assignment</title>
    <%--meta tag and links to the bootstrap and main.--%>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Main.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<%--make this a container fluid so it reacts as you resize the page. Put everything in this container--%>
<div class="container-fluid">
    <header>
        <%--where I'm referencing my main.css file with h1 overiding in main since its 2nd--%>
        <h1>Price Quotation</h1>
    </header>
    <%--here in main, I make my labels and text box with form group for proper spacing--%>
  <main><form id="form1" runat="server">
    <div>
        <asp:Label ID="lblSalesPrice" runat="server" Text="Sales Price"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="   Required" Display="Dynamic" ControlToValidate="txtSalesPrice" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:TextBox ID="txtSalesPrice" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
   <div class="form-group">
    <div>
        <asp:Label ID="lblDiscountPercentage" runat="server" Text="Discount Percent"></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="   Required" ControlToValidate="txtDiscountPercentage" CssClass="text-danger"></asp:RequiredFieldValidator>
    </div>
    <div>
        <asp:TextBox ID="txtDiscountPercentage" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
   </div>
      <%--some blank labels for my results to populate.--%>
    <div class="form-group">
        <asp:Label ID="lblDiscountAmtLabel" runat="server" Text="Discount Amount"></asp:Label>
        <asp:Label ID="lblDiscountAmt" runat="server" Text=""></asp:Label>
    </div>
    <div class="form-group">
        <asp:Label ID="lblTotalPriceLabel" runat="server" Text="Final Price"></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server" Text="Label"></asp:Label>
    </div>
    <div class="form-group">
        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" />
    </div>
  </form></main>
 </div>  
</body>
</html>
