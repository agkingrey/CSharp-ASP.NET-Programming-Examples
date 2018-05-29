<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="NonAjax.aspx.cs" Inherits="Unit10AK.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Non-Ajax Page</h1>
    <asp:Label ID="nonAjaxlbl" runat="server" Text="Click the Button!"></asp:Label>
    <br />
    <asp:Button ID="nonAjaxBtn" runat="server" Text="Update the Time!" OnClick="nonAjaxBtn_Click" />

</asp:Content>
