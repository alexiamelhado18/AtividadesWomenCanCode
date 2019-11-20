using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaDePrograma.Models
{
   public class Notas
    {
        public string CodigoTurma { get; set; }
        public decimal Nota1 { get; set; }
        public decimal Nota2 { get; set; }
        public decimal Nota3 { get; set; }

        public bool Aprovado
        {
            get {
                decimal somaNoatas = Nota1 + Nota2 + Nota3;
                return somaNoatas == 0 ? false : somaNoatas / 3 >= 6;
            }
        }
    }
}
