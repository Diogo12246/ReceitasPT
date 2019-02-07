<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receita.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.Receita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <%--    <link href="../RESOURCES/css/Style.css" rel="stylesheet" />--%>
    <link href="../RESOURCES/css/receita.css" rel="stylesheet" />
    <script src="../RESOURCES/js/submeter.js"></script>
    <meta charset="utf-8" />
    <title>Receita Escolhida</title>
    <style>
        body {
            margin: 0;
            color: #6a6f8c;
            background: #c8c8c8;
            font: 600 16px/18px 'Open Sans',sans-serif;
            background: url('../RESOURCES/IMAGES/welcome.jpg');
            background-repeat: no-repeat;
            background-position: center center;
            background-attachment: fixed;
            background-size: cover;
            background-color: #343a40;
            -webkit-background-size: cover;
            -moz-background-size: cover;
            -o-background-size: cover;
            background-size: cover;
        }

        footer {
            justify-content: center;
            align-items: center;
            display: flex;
            position: static;
            left: 0px;
            bottom: 0px;
            height: 40px;
            width: 100%;
            color: #fff;
            background-color: #222222;
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
                            <h4 class="list-group-item-heading">Receita Escolhida!</h4>
                            <p class="list-group-item-text">Observe a sua Receita!</p>
                        </a></li>
                    </ul>
                </div>
            </div>
            <div class="row setup-content" id="step-1">
                <div class="col-xs-12">
                    <div class="col well">
                        <div class="form-group">
                            <asp:Image Width="500px" Height="200px" runat="server" ID="imagemreceita" />
                        </div>
                        <div class="form-group">
                            <label>Nome da Receita</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="true" Width="500px" ID="receitanome" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Autor</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="true" Width="500px" ID="receitaAutor" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Descrição</label>
                            <div class="input-group">
                                <asp:TextBox type="text" TextMode="MultiLine" Rows="5" class="form-control" ReadOnly="true" Width="500px" ID="ReceitaDescricao" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Duração</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="true" Width="500px" ID="receitaDuracao" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Dificuldade</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="true" Width="500px" ID="receitaDificuldade" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label>Categoria</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="true" Width="500px" ID="receitaCategoria" runat="server" />
                            </div>
                        </div>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <label>Ingredientes da Receita</label>
                        <div>
                            <h3></h3>
                        </div>
                        <table>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" Width="498px" GridLines="None">
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
                                                            <td></td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField HeaderText="Ingrediente" DataField="Ingrediente" />
                                            <asp:BoundField HeaderText="Unidade" DataField="Unidade" />
                                            <asp:BoundField HeaderText="Quantidade" DataField="Quantidade" />
                                        </Columns>
                                    </asp:GridView>
                                </td>
                                <td>
                                    <asp:Repeater ID="Repeater1" runat="server">
                                    </asp:Repeater>
                                </td>
                            </tr>
                        </table>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <div>
                            <h3></h3>
                        </div>

                        <asp:Label runat="server">Rating!</asp:Label>
                        <asp:Image runat="server" ID="ratingimagem" max-height="50px" max-width="50px;" />

                        <div>
                            <h3></h3>
                        </div>
                        <asp:Label runat="server">Deixe o seu voto também! de 1 a 5!</asp:Label>
                        <asp:TextBox Width="50px" ID="vototxt" runat="server"></asp:TextBox>
                        <asp:Button runat="server" ID="votarreceita" Text="Votar!" OnClick="votarreceita_Click" />
                        <asp:Label ID="votostatus" runat="server"></asp:Label>
                        <asp:RegularExpressionValidator Display="Dynamic"
                            ControlToValidate="vototxt"
                            ID="RegularExpressionValidator2"
                            ValidationExpression="^(5|[1-5]?[1-5])$"
                            runat="server"
                            ForeColor="Red"
                            ErrorMessage="Só são aceites números de 1 a 5.">
                        </asp:RegularExpressionValidator>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <div>
                            <h3></h3>
                        </div>
                        <div>
                            <asp:Button runat="server" ID="addaosfav" Text="Adicionar aos favoritos" OnClick="addaosfav_Click" />
                        </div>
                        <div>
                            <h6></h6>
                        </div>
                        <div>
                            <asp:Button runat="server" ID="remvdosfav" Text="Remover dos favoritos" OnClick="remvdosfav_Click" />
                        </div>
                        <div>
                            <asp:Label runat="server" ID="lblfavstatus"></asp:Label>
                        </div>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <label>Comentários!</label>
                        <table>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="false" Width="498px" GridLines="None">
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
                                                            <td></td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField HeaderText="Autor" DataField="Autor" />
                                            <asp:BoundField HeaderText="Comentário" DataField="Comentário" />
                                        </Columns>
                                    </asp:GridView>
                                </td>
                                <td>
                                    <asp:Repeater ID="Repeater2" runat="server">
                                    </asp:Repeater>
                                </td>
                            </tr>
                        </table>
                        <div>
                            <h3></h3>
                        </div>
                        <hr style="width: 100%; color: black; height: 1px; background-color: black;" />
                        <div class="form-group">
                            <label>Comente também :D</label>
                            <div class="input-group">
                                <asp:TextBox type="text" class="form-control" ReadOnly="false" Width="500px" ID="txtcomment" runat="server" />
                            </div>
                        </div>
                        <div class="input-group">
                            <asp:Button ID="btninserircomment" Text="Postar Comentário!" OnClick="btninserircomment_Click" runat="server" />
                        </div>
                        <div>
                            <h3></h3>
                        </div>
                        <div>
                            <h3></h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer>
            <div class="footer">
                <p style="text-align: center">&copy 2018 - ReceitasPT por Diogo Sousa RUMOS</p>
            </div>
        </footer>
    </form>

</body>
</html>
