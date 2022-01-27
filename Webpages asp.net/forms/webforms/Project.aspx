<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="webforms.Project" MasterPageFile="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Get a Quote For your Custom Project.</h1>
    <p class="lead">Base price : <asp:Literal ID ="ltBasePrice" runat="server"/></p>

    <div class="form-group">
        <label>Your State</label>
        <asp:DropDownList ID="ddlStates" CssClass="form-control" OnSelectedIndexChanged="ddlStates_SelectedIndexChanged" AutoPostBack="true" runat="server">
            <asp:ListItem value =" ">Select Your State</asp:ListItem>
            <asp:ListItem Value="Ag">Algeria</asp:ListItem>
            <asp:ListItem Value="KY">Kyrgyzstan</asp:ListItem>
            <asp:ListItem Value="IN">India</asp:ListItem>
            <asp:ListItem Value="IT">Italy</asp:ListItem>
            <asp:ListItem Value="BU">Bermuda</asp:ListItem>
            <asp:ListItem Value="CO">Colombia</asp:ListItem>
            <asp:ListItem Value="ON">Oman</asp:ListItem>
            <asp:ListItem Value="KW">Kuwait</asp:ListItem>
            <asp:ListItem Value="FN">France</asp:ListItem>
            <asp:ListItem Value="NZ">New Zealand</asp:ListItem>
            <asp:ListItem Value="MI">Mexico</asp:ListItem>
            <asp:ListItem Value="WI">West Indias</asp:ListItem>
            <asp:ListItem Value="SA">SouthAfrica</asp:ListItem>
            <asp:ListItem Value="AF">Africa</asp:ListItem>
            <asp:ListItem Value="NA">North America</asp:ListItem>
            <asp:ListItem Value="UA">South America</asp:ListItem>
            <asp:ListItem Value="RU">Russia</asp:ListItem>

        </asp:DropDownList>
    </div>
    <div class="jumbotron">
        <h3>Your Custom Price: <asp:Literal ID="ItCustomPrice" runat="server" Text="(select your state to get price)" /></h3>
    </div>
</asp:Content>