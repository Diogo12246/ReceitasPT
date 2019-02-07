<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaInicial.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.PaginaInicial" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" />
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
    <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    <link href="../RESOURCES/css/PI.css" rel="stylesheet" />
    <script src="../RESOURCES/js/submeter.js"></script>
    <meta charset="utf-8" />
    <title>Bem Vindo!</title>
    <style>
body {
    margin: 0;
    color: #6a6f8c;
    background: #c8c8c8;
    font: 600 16px/18px 'Open Sans',sans-serif;
    background-image: url('../RESOURCES/IMAGES/1600.jpg');
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
            position: fixed;
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
        <nav class="navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container-fluid">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navbar-collapse-main">
                        <span class="sr-only">ScreenReaders</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <div class="navbar-brand-name">
                        <asp:LinkButton runat="server" ID="btnHomePage" OnClick="redirectsubmeterhome_Click">
                        <h3 style="color:aliceblue;padding-bottom:1%;padding-left:5%">ReceitasPT</h3>
                        </asp:LinkButton>
                    </div>
                </div>
                <div class="collapse navbar-collapse" id="navbar-collapse-main">
                    <ul class="nav navbar-nav navbar-right">
                        <li>
                            <asp:LinkButton runat="server" ID="Homebutton" Text="Home" OnClick="Homebutton_Click" class="active1"></asp:LinkButton></li>
                        <li>
                            <asp:LinkButton runat="server" ID="Submeterbtn" OnClick="Submeterbtn_Click" Text="Submeter"></asp:LinkButton></li>
                        <li>
                            <asp:LinkButton runat="server" ID="TodasAsReceitasbtn" Text="Receitas" OnClick="TodasAsReceitasbtn_Click"></asp:LinkButton></li>
                        <li>
                            <asp:LinkButton runat="server" ID="paineldeuserbtn" Text="Painel de Utilizador" OnClick="paineldeuserbtn_Click"></asp:LinkButton></li>
                        <li>
                            <asp:LinkButton runat="server" ID="top5btn" Text="TOP 5" OnClick="top5btn_Click"></asp:LinkButton>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div class="logo">
            <b>Receitas_PT</b>
        </div>
        <div class="srchPT">
            <div class="neon-text">O melhor da cozinha no seu browser!</div>
        </div>
        <div class="searchbarPT">
            <asp:DropDownList runat="server" ID="dropdownhome"></asp:DropDownList>
            <asp:TextBox runat="server" ID="searchhome" Width="200px"></asp:TextBox>
            <asp:Button ID="btnhomesearch" OnClick="btnhomesearch_Click" Text="Encontrar!" runat="server" />
        </div>

    </form>
    <footer>
        <div class="footer">
            <p style="text-align: center">&copy 2018 - ReceitasPT por Diogo Sousa RUMOS</p>
        </div>
    </footer>
</body>
</html>
