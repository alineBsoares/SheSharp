using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdiomas.Domain
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Cpf { get; set; }     

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        public Turma Turma  { get; set; }

        public int Id_turma { get; set; }

  
    }
}
