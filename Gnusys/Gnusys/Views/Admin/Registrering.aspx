<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrering.aspx.cs" Inherits="Gnusys.Views.Admin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 24px;
        }
        .auto-style3 {
            width: 144px;
            text-align: center;
        }
        .auto-style4 {
            height: 24px;
            width: 144px;
            text-align: center;
        }
        .auto-style5 {
            width: 139px;
        }
        .auto-style6 {
            height: 24px;
            width: 139px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Fornavn</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Efternavn</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">CPR-nr</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Adgangskode</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Gentag adgangskode</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style6"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Tilbage" Width="105px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button2" runat="server" Text="Bekræft registrering" Width="127px" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="Button" Width="113px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
