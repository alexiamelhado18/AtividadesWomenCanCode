using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDePrograma.Models
{
    public class Turma
    {
        public string Codigo { get; set; }
        public Turno TurnoDeAula { get; set; }
        public Materia MinhaMateria { get; set; }
        public List<Materia> MinhasMateris { get; set; }
        public Professor ProfessorDaTurma { get; set; }
        public List<Aluno> TodosOsAlunos { get; set; }
    }
}
