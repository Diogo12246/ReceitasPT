<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SubmeterReceita.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.SubmeterReceita" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="../RESOURCES/css/Style.css" rel="stylesheet" />
    <link href="../RESOURCES/css/Submeter.css" rel="stylesheet" />
    <script src="../RESOURCES/js/submeter.js"></script>
    <meta charset="utf-8" />
    <title>Submeter Receita</title>
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
            padding-bottom: 1%;
        }

            .navbar-brand-name > img {
                display: inline-block;
                float: left;
                padding: 0 15px 0 0;
            }

        #items1step {
            margin-left: 0px;
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
                            <h4 class="list-group-item-heading">Receita</h4>
                            <p class="list-group-item-text">Dados da Receita</p>
                        </a></li>
                        <li class="disabled"><a href="#step-2">
                            <h4 class="list-group-item-heading">Ingredientes</h4>
                            <p class="list-group-item-text">Escolha de Ingredientes</p>
                        </a></li>
                        <li class="disabled"><a href="#step-3">
                            <h4 class="list-group-item-heading">Imagem e Conclusão</h4>
                            <p class="list-group-item-text">Vamos a isso!</p>
                        </a></li>
                    </ul>
                </div>
            </div>
            <div class="row setup-content" id="step-1">
                <div class="col-xs-12">
                    <div class="col well">
                        <div class="row">
                            <div class="col-sm-offset-4 col-sm-6" style="margin-left: 0px">
                                <div class="form-group">
                                    <label for="Receita_Nome">Nome da Receita</label>
                                    <div class="input-group">
                                        <asp:TextBox type="text" class="form-control" Width="500px" name="validate-text" ID="receitanome" runat="server" Placeholder="Insira o nome da Receita" required="false" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="validate-optional">Descrição da receita</label>
                                    <div class="input-group">
                                        <asp:TextBox type="text" runat="server" class="form-control" TextMode="MultiLine" Width="500px" Rows="5" name="validate-optional" ID="receitadescricao" placeholder="Coloque aqui as instruções da receita" />
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="validate-optional">Categoria</label>
                                    <div class="input-group">
                                        <asp:DropDownList runat="server" Width="500px" ID="receitaCategoria"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label>Dificuldade</label>
                                    <div class="input-group">
                                        <asp:DropDownList runat="server" Width="500px" ID="receitaDificuldade"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label>Duração(minutos)</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server" Width="500px" ID="receitaduracao"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <button id="activate:step-2" onclick="return false;" class="btn btn-primary btn-lg">Ir para Ingredientes</button>
                    </div>
                </div>
            </div>
            <div class="row setup-content" id="step-2">
                <div class="col-xs-12">
                    <div class="col-md-12 well text-left">
                        <div class="form-group">
                            <label>Ingredientes </label>
                            <div class="input-group">
                                <asp:DropDownList runat="server" Width="500px" ID="ingredientelista"></asp:DropDownList>
                            </div>
                            <br />
                            <div class="input-group>">
                                <label>Unidade </label>
                                <asp:DropDownList runat="server" Width="150px" ID="ingredienteunidade"></asp:DropDownList>
                            </div>
                            <br />
                            <div class="input-group">
                                <label>Quantidade</label>
                                <asp:TextBox runat="server" Width="150px" ID="ingredientequantidade"></asp:TextBox>
                                <asp:RegularExpressionValidator ID="regexpName" runat="server"     
                                    ErrorMessage=" Número Inválido(está a usar um ponto em vez de virgula?)" 
                                    ControlToValidate="ingredientequantidade"     
                                    ValidationExpression="(?:\d|[,])+" />
                            </div>
                            <div class="input-group">
                                <br />
                                <br />
                                <asp:Button runat="server" Text="Inserir Ingrediente na Lista" OnClick="inserirIngredientesnalista_Click" ID="inserirIngredientesnalista" />
                            </div>
                        </div>
                        <br />
                        <div class="form-group">
                            <label>Ingredientes Selecionados</label>
                            <div class="input-group">
                                
                                <asp:ListBox ID="INGREDIENTESELECIONADOLISTA" Width="500px" runat="server"></asp:ListBox>
                            </div>
                        </div>
                        <button id="activate:step-1" onclick="return false;" class="btn btn-primary btn-lg">Voltar para Receita</button>
                        <button id="activate:step-3" onclick="return false;" class="btn btn-primary btn-lg">Ir para Imagem</button>
                    </div>
                </div>
            </div>
            <div class="row setup-content" id="step-3">
                <div class="col-xs-12">
                    <div class="col-md-12 well text-left">
                        <div class="form-group">
                            <label>Imagem da Receita</label>
                            <asp:Image runat="server" ID="receitaimagem" />
                            <asp:FileUpload ID="imagemupload" runat="server" />
                        </div>
                        <button id="activate:step-2" onclick="return false;" class="btn btn-primary btn-lg">Voltar para Ingredientes</button>
                        <asp:Button ID="SubmitRecipe" OnClick="SubmitRecipe_Click1" class="btn btn-primary btn-lg" runat="server" Text="Submeter!" />

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
