<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoTOO.Administracion.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,600"/>
    <link href="Style/css/tooplate-style.css" rel="stylesheet" />
    <link href="Style/css/css.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
    <div class="body">
    	<div class="container" id="home">
            <div class="col-12 text-center">
              <div class="tm-page-header">
                <h1 class="d-inline-block text-uppercase">Sistema de Seguridad para la empresa de Recursos Humanos.</h1>
              </div>
            </div>
        </div> 
      
      <div class="container tm-features-section" id="features"> 
        <div class="Conten">
            <h3>Bienvenido al sistema!!!</h3> 
            <h3>Registrate:</h3> 
            <form id="form1" runat="server" class="form">

                <asp:Label CssClass="label" ID="Label1" runat="server" Text="Label">Usuario</asp:Label>
                <asp:TextBox CssClass="input" ID="txtUsuario" runat="server"></asp:TextBox>
                <asp:Label CssClass="label" ID="Label2" runat="server" Text="Label">Passcode</asp:Label>
                <asp:TextBox CssClass="input" ID="txtPasscode" runat="server" TextMode="Password" ></asp:TextBox>
                <asp:Button CssClass="Button" ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click"/>
                <asp:Label CssClass="label" ID="lblError" runat="server" Text="" Visible="false"></asp:Label>
            </form>
        </div>
      </div>

      <footer class="container tm-footer">
        <div class="row tm-footer-row">
          <p class="col-md-10 col-sm-12 mb-0">
            Proyecto de Tecnologías Orientadas a Objetos 2021.
          </p>
        </div>
      </footer>
    </div>
</body>
</html>
