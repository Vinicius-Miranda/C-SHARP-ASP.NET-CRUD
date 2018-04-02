using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        public void AbrirConexao()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
            Con.Open();
        }

        public void FecharConexao()
        {
            Con.Close();
        }
    }
}
