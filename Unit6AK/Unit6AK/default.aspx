<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Unit6AK.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <h1>Reservation Request</h1>
    <h2>Request Data</h2>
    <div>
        Arrival Date
    </div>
    <div>
        <asp:TextBox ID="txtArrivalDate" runat="server" width="75%" SkinID="redOutline" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Enter Arrival Date" ControlToValidate="txtArrivalDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Error" ControlToCompare="txtDepartureDate" Display="Dynamic" ForeColor="Red" Operator="DataTypeCheck" Type="Date" ControlToValidate="txtArrivalDate"></asp:CompareValidator>
    </div>
    <div>
        Departure Date
    </div>
    <div>
        <asp:TextBox ID="txtDepartureDate" runat="server" width="75%" SkinID="redOutline" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Departure Date" ControlToValidate="txtDepartureDate" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Departure Date Must Be After Arrival Date" ControlToCompare="txtArrivalDate" Operator="GreaterThan" Display="Dynamic" ForeColor="Red" ControlToValidate="txtDepartureDate" Type="Date"></asp:CompareValidator>

    </div>
    <div>
        Number of People
    </div>
    <div>
        <asp:DropDownList ID="ddlPeople" runat="server" width="75%" SkinID="redOutlinex"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="lblBedType" runat="server" Text="Bed Type "></asp:Label>
        <asp:RadioButton ID="rdoKing" runat="server"  GroupName="rdoBeds" Text="King" />
        <asp:RadioButton ID="rdoTwoQueens" runat="server" GroupName="rdoBeds" Text="Two Queens" />
        <asp:RadioButton ID="rdoOneQueen" runat="server" GroupName="rdoBeds" Text="One Queen" />
    </div>
        <h2>Special Requests (Not Required)</h2>
    <div>
        <asp:TextBox ID="txtSpecialRequests" runat="server" TextMode="MultiLine" width="75%" SkinID="redOutline"></asp:TextBox>
    </div>
        <h2>Contact Information</h2>
    <div>
        First Name
    </div>
    <div>
        <asp:TextBox ID="txtFirstName" runat="server" width="75%" SkinID="redOutline" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter First Name" ControlToValidate="txtFirstName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div>
        Last Name
    </div>
    <div>
        <asp:TextBox ID="txtLastName" runat="server" width="75%" SkinID="redOutline"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Please Enter Last Name" ControlToValidate="txtLastName" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
    </div>
    <div>
        Email Address
    </div>
    <div>
        <asp:TextBox ID="txtEmailAddress" runat="server" SkinID="redOutline"></asp:TextBox >
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Please Enter Email Address" ControlToValidate="txtEmailAddress" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email" Display="Dynamic" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmailAddress"></asp:RegularExpressionValidator>
    </div>
    <div>
        Telephone Number
    </div>
    <div>
        <asp:TextBox ID="txtPhoneNumber" runat="server" SkinID="redOutline"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Please Enter Phone Number" ControlToValidate="txtPhoneNumber" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid Phone Number" Display="Dynamic" ForeColor="Red" ControlToValidate="txtPhoneNumber" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
    </div>
    <div>
        Preferred Method
    </div>
    <div>
        <asp:DropDownList ID="ddlPreferredMethod" runat="server" width="75%" SkinID="redOutlinex" ></asp:DropDownList>
    </div>
        <br />
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" CssClass="btn-primary" SkinID="redOutliney"/>
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="btn" CausesValidation="False" SkinID="redOutliney"/>
    </div>
    <div>
        <asp:Label ID="lblConfirmationMessage" runat="server" Text="" EnableViewState="True" Visible="True"></asp:Label>
    </div>
    </form>
</asp:Content>
