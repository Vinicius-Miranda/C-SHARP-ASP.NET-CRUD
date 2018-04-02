using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Model
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public Endereco Residencia { get; set; }

    }
}
