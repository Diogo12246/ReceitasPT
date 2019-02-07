<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaineldeUser.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.PaineldeUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet"/>
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<link href="../RESOURCES/css/Style.css" rel="stylesheet" />
<link href="../RESOURCES/css/Submeter.css" rel="stylesheet" />
<script src="../RESOURCES/js/submeter.js"></script>
<meta charset="utf-8"/>
    <title>Painel de Utilizador</title>
    <style>

hr {
  -moz-border-bottom-colors: none;
  -moz-border-image: none;
  -moz-border-left-colors: none;
  -moz-border-right-colors: none;
  -moz-border-top-colors: none;
  border-color: #EEEEEE -moz-use-text-color #FFFFFF;
  border-style: solid none;
  border-width: 1px 0;
  margin: 18px 0;
}
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
.navbar {
    background-color: #343a40;
    padding: 1% 0%;
    font-size: 14px;
}

.navbar-default .navbar-nav li a {
    color: #D5D5D5
}

.navbar-default .navbar-nav li a:hover,
.navbar-default .navbar-nav li a:active {
        color: #fff
    }

.navbar-brand-name > {
    display: inline-block;
    float: left;
}

.navbar-brand-name > img {
        display: inline-block;
        float: left;
        padding: 0 15px 0 0;
    }
#items1step{
    margin-left:0px;
}
    </style>
</head>
<body>
<form id="form1" runat="server">
<nav class="navbar-inverse" role="navigation">
    <div class="container-fluid">
        <div class="navbar-header">
<div class="navbar-brand-name">
                    <asp:LinkButton runat="server" ID="btnHomePage" OnClick="redirectsubmeterhome_Click">
                        <h3 style="color:aliceblue;padding-bottom:2%;padding-left:5%">ReceitasPT</h3>
                    </asp:LinkButton>
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
                    <h4 class="list-group-item-heading">Utilizador</h4>
                    <p class="list-group-item-text">Definições de Utilizador</p>
                </a></li>
            </ul>
        </div>
	</div>
    <div class="row setup-content" id="step-1">
        <div class="col-xs-12">
            <div class="col well">
<div class="row">
     <div class="col-sm-offset-4 col-sm-6" style="margin-left:0px">
                <div class="form-group">
                    <label>Ultimas Pesquisas</label>
                      <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                    <label>Aqui fica tudo o que o utilizador(a) inseriu na barra de pesquisa!</label>
                    
                    <div class="input-group">
                        <asp:DropDownList runat="server" width="500px" id="userultimapesquisa"></asp:DropDownList>
                        <br />
                        <br />
                        <asp:button id="ultimapesquisabtn" class="btn btn-primary btn-lg" OnClick="ultimapesquisabtn_Click" runat="server" Text="Pesquisar"></asp:button>
                    </div>
                      <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                    <asp:Label runat="server"> FAVORITOS </asp:Label>
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
    </div>
</div>
</form>
    <footer>
  <div class="footer">
    <p style="text-align:center">&copy 2018 - ReceitasPT por Diogo Sousa RUMOS</p>
  </div>
</footer>
</body>
</html>