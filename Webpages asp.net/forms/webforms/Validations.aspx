<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validations.aspx.cs" Inherits="webforms.Validations" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Validation Example</h1>
    <div class="form-group">
        <div class="form-text">
            * Fields marked with a asterrisk are requried.
        </div>
    </div>
   <p class="bg-primary">
    <asp:Literal ID="ltPostBack" runat="server"/>
    <asp:ValidationSummary ID="valSummaryForm" runat="server" CssClass="bg-error" ValidationGroup="valForm" DisplayMode="BulletList" HeaderText="Please fix the following errors" Visible="false"/>
  </p>
       <div class="form-group">
      <label>Name :</label>
      <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
      <asp:RequiredFieldValidator ID="rrqName" runat="server" ControlToValidate="txtName" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="* Full name Required" Display="Dynamic" />
      </div>
    <div class="form-group">
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
        <asp:RequiredFieldValidator ID="rqEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="* Email is rquired" Display="Dynamic" />
    </div>
    <div class="form-group">
        <label>phone</label>
        <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" />
        <asp:RequiredFieldValidator ID="rqNumber" runat="server" ControlToValidate="txtPhone" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="* enter your number" />
        <asp:RangeValidator ID="rqPhone" runat="server" ControlToValidate="txtPhone" ValidationGroup="valForm" Type="Integer" MaximumValue="10" MinimumValue="10" CssClass="bg-error" ErrorMessage="* enter your number" />
    </div>
    <div class="form-group">
    <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CssClass="btn btn-primary" Text="submit"/>   
    </div>
    </asp:Content>