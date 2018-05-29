<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Unit8AK.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Halloween Superstore</title>
    <link href="Main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <header>

        <img src="Images/banner.jpg" alt="Halloween Store" />

    </header>

    <section>

        <form id="form1" runat="server">

            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ProductID" OnRowUpdated="GridView1_RowUpdated" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ID" ReadOnly="True" SortExpression="ProductID">
                    <ItemStyle Width="25%" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="OnHand" HeaderText="OnHand" SortExpression="OnHand"></asp:BoundField>
                    <asp:CommandField ShowEditButton="True" HeaderText="Update Cancel" />
                </Columns>

                <RowStyle BackColor="White" ForeColor="Black" />
                <AlternatingRowStyle BackColor="LightGray" ForeColor="Black" />
                <EditRowStyle BackColor="LightGreen" ForeColor="Black" />
                <HeaderStyle BackColor=" #0c5a33" ForeColor="White" />
                <SelectedRowStyle BackColor="#62eaa6" ForeColor="Black" />
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server"

                ConnectionString="<%$ ConnectionStrings:HalloweenConnectionString %>"

                SelectCommand="SELECT ProductID, Name, OnHand FROM Products"

                UpdateCommand="UPDATE Products SET OnHand = @OnHand WHERE (ProductID = @ProductID)">

                <UpdateParameters>

                    <asp:Parameter Name="OnHand" />

                    <asp:Parameter Name="ProductID" />

                </UpdateParameters>

            </asp:SqlDataSource>

            <p>

                <asp:Label ID="lblError" runat="server" CssClass="error" ForeColor="Red"></asp:Label>

            </p>

            <asp:ValidationSummary ID="ValidationSummary1" runat="server"

                HeaderText="Please correct the following errors:" CssClass="error" />

        </form>

    </section>
</body>
</html>
