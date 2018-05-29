<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="Unit6AK.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <h1>Request Confirmation</h1>
        <h2>Please confirm your reservation request</h2>
        <div class="marginMaker">
            <asp:Label ID="lblFNameLabel" runat="server" Text="First Name: "></asp:Label>
            <asp:Label ID="lblFName" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblLNameLabel" runat="server" Text="Last Name: "></asp:Label>
            <asp:Label ID="lblLName" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblEmailLabel" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblPhoneLabel" runat="server" Text="Email: "></asp:Label>
            <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblPreferredLabel" runat="server" Text="Preferred Method: "></asp:Label>
            <asp:Label ID="lblPreffered" runat="server" Text=""></asp:Label>
        </div>
        <h2>Request Data</h2>
        <div class="marginMaker">
            <asp:Label ID="lblArrivalLabel" runat="server" Text="Arrival Date: "></asp:Label>
            <asp:Label ID="lblArrival" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblDepartureLabel" runat="server" Text="Departure Date: "></asp:Label>
            <asp:Label ID="lblDeparture" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblDaysLabel" runat="server" Text="No. of days: "></asp:Label>
            <asp:Label ID="lblDays" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblPeopleLabel" runat="server" Text="No. of people: "></asp:Label>
            <asp:Label ID="lblPeople" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblBedLabel" runat="server" Text="Bed Type: "></asp:Label>
            <asp:Label ID="lblBed" runat="server" Text=""></asp:Label>
        </div>
        <div class="marginMaker">
            <asp:Label ID="lblRequestLabel" runat="server" Text="Special requests: "></asp:Label>
            <asp:Label ID="lblRequest" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnConfirm" CssClass="btn-primary" runat="server" Text="Confirm Request" OnClick="btnConfirm_Click" />
            <asp:Button ID="btnModify" CssClass="btn" runat="server" Text="Modify Request" OnClick="btnModify_Click" PostBackUrl="~/Default.aspx" />
        </div>
        <div class="confirmationMessage">
            <asp:Label ID="lblConfirmMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</asp:Content>
