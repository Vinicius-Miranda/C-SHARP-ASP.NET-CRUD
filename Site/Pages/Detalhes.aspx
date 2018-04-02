<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

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
                    <li><a href="Consultar.aspx">Consultar</a></li>
                    <li class="active"><a href="javascript:void(0)">Detalhes</a></li>
                </ul>
            </div>
        </nav>
        <div class="container">
            <div class="jumbotron">
                <h1>Detalhes</h1>
            </div>
            <div class="form-group">
                <div class="col-sm-2">
                    <label>ID Pessoa</label>
                    <asp:TextBox ID="txtIdPessoa" runat="server" class="form-control" />
                </div>
                <div class="col-sm-10">
                    <br />
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar Pessoa" class="btn btn-info" OnClick="ObterPorId" />
                </div>
            </div>
            <div class="col-sm-12">
                <br /><p>
                    <asp:Label ID="lblMensagem" runat="server" class="label label-danger" />
                </p>
                <hr />
            </div>
            <div class="col-sm-12">
            </div>
            <asp:Panel ID="painel" runat="server">
                <div class="form-group">
                    <div class="col-sm-6">
                        <label>Nome</label>
                        <asp:TextBox ID="txtNome" runat="server" class="form-control" />
                    </div>
                    <div class="col-sm-6">
                        <label>E-mail</label>
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" /><br />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-6">
                        <label>Logradouro</label>
                        <asp:TextBox ID="txtLogradouro" runat="server" class="form-control" />
                    </div>
                    <div class="col-sm-4">
                        <label>Cidade</label>
                        <asp:TextBox ID="txtCidade" runat="server" class="form-control" />
                    </div>
                    <div class="col-sm-2">
                        <label>Estado</label>
                        <asp:TextBox ID="txtEstado" runat="server" class="form-control" /><br />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-12">
                        <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar Pessoa" class="btn btn-warning" OnClick="AtualizarPessoa" />
                        <asp:Button ID="btnExcluir" runat="server" Text="Excluir Pessoa" class="btn btn-danger" OnClick="ExcluirPessoa" />
                    </div>
                    <div class="col-sm-12">
                        <br /><p>
                            <asp:Label ID="lblMensagemOk" runat="server" class="label label-success" />
                            <asp:Label ID="lblMensagemFail" runat="server" class="label label-danger" />
                        </p>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
