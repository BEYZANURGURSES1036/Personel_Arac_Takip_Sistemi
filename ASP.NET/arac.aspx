<%@ Page Title="" Language="C#" AutoEventWireup="true"  CodeBehind="arac.aspx.cs" Inherits="dsistajwebarac.arac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html  ; charset=utf-8" />
    <style type="text/css">
        body{
            width:100%;
            background: url(arac.jpg) no-repeat center center fixed;
              background-size: cover;
        }
        .auto-style1 {
            width: 63%;
            margin-bottom: 0px;
            height: 127px;
        }
        .auto-style10 {
            height: 84px;
            width: 212px;
        }
        .auto-style13 {
            width: 240px;
            font-size: medium;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style14 {
            width: 240px;
            height: 84px;
        }
        .auto-style17 {
            width: 301px;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style18 {
            width: 196px;
            height:39px;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style19 {
            color: #FFFFFF;
            background-color: #CC00CC;
        }
        .auto-style20 {
            background-color: #CCFFFF;
        }
        
        .auto-style2 {
            text-align: right;
            height: 29px;
        }
        .auto-style5 {
            font-size: medium;
        }
        .auto-style4 {
            margin-right: 50px;
            text-decoration: none;
        }
        .auto-style3 {
            color: #336600;
        }
        .auto-style6 {
            color: #000000;
            font-size: large;
            text-align: center;
        }
        .auto-style21 {
            text-align: center;
        }
        .auto-style22 {
            font-size: large;
            background-color: #FFFFFF;
        }
        .auto-style26 {
            width: 174px;
            font-size: medium;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style27 {
            height: 84px;
            width: 180px;
        }
        .auto-style28 {
            width: 220px;
            font-size: medium;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style30 {
            width: 214px;
            font-size: medium;
            color: #FFFFFF;
            background-color: #000066;
        }
        .auto-style31 {
            width: 214px;
            height: 84px;
        }
        .auto-style32 {
            height: 84px;
            width: 174px;
        }
        .auto-style33 {
            height: 84px;
            width: 196px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style21">
        <div class="auto-style2">
            
            <asp:Image  ID="Image1"  runat="server" ImageUrl="~/exit.png" Height="30px" Width="26px" meta:resourcekey="Image1Resource1" /><strong><em><span class="auto-style5"><a class="auto-style4" href="index.aspx">ÇIKIŞ</a></span></em></strong><br />
            
            </div>
        <div>
            <h2 class="auto-style3">&nbsp;</h2>
            <p class="auto-style6"><strong>DEVLET&nbsp; SU İŞLERİ&nbsp; GENEL&nbsp; MÜDÜRLÜĞÜ&nbsp; ARAÇ ENVANTER&nbsp; SİSTEMİ</strong></p>
            <p class="auto-style6">&nbsp;</p>
        </div>

            <br />
        <table class="auto-style1">
            <tr>
                
                <td class="auto-style30"><strong><em>PERSONEL AD SOYAD</em></strong></td>
                <td class="auto-style13"><strong><em>GİDİLECEK YER</em></strong></td>
                <td class="auto-style26"><strong><em>ZAMAN</em></strong></td>
                <td class="auto-style28"><strong><em>AİT OLDUĞU KURULUŞ</em></strong></td>
                <td class="auto-style17"><strong><em>ŞOFÖR</em></strong></td>
                <td class="auto-style18"><strong><em>ARAÇ</em></strong></td>
            </tr>
            <tr>
                
                <td class="auto-style31">
                    <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Height="39px" OnLoad="TextBox1_TextChanged" ReadOnly="True" Width="177px" CssClass="auto-style20"></asp:TextBox>
                </td>
                <td class="auto-style14">
                    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Height="39px" OnLoad="TextBox2_TextChanged" ReadOnly="True" Width="186px" CssClass="auto-style20"></asp:TextBox>
                </td>
              
                <td class="auto-style32">
                    <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Height="39px" OnLoad="TextBox3_TextChanged" ReadOnly="True" Width="175px" CssClass="auto-style20"></asp:TextBox>
                </td>
                  <td class="auto-style27">
                    <asp:TextBox ID="TextBox4" runat="server"  Height="39px" ReadOnly="True" Width="146px" CssClass="auto-style20"></asp:TextBox>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="DropDownList1" runat="server"  Height="39px" Width="212px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"  CssClass="auto-style20">
                        <asp:ListItem Text="Seçiniz">
                            Seçiniz
                        </asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style33">
                    <asp:DropDownList ID="DropDownList2" runat="server"  Height="39px" Width="212px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True"  CssClass="auto-style20">
                        <asp:ListItem Text="Seçiniz">
                            Seçiniz
                        </asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Height="59px" Width="82px" Text="Onayla" CssClass="auto-style19" />
                    </td>
               </tr>         
        </table>
            <asp:Label ID="Label1" runat="server" CssClass="auto-style22" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
   
</body>
</html>
