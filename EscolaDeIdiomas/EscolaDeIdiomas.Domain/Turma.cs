using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdiomas.Domain
{
    public class Turma
    {
        public int Id { get; set; }

        public string Periodo { get; set; }

        public string Idioma { get; set; }

        public int Sala { get; set; }

        public string Nivel { get; set; }

        public int Id_professor { get; set; }

        public DateTime Periodo_conclusao { get; set; }

        public Professor Professor { get; set; }

        public List<Aluno> Alunos { get; set; }

    }
}
