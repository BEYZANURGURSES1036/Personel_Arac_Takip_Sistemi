<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="dsistajwebarac.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {
            height: 100%;
            background: url(arac.jpg) no-repeat center center fixed;
            background-size: cover;
        }

        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 518px;
        }

        #hizalama {
            text-align: right;
        }

        .auto-style3 {
            font-size: x-large;
        }

        .auto-style4 {
            text-align: center;
        }
        .auto-style5 {
            font-size: large;
            color: #FF3300;
            background-color: #FFFFFF;
        }
        .auto-style6 {
            text-align: left;
        }
    </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" cellpadding="5" cellspacing="10" class="auto-style1">
            <caption style="font-family: Calibri; font-weight: bold; font-size: 24px">
                <br />
                <br />
                <br />
                <span class="auto-style3">DEVLET&nbsp; SU İŞLERİ&nbsp; GENEL&nbsp; MÜDÜRLÜĞÜ&nbsp; ARAÇ ENVANTER&nbsp; SİSTEMİ<br />
                </span>
            </caption>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style2"><strong>KULLANICI&nbsp; ADI</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="37px" Width="223px" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid" OnLoad="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style2"><strong>ŞİFRE</strong></td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Height="37px" Width="223px" OnTextChanged="TextBox2_TextChanged" TextMode="Password" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="GİRİŞ" Height="37px" Width="137px" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid" ForeColor="Black" />
                <asp:Label ID="Label1" runat="server" CssClass="auto-style5"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p class="auto-style4">
            <asp:Image ID="Image1" runat="server" Height="57px" ImageUrl="~/dsiamblem.png" Width="74px" BorderColor="Black" BorderStyle="Solid" Navigate="https://www.dsi.gov.tr/" />
            <a href="https://www.dsi.gov.tr/" />
        </p>
    </form>
</body>
</html>
