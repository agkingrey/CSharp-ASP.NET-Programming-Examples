<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Unit10AK.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome!</h1>
    <label>This is a website that demonstrates the differenece between an Ajax Enabled web page and one that does not use Ajax.
        The page that does not use Ajax will update the time on the label by performing a "partial page postback" to the server.
        The page that does not use ajax will perform a full page post back to the server.

        Just for fun, there is a third way using jQuery.
    </label>
</asp:Content>
