<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="DoaNota.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap Core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css" />
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css' />
    <link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css' />

    <!-- Theme CSS -->
    <link href="css/agency.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="conteiner">
            <style type="text/css">
                .centro-pg-login {
                    padding-top: 205px;
                    background-color: aliceblue;
                }
            </style>
            <div class="container">
                <div>
                    <div class="row">
                        <div class="col-lg-4"></div>
                        <div class="col-lg-4 centro-pg-login" style="text-align: center">
                            <div class="row">
                                <h2>Login</h2>
                            </div>
                            <div>
                                <asp:TextBox ID="txtDigiteEmail" runat="server" CssClass="form-control" placeholder="Digite o seu email"></asp:TextBox>
                            </div>
                            <br />
                            <div>
                                <asp:TextBox ID="txtDigiteSenha" runat="server" TextMode="Password" CssClass="form-control" placeholder="Digite a sua senha"></asp:TextBox>
                            </div>
                            <div>
                                <asp:Label ID="lblAviso" runat="server" Text=""></asp:Label>
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />
                            </div>
                            <br />
                            <div>
                                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" OnClick="btnVoltar_Click" />
                            </div>

                        </div>
                        <div class="col-lg-4"></div>

                    </div>
                </div>

            </div>
        </div>
        </div>
      
    </form>
</body>
</html>
