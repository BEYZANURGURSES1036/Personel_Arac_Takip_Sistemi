<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bsofor.aspx.cs" Inherits="dsistajwebarac.bsofor" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js"></script>
    <link href="https://cdn.datatables.net/1.10.20/css/jquery.dataTables.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id*=GridView1]").DataTable(
                {
                    bLengthChange: true,
                    lengthMenu: [[5, 10, -1], [5, 10, "All"]],
                    bFilter: true,
                    bSort: true,
                    bPaginate: true
                });
        });
    </script>

    <style>
        body {
            text-align: center;
            background: url(arac.jpg) no-repeat center center fixed;
            background-size: cover;
        }

        .auto-style2 {
            text-align: right;
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
        }

        .auto-style7 {
            color: #000066;
            font-size: medium;
        }
    </style>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <div class="auto-style2">

                <asp:Image ID="Image1" runat="server" ImageUrl="~/exit.png" Height="24px" Width="26px" meta:resourcekey="Image1Resource1" /><strong><em><span class="auto-style5"><a class="auto-style4" href="index.aspx">ÇIKIŞ</a></span></em></strong><br />

            </div>
            <div>
                <h2 class="auto-style3">&nbsp;</h2>
                <p class="auto-style6"><strong>DEVLET&nbsp; SU İŞLERİ&nbsp; GENEL&nbsp; MÜDÜRLÜĞÜ&nbsp; ARAÇ ENVANTER&nbsp; SİSTEMİ</strong></p>
                <h2 class="auto-style3">&nbsp;</h2>
                <h2 class="auto-style7">ARAÇ YÖNLENDİRİLMESİ GEREKENLER</h2>
                <p class="auto-style7">&nbsp;</p>
            </div>
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="25" Width="100%" ForeColor="#333333" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="p_ID,yer_ID">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="p_ad_soyad" HeaderText="PERSONEL AD SOYAD" />
                    <asp:BoundField DataField="adres" HeaderText="GİDİLECEK YER" />
                    <asp:BoundField DataField="tarih_saat" HeaderText="GİDİLECEK ZAMAN" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" Text="Araç Seç" CommandName="get" CommandArgument="<%# Container.DataItemIndex %>" />

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57" />
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
