<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="Site.Pages.Consultar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        
        <nav class="navbar navbar-inverse">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="../Default.aspx">Controle de Pessoal</a>
                </div>
                <ul class="nav navbar-nav">
                    <li><a href="../Default.aspx">Home</a></li>
                    <li><a href="Cadastro.aspx">Cadastrar</a></li>
                    <li class="active"><a href="javascript:void(0)">Consultar</a></li>
                    <li><a href="Detalhes.aspx">Detalhes</a></li>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="jumbotron">
                <h1>Consulta</h1>
            </div>
            <div class="col-sm-12">
                <asp:GridView ID="gridPessoas" runat="server" Width="100%">

                </asp:GridView>
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>
            </div> 
        </div>
    </form>
</body>
</html>
