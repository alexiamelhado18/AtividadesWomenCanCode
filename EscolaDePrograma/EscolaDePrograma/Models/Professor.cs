
using System.Collections.Generic;

namespace EscolaDePrograma.Models
{
    public class Professor : Pessoa
    {
        public Graducao MinhaGraducao { get; set; }
        public List<Materia> TipoAulas { get; set; }
        public decimal Salario { get; set; }
        public List<Turno> TurnosDisponiveis { get; set; }
    }
    
}
