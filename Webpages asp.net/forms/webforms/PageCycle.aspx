<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageCycle.aspx.cs" Inherits="webforms.PageCycle" MasterPageFile="~/Site.Master" %>
 
<asp:Content runat="server" ID="Content1" ContentPlaceHolderID="MainContent">
    <h2>Page Life Cycle Events</h2>
    <p>
        <asp:Label ID="lblInit" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblPageLoad" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblPostBack" runat="server" />
    </p>
    <p>
        <asp:Label ID="lblButtonEvent" runat="server" />
    </p>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary btn-large" OnClick="btnSubmit_Click" /> 
</asp:Content>