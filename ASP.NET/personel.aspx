<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="personel.aspx.cs" Inherits="dsistajwebarac.personel" Culture="auto" meta:resourcekey="PageResource1" UICulture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            height: 100%;
            background: url(arac.jpg) no-repeat center center fixed;
            background-size: cover;
        }

        .auto-style1 {
            width: 100%;
            margin-top: 45px;
        }

        .auto-style2 {
            width: 592px;
            font-size: small;
            color: #CCFFFF;
        }

        #hizalama {
            text-align: right;
        }

        .auto-style3 {
            width: 592px;
            height: 33px;
            font-size: small;
            color: #FFFFFF;
        }

        .auto-style5 {
            width: 592px;
            height: 31px;
        }

        .auto-style6 {
            height: 31px;
        }

        .auto-style8 {
            margin-left: 600px;
            text-align: left;
        }

        .resim {
            align-content: flex-end;
        }

        .auto-style10 {
            height: 33px;
            text-align: left;
        }

        .auto-style11 {
            text-align: left;
        }

        .auto-style13 {
            text-decoration: none;
        }

        .auto-style14 {
            font-size: large;
            margin-right: 50px;
        }

        .auto-style15 {
            text-align: right;
        }

        .auto-style16 {
            font-size: small;
        }

        .auto-style17 {
            width: 592px;
            font-size: small;
            color: #FFFFFF;
        }

        .auto-style18 {
            background-color: #000066;
        }

        .auto-style19 {
            font-size: medium;
            color: #000066;
            background-color: #FFFFFF;
        }
        .auto-style20 {
            font-size: medium;
            color: #000066;
            text-align: center;
        }
        .auto-style21 {
            background-color: #FFFFFF;
        }
        .auto-style22 {
            text-align: center;
        }
        .auto-style23 {
            margin-right: 45px;
        }
        .auto-style24 {
            color: #FF3300;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">


        <div class="auto-style15">

            <asp:Image ID="Image1" runat="server" ImageUrl="~/exit.png" Height="24px" Width="26px" meta:resourcekey="Image1Resource1" />&nbsp;<strong><em><span class="auto-style14"><a class="auto-style13" href="index.aspx">ÇIKIŞ</a></span></em></strong><br />

        </div>

        <table class="auto-style1">

            <caption style="font-family: Calibri; font-weight: bold; font-size: larger">
                <br />
                <em>DEVLET&nbsp; SU İŞLERİ&nbsp; GENEL&nbsp; MÜDÜRLÜĞÜ&nbsp; ARAÇ ENVANTER&nbsp; SİSTEMİ<br />
                    <br />
                    <br />
                    <span class="auto-style19">PERSONEL ARAÇ TALEBİ</span></em></caption>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style6">&nbsp;</td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style17"><strong><span class="auto-style18">PERSONEL&nbsp;&nbsp;AD SOYAD&nbsp;</span>&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="auto-style8">
                    <strong>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="37px" Width="223px" ReadOnly="True" OnLoad="TextBox1_TextChanged" meta:resourcekey="TextBox1Resource1" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid" CssClass="auto-style16"></asp:TextBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style3"><strong>&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style18">PERSONEL&nbsp; UNVAN&nbsp;</span>&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="auto-style10">
                    <strong>
                        <asp:TextBox ID="TextBox5" runat="server" Height="37px" Width="223px" ReadOnly="True" OnTextChanged="TextBox5_TextChanged" OnLoad="TextBox5_TextChanged" meta:resourcekey="TextBox5Resource1" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid" CssClass="auto-style16"></asp:TextBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style3"><strong><span class="auto-style18">GİDİLECEK&nbsp;&nbsp;YER</span>&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#CCFFFF" Height="37px" AutoPostBack="True"  Width="227px">
                        <asp:ListItem>SEÇİNİZ</asp:ListItem>
                    </asp:DropDownList>
                    <strong>
                        <br class="auto-style16" />
                    </strong>
                </td>
            </tr>
            <tr>
                <td id="hizalama" class="auto-style17"><strong><span class="auto-style18">GİDİLECEK&nbsp;&nbsp;SAAT</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="auto-style11">
                    <strong>
                        <asp:TextBox ID="TextBox2" runat="server" Height="37px" TextMode="DateTimeLocal" Width="223px" meta:resourcekey="TextBox2Resource1" BackColor="#CCFFFF" BorderColor="Black" BorderStyle="Solid" CssClass="auto-style16" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style11">
                    <strong>
                        <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click" Text="ONAYLA" Width="153px" meta:resourcekey="Button1Resource1" BackColor="#CCFFFF" BorderColor="Black" CssClass="auto-style16" />
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style24"></asp:Label>
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">&nbsp;</td>
            </tr>
        </table>

        <p class="auto-style20">
            &nbsp;</p>
        <p class="auto-style20">
            <strong><em><span class="auto-style21">ONAYLANAN ARAÇ TALEPLERİ</span></em></strong></p>
        <p class="auto-style20">
            &nbsp;</p>
        <div class="auto-style22" id="DURUM">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BorderColor="#9900CC" BorderStyle="Solid" HorizontalAlign="Center" OnLoad="Page_Load" CssClass="auto-style23" Height="73px" Width="1189px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField HeaderText="ADRES" ReadOnly="True" DataField="adres"/>
                    <asp:BoundField HeaderText="ZAMAN" ReadOnly="True" DataField="tarih_saat" />
                    <asp:BoundField HeaderText="ARAÇ MODELİ" ReadOnly="True"  DataField="arac_model"/>
                    <asp:BoundField HeaderText="ARAÇ PLAKASI" ReadOnly="True" DataField="plaka"/>
                    <asp:BoundField HeaderText="ŞOFÖR AD SOYAD" ReadOnly="True" DataField="surucu_ad_soyad"/>
                    <asp:BoundField HeaderText="DURUM" DataField="durum" ReadOnly="True" />
                </Columns>
                <EditRowStyle BackColor="#7C6F57" BorderStyle="Solid" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>

    </form>
</body>
</html>
