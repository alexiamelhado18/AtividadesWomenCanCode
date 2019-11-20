

using System.Collections.Generic;

namespace EscolaDePrograma.Models
{
    public class Aluno : Pessoa
    {

        public List<Turma> Turmas { get; set; }
        public decimal Mensalidade { get; set; }
        public List<Notas> MinhasNotas { get; set; }
    }
}
