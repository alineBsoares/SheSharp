using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdiomas.Domain
{
    public class Professor
    {
        public int Id { get; set; }

        public List<Turma> Turmas { get; set; }

        public string Cpf { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
