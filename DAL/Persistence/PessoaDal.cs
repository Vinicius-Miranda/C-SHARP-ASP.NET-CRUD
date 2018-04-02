using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Persistence
{
    public class PessoaDal : Conexao
    {
        public void Salvar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("dbo.CadPessoa", Con);
                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@Nome", p.Nome);
                Cmd.Parameters.AddWithValue("@Email", p.Email);
                Cmd.Parameters.AddWithValue("@Logradouro", p.Residencia.Logradouro);
                Cmd.Parameters.AddWithValue("@Cidade", p.Residencia.Cidade);
                Cmd.Parameters.AddWithValue("@Estado", p.Residencia.Estado);
                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> ListarTodas()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa p " +
                            "inner join Endereco e on p.IdPessoa = e.IdPessoaFK", Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Residencia = new Endereco();

                    p.IdPessoa = Convert.ToInt32(Dr["IdPessoa"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                    p.DataHoraCadastro = Convert.ToDateTime(Dr["DataHoraCadastro"]);
                    p.Residencia.Logradouro = Convert.ToString(Dr["Logradouro"]);
                    p.Residencia.Cidade = Convert.ToString(Dr["Cidade"]);
                    p.Residencia.Estado = Convert.ToString(Dr["Estado"]);

                    lista.Add(p);
                }
                return lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(int idPessoa)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("dbo.ExcluirPessoa", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Id", idPessoa);
                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Atualizar(Pessoa p)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("dbo.AtualizarPessoa", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@Id", p.IdPessoa);
                Cmd.Parameters.AddWithValue("@Nome", p.Nome);
                Cmd.Parameters.AddWithValue("@Email", p.Email);
                Cmd.Parameters.AddWithValue("@Logradouro", p.Residencia.Logradouro);
                Cmd.Parameters.AddWithValue("@Cidade", p.Residencia.Cidade);
                Cmd.Parameters.AddWithValue("@Estado", p.Residencia.Estado);
                Cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa BuscarPorId(int idPessoa)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Pessoa p " +
                            "inner join Endereco e on p.IdPessoa = e.IdPessoaFK " +
                            "where p.IdPessoa = @v1", Con);
                Cmd.Parameters.AddWithValue("@v1", idPessoa);
                Dr = Cmd.ExecuteReader();

                Pessoa p = null;

                if (Dr.Read())
                {
                    p = new Pessoa();
                    p.Residencia = new Endereco();

                    p.IdPessoa = Convert.ToInt32(Dr["IdPessoa"]);
                    p.Nome = Convert.ToString(Dr["Nome"]);
                    p.Email = Convert.ToString(Dr["Email"]);
                    p.DataHoraCadastro = Convert.ToDateTime(Dr["DataHoraCadastro"]);
                    p.Residencia.Logradouro = Convert.ToString(Dr["Logradouro"]);
                    p.Residencia.Cidade = Convert.ToString(Dr["Cidade"]);
                    p.Residencia.Estado = Convert.ToString(Dr["Estado"]);
                }

                return p;
            }
            catch
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
