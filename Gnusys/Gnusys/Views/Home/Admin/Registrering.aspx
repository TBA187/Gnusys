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
            width: 130px;
        }
        .auto-style6 {
            height: 24px;
            width: 130px;
        }
        .auto-style7 {
            width: 96px;
        }
        .auto-style8 {
            width: 144px;
            text-align: right;
            height: 26px;
        }
        .auto-style9 {
            width: 130px;
            height: 26px;
        }
        .auto-style10 {
            height: 26px;
        }
        .auto-style11 {
            height: 24px;
            width: 144px;
            text-align: right;
        }
        .auto-style12 {
            width: 144px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style12">Fornavn</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Name" ErrorMessage="Navn SKAL angives" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Efternavn</td>
                <td class="auto-style5">
                    <asp:TextBox ID="SurName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="SurName" ErrorMessage="Efternavn SKAL angives" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">CPR-nr</td>
                <td class="auto-style5">
                    <asp:TextBox ID="CPRno" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="CPRno" ErrorMessage="CPR-nr SKAL angives" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Adgangskode</td>
                <td class="auto-style5">
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Password" ErrorMessage="Adgangskode SKAL angives" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Gentag adgangskode</td>
                <td class="auto-style9">
                    <asp:TextBox ID="RPassword" runat="server" OnTextChanged="TextBox5_TextChanged" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RPassword" ErrorMessage="Adgangskode SKAL gentages" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style11">Vælg niveau</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="DDLLevel" runat="server" Height="16px" Width="128px">
                        <asp:ListItem>Klinikker</asp:ListItem>
                        <asp:ListItem>Patient</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DDLLevel" ErrorMessage="Niveau SKAL vælges" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Back" runat="server" Text="Tilbage" Width="105px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="ConfirmRegistration" runat="server" Text="Bekræft registrering" Width="127px" />
                </td>
                <td>
                    <input id="Reset1" class="auto-style7" type="reset" value="Nulstil" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
