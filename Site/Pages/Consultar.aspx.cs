using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Persistence;
using DAL.Model;

namespace Site.Pages
{
    public partial class Consultar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaDal d = new PessoaDal();

                gridPessoas.DataSource = d.ListarTodas();
                gridPessoas.DataBind();
            }
            catch
            {
                lblMensagem.Text = "Erro ao consultar pessoa";
            }
        }
    }
}