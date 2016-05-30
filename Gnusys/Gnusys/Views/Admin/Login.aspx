<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Gnusys.Views.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 101px;
            height: 22px;
        }
        .auto-style5 {
            width: 101px;
            text-align: center;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style7 {
            width: 137px;
        }
        .auto-style8 {
            height: 22px;
            width: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="UserLabel" runat="server" Text="CPR-nr"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredUserID" runat="server" BackColor="White" BorderColor="White" BorderStyle="None" ControlToValidate="UserID" ErrorMessage="CPR-nr er ikke indtastet" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="PasswordLabel" runat="server" Text="Adgangskode"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredPassword" runat="server" ControlToValidate="Password" ErrorMessage="Adgangskode er ikke indtastet" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style8"></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="LoggIN" runat="server" OnClick="LoggIN_Click" Text="Log ind" />
                </td>
                <td class="auto-style7">
                    <asp:Button ID="Registration" runat="server" Text="Opret ny bruger" Width="125px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
