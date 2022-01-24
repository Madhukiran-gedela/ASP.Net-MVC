<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registriation.aspx.cs" Inherits="Registriation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 320px;
            text-align: right;
        }
        .auto-style3 {
            width: 320px;
            text-align: right;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            height: 26px;
            text-align: left;
        }
        .auto-style7 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Username :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" Width="40%"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" CssClass="auto-style7" ErrorMessage="Username is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="Email" runat="server" TextMode="Email" Width="40%"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Email" CssClass="auto-style7" ErrorMessage="Email  is Required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Password :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="Pass" runat="server" OnTextChanged="Pass_TextChanged" TextMode="Password" Width="40%"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Pass" CssClass="auto-style7" ErrorMessage="Invaild Password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">ConfirmPassword :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="Pass1" runat="server" OnTextChanged="Pass1_TextChanged" TextMode="Password" Width="40%"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Pass1" CssClass="auto-style7" ErrorMessage="Invalid Password"></asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Pass" ControlToValidate="Pass1" ErrorMessage="Both Password should be same" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Country :</td>
                    <td>
                        <asp:DropDownList ID="coun" runat="server" Width="30%">
                            <asp:ListItem>select country</asp:ListItem>
                            <asp:ListItem>IND</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>SA</asp:ListItem>
                            <asp:ListItem Value="ENG"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="coun" CssClass="auto-style7" ErrorMessage="Please Select country" InitialValue="select country"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        <input id="Reset1" type="reset" value="reset" /></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
