<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="jQuery.aspx.cs" Inherits="Unit10AK.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>jQuery Page</h1>
    <label id="jQueryLbl">Click the Button!</label>
    <br />
    <input type="button" id="jQueryBtn" value="Update the Time!" />
    <script>

        $(function () {
            $("#jQueryBtn").click(function () {
                var today = new Date();
                $("#jQueryLbl").html("The time is: " + today.getHours() + ":" + today.getMinutes() + ":"+ today.getSeconds());
            });
        });
    </script>
</asp:Content>

