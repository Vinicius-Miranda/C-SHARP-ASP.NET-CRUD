<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

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
                    <a class="navbar-brand" href="javascript:void(0)">Controle de Pessoal</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="javascript:void(0)">Home</a></li>
                    <li><a href="Pages/Cadastro.aspx">Cadastrar</a></li>
                    <li><a href="Pages/Consultar.aspx">Consultar</a></li>
                    <li><a href="Pages/Detalhes.aspx">Detalhes</a></li>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="jumbotron">
                <h1>C.R.U.D.</h1>
                    <h4>C# - ASP.NET (WEB FORM)</h4>
            </div>

        </div>
    </form>
</body>
</html>
