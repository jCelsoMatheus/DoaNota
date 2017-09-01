<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="DoaNota.cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>

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
        <div>
            <style type="text/css">
                .centro-pg {
                    padding-top: 111px;
                }
            </style>
            <div class="container centro-pg">
                <div class="row" style="text-align: center">
                    <h1>Cadastro Doe Nota</h1>
                </div>
                <div class="row">
                    <div class="container">
                        <div>
                            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
                            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblConfSenha" runat="server" Text="Confirmar Senha:"></asp:Label>
                            <asp:TextBox ID="txtConfSenha" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
                        </div>
                        <br />
                        <div style="text-align: center">
                            <asp:Button ID="btnCadastrar" type="Button" runat="server" Text="Cadastrar" CssClass="btn btn-primary active" OnClick="btnCadastrar_Click" />
                            <asp:Button ID="btnCancelar" type="Button" runat="server" Text="Cancelar" CssClass="btn btn-primary active" OnClick="btnCancelar_Click" />
                        </div>
                        <br />

                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
