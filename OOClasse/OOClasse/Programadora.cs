using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
    class Programadora : Pessoa
    {
        //Método consultor com obrigatoriedade de parametros dos atributos de Programadora
        public Programadora( int anosDeCarreira, bool possuiGraduacao)
        {
            Linguagens = new List<string>();

            PossuiGraduacao = possuiGraduacao;
            AnosDeCarreira = anosDeCarreira;
            NomeDaMae = "nomeDaMae";
                }


        public List<string> Linguagens { get; set; }

        public int AnosDeCarreira { get; set; }

        public bool PossuiGraduacao { get; set; }

        public string TrabalhaNaArea { get; set; }

        public decimal Salario { get; set; }
    }
}
