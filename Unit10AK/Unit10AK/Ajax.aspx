<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="Unit10AK.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1>Ajax WebPage</h1>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="ajaxLbl" runat="server" Text="Click The Button"></asp:Label>
            <br />
            <asp:Button ID="ajaxBtn" runat="server" OnClick="ajaxBtn_Click" Text="Update the Time!" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
