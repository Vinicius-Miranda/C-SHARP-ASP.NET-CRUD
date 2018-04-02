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
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            painel.Visible = false;
            lblMensagem.Text = string.Empty;
            lblMensagemOk.Text = string.Empty;
            lblMensagemFail.Text = string.Empty;
        }

        protected void ObterPorId(object sender, EventArgs e)
        {
            try
            {
                int idPessoa = Convert.ToInt32(txtIdPessoa.Text);
                PessoaDal d = new PessoaDal();
                Pessoa p = d.BuscarPorId(idPessoa);

                if (p != null)
                {
                    txtNome.Text = p.Nome;
                    txtEmail.Text = p.Email;
                    txtLogradouro.Text = p.Residencia.Logradouro;
                    txtCidade.Text = p.Residencia.Cidade;
                    txtEstado.Text = p.Residencia.Estado;

                    painel.Visible = true;
                    lblMensagem.Text = string.Empty;
                }
                else
                {

                    lblMensagem.Text = "Pessoa não encontrada !";
                }
            }
            catch
            {
                lblMensagem.Text = "Erro ao buscar pessoa !";
            }
        }

        protected void AtualizarPessoa(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = new Pessoa();
                p.Residencia = new Endereco();

                p.IdPessoa = Convert.ToInt32(txtIdPessoa.Text);
                p.Nome = txtNome.Text;
                p.Email = txtEmail.Text;
                p.Residencia.Logradouro = txtLogradouro.Text;
                p.Residencia.Cidade = txtCidade.Text;
                p.Residencia.Estado = txtEstado.Text;

                PessoaDal d = new PessoaDal();
                d.Atualizar(p);

                painel.Visible = true;
                lblMensagemOk.Text = "Cadastro atualizado com sucesso !";
            }
            catch
            {
                lblMensagemFail.Text = "Erro ao tentar atualizar p cadastro !";
            }

        }

        protected void ExcluirPessoa(object sender, EventArgs e)
        {
            try
            {
                int idPessoa = Convert.ToInt32(txtIdPessoa.Text);
                PessoaDal d = new PessoaDal();
                d.Excluir(idPessoa);

                painel.Visible = false;
                lblMensagem.Text = "Pessoa excluida com sucesso !";
            }
            catch
            {
                painel.Visible = true;
                lblMensagemFail.Text = "Erro ao tentar excluir pessoa !";
            }
        }
    }
}