<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QrCode.aspx.cs" Inherits="DoaNota.QrCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <title>Leitor QrCode</title>

    <link rel="stylesheet" type="text/css" href="/css/bootstrap.min.css" />
    <!--<link rel="stylesheet" href="/css/bootstrap-theme.min.css" />-->

    <style type="text/css">
        /* Seus estilos aqui! :) */
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="container-fluid" style="background-color:black; margin-top:3px; text-align:center ">
                <h3 style="color:white" >Aproxime o QRCode na camera </h3>
            </div>

            <%--<div class="alert alert-success alert-dismissible">
                <a href="doacao.aspx" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                <strong>Success!</strong> Indicates a successful or positive action.
            </div>--%>
            <!-- Seu código aqui! :) -->
            <div style="text-align: center; margin-top:10px;" Cssclass="panel-body" >
                <video id="preview" width="600" height="225" style="display: inline-block; vertical-align: bottom; visibility: hidden;"></video>
                <canvas id="qr-canvas" width="600" height="225" style="display: none;"></canvas>
            </div>
            <br />
            <br />
            <div style="text-align: center">

                
               

            </div>

            <script type="text/javascript" charset="utf-8" src="/js/jquery-2.2.1.min.js"></script>
            <script type="text/javascript" charset="utf-8" src="/js/bootstrap.min.js"></script>
            <script type="text/javascript" charset="utf-8" src="/js/utils.js"></script>

            <script type="text/javascript" src="/js/qr/grid.js"></script>
            <script type="text/javascript" src="/js/qr/version.js"></script>
            <script type="text/javascript" src="/js/qr/detector.js"></script>
            <script type="text/javascript" src="/js/qr/formatinf.js"></script>
            <script type="text/javascript" src="/js/qr/errorlevel.js"></script>
            <script type="text/javascript" src="/js/qr/bitmat.js"></script>
            <script type="text/javascript" src="/js/qr/datablock.js"></script>
            <script type="text/javascript" src="/js/qr/bmparser.js"></script>
            <script type="text/javascript" src="/js/qr/datamask.js"></script>
            <script type="text/javascript" src="/js/qr/rsdecoder.js"></script>
            <script type="text/javascript" src="/js/qr/gf256poly.js"></script>
            <script type="text/javascript" src="/js/qr/gf256.js"></script>
            <script type="text/javascript" src="/js/qr/decoder.js"></script>
            <script type="text/javascript" src="/js/qr/qrcode.js"></script>
            <script type="text/javascript" src="/js/qr/findpat.js"></script>
            <script type="text/javascript" src="/js/qr/alignpat.js"></script>
            <script type="text/javascript" src="/js/qr/databr.js"></script>
            <script type="text/javascript" charset="utf-8" src="/js/qr/custom.js"></script>
            <script type="text/javascript" charset="utf-8" src="/js/jquery-2.2.1.min.js"></script>
            <script>
                function grava(rs1, rst2) {
                    WebAPI.getAsync("/api/NfeDbo/GetCustomers", terminou, "cfe", rs1, "total", rst2, "id", <%=Request.QueryString["id"] %>);
                }
            </script>
        </div>
    </form>
</body>
</html>
