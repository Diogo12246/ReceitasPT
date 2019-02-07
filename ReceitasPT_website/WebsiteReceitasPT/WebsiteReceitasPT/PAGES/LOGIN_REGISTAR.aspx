<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN_REGISTAR.aspx.cs" Inherits="WebsiteReceitasPT.PAGES.LOGIN_REGISTAR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../RESOURCES/css/Login_Register.css" rel="stylesheet" />
    <script src="../RESOURCES/js/login.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<style>

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
<!---->
<nav class="navbar-inverse navbar-fixed-top" role="navigation">
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
<!---->

        <div class="login-wrap">
	<div class="login-html">
		<input id="tab-1" type="radio" name="tab" class="sign-in" checked><label for="tab-1" class="tab">Entrar</label>
		<input id="tab-2" type="radio" name="tab" class="sign-up"><label for="tab-2" class="tab">Registar</label>
		<div class="login-form">
			<div class="sign-in-htm">
				<div class="group">
					<asp:label for="user" class="label" runat="server">Username</asp:label>
					<asp:textbox id="username" type="text" class="input" runat="server"/>
				</div>
				<div class="group">
					<asp:label for="pass" class="label" runat="server">Password</asp:label>
					<asp:textbox id="userpass" type="password" class="input" data-type="password" runat="server"/>
				</div>
				<div class="group">
					<asp:button OnClick="ValidateUser"  type="submit" class="button" value="Entrar" runat="server" Text="Entrar"/>
				</div>
				<div class="hr"></div>
                <br />
                <br />
                <div class="foot-lnk">
				</div>
			</div>
			<div class="sign-up-htm">
				<div class="group">        
					<asp:label for="user" class="label" runat="server">Username</asp:label>
					<asp:textbox id="usersup" type="text" class="input" runat="server"/>
                    <asp:RegularExpressionValidator Display = "Dynamic" 
                        ControlToValidate = "usersup" 
                        ID="RegularExpressionValidator1" 
                        ValidationExpression = "^[\s\S]{5,}$" 
                        runat="server" 
                        ForeColor="Red"
                        ErrorMessage="Username tem de conter 5 caracteres no mínimo.">
                    </asp:RegularExpressionValidator>
				</div>
				<div class="group">
					<asp:label for="pass" class="label" runat="server">Password</asp:label>
					<asp:textbox id="passsup" type="password" class="input" data-type="password" runat="server"/>
                    <asp:RegularExpressionValidator Display = "Dynamic" 
                        ControlToValidate = "passsup" 
                        ID="RegularExpressionValidator2" 
                        ValidationExpression = "^[\s\S]{8,}$" 
                        runat="server" 
                        ForeColor="Red"
                        ErrorMessage="Password tem de conter 8 caracteres no mínimo.">
                    </asp:RegularExpressionValidator>
				</div>
				<div class="group">
					<asp:label for="pass" class="label" runat="server">Email Address</asp:label>
					<asp:textbox id="emailsup" type="text" class="input" runat="server"/>
				</div>
				<div class="group">
					<asp:button type="submit" Onclick="Registar_user" class="button" value="Registar" text="Registar" runat="server"/>
				</div>


			</div>
		</div>
	</div>
</div>
<footer>
  <div class="copyright">
    <p style="text-align:center">&copy 2018 - ReceitasPT por Diogo Sousa RUMOS</p>
  </div>
</footer>
    </form>


</body>
</html>

