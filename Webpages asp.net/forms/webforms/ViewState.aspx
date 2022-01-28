<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="webforms.ViewState"  MasterPageFile="~/Site.Master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>view State Example</h1>
    <div class="lead"><asp:Literal ID="ltPostBack" runat="server"/></div>
  <div class="form-group">
      <label>Name</label>
      <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
      </div>
    <div class="form-group">
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
    </div>
    <div class="form-group">
        <label>phone</label>
        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" />
    </div>
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
<div class="form-group">
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-primary" Text="submit"/>   
</div>
</asp:Content>