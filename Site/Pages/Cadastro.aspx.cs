using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagemOk.Text = null;
            lblMensagemFail.Text = null;
        }

        protected void CadastrarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Residencia = new Endereco();

                p.Nome = txtNome.Text;
                p.Email = txtEmail.Text;
                p.DataHoraCadastro = DateTime.Now;
                p.Residencia.Logradouro = txtLogradouro.Text;
                p.Residencia.Cidade = txtCidade.Text;
                p.Residencia.Estado = txtEstado.Text;

                PessoaDal d = new PessoaDal();
                d.Salvar(p);

                txtNome.Text = null;
                txtEmail.Text = null;
                txtLogradouro.Text = null;
                txtCidade.Text = null;
                txtEstado.Text = null;

                lblMensagemOk.Text = "Cliente cadastrado com sucesso !";
            }
            catch
            {
                lblMensagemFail.Text = "Erro ao tentar cadastrar cliente !";
            }
        }
    }
}