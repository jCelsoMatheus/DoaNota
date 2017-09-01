<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Doacao.aspx.cs" Inherits="DoaNota.Doacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div style="text-align: center">
    <div class="intro-lead-in" style=" text-shadow: 3px 3px #fed136;" >
        <h1>Selecione a Entidade que você quer doar</h1>
    </div>
            </div>
        <br />

        <div style="text-align: center">
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    </div>
        <br />
        <div style="text-align: center">               
            <asp:Button ID="btnQrCode" runat="server" CssClass=" btn btn-xl" Text="Selecione a Entidade" OnClick="btnQrCode_Click1" />                     
        </div>
    </form>
</body>
</html>
