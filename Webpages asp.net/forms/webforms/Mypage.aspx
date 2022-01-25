<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Mypage.aspx.cs" Inherits="webforms.Mypage" MasterPageFile="~/Site.Master" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <h2>AdVance Asp.Net Web Sever Control</h2>
    <h3>Create a list of event a repeated From a Calender control.</h3>
<div class="form-group">
    <label>Event Name:</label>
    <asp:TextBox ID="txtEvent" CssClass="form-control" runat="server" />
</div>
    <div class="form-group">
        <label>Event date:</label>
        <asp:Calendar ID="calendarEvents" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnEvent" runat="server" CssClass="btn btn-primary brn-large" Text="Add Event" OnClick="btnEvent_Click" />
    </div>
    <h3>Events Repeater.</h3>
    <div>
      <asp:Repeater ID="rptEvents" runat="server">
            <ItemTemplate>
                <h3><%# DataBinder.Eval(Container.DataItem,"EventDate") %><small><%# DataBinder.Eval(Container.DataItem,"EventName") %></small></h3>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
