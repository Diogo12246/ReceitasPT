<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TOP5.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.TOP5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="../RESOURCES/css/Style.css" rel="stylesheet" />
    <link href="../RESOURCES/css/receitastodas.css" rel="stylesheet" />
    <script src="../RESOURCES/js/submeter.js"></script>
    <meta charset="utf-8" />
    <title>TOP 5
    </title>
    <style>
        footer {
    text-align: center;
    width: 100%;
    background-color: #222222;
    color: #fff;
    position: fixed;
    left: 0px;
    bottom: 0px;
    height: 50px;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <nav class="navbar-inverse" role="navigation">
        <div class="container-fluid">
            <div class="navbar-header">
                <div class="navbar-brand-name">
                    <a href="HomePage.aspx">
                    <asp:LinkButton runat="server" ID="btnHomePage" OnClick="redirectsubmeterhome_Click">
                        <h3 style="color:aliceblue;padding-bottom:2%;padding-left:5%">ReceitasPT</h3>
                    </asp:LinkButton>
                    </a>
                </div>
            </div>
        </div>
    </nav>
    <!---FORMS--->

        <div class="container">
            <div class="row form-group">
                <div class="col-xs-12">
                    <ul class="nav nav-pills nav-justified thumbnail setup-panel">
                        <li class="active"><a href="#step-1">
                            <h4 class="list-group-item-heading">Receitas</h4>
                            <p class="list-group-item-text">Todas as Receitas</p>
                        </a></li>
                    </ul>
                </div>
            </div>
            <div class="row setup-content" id="step-1">
                <div class="col-xs-12">
                    <div class="col well">
                        <asp:Label runat="server" Text="Carregue no Número para visitar a Receita"></asp:Label>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <table>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" Width="960px" GridLines="None">
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                        <EditRowStyle BackColor="#999999" />
                                        <FooterStyle BackColor="#5d7b9d" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                        <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                        <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <table style="border: 1px solid Blue; background-color: #FFF7F7">
                                                        <tr>
                                                            <td>
                                                                <asp:LinkButton runat="server" OnClick="lkbtnreceita_Click" ID="lkbtnreceita" Text='<%#Eval("ID")%>'></asp:LinkButton>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField  HeaderText="Receita" DataField="Receita" />
                                            <asp:BoundField  HeaderText="Autor" DataField="Autor"/>
                                            <asp:BoundField  HeaderText="Categoria" DataField="Categoria"/>
                                            <asp:BoundField  HeaderText="Dificuldade" DataField="Dificuldade"/>
                                            <asp:BoundField  HeaderText="Duração" DataField="Duração"/>
                                        </Columns>
                                    </asp:GridView>
                                </td>
                                <td>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                    </asp:Repeater>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <footer>
        <div class="footer">
            <p style="text-align: center">&copy 2018 - ReceitasPT por Diogo Sousa RUMOS</p>
        </div>
    </footer>
</body>
</html>
