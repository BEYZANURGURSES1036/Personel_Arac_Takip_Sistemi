<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="dsistajwebarac.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://kit.fontawesome.com/c20485228a.js"
        crossorigin="anonymous"></script>
    <style type="text/css">
        body {
            background: url(dsi.jpg) no-repeat center center fixed;
             background-size: cover;
        }

        .auto-style1 {
            margin-top: 56px;
            text-align: center;
            height: 259px;
        }

        .auto-style2 {
            color: #FFFFFF;
        }

        .auto-style3 {
            color: #CCFFFF;
            text-align: right;
            margin-right: 50px;
            font-size: large;
        }

        .auto-style4 {
            text-decoration: none;
        }

        .auto-style7 {
            text-align: right;
            height: 53px;
        }

        .auto-style8 {
            font-size: xx-large;
        }
    </style>
</head>
<body>

    <div class="auto-style4">
        <h1 class="auto-style7">
            <asp:Image ID="Image1" runat="server" BorderStyle="Solid" CssClass="auto-style8" Height="41px" ImageUrl="~/user.jpg" Width="37px" />
            <a class="auto-style4" href="login.aspx"><span class="auto-style3"><strong><em>GİRİŞ</em></strong></span></a></h1>
    </div>


    <h1 class="auto-style1"><span class="auto-style2">DEVLET&nbsp;&nbsp;SU&nbsp; İŞLERİ&nbsp;&nbsp;GENEL&nbsp;&nbsp;MÜDÜRLÜĞÜ</span><br class="auto-style2" />
        <br class="auto-style2" />
        <span class="auto-style2">&nbsp;ARAÇ&nbsp;&nbsp;ENVANTER&nbsp;&nbsp;SİSTEMİ </span></h1>

</body>
</html>
