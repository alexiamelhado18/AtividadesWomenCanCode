using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
   public class Veterinario : Funcionario
    {
        public Veterinario()
        {
            Especialidade = new List<string>();
            DiasDeAtendimento = new List<DateTime>();

        }

        public string CRMV { get; set; }
        public List<string> Especialidade { get; set; }
        public List<DateTime> DiasDeAtendimento { get; set; }

        public void Incluir(string crmv, List<string> especialidade,
         List<DateTime> diasDeAtendimento,
         decimal salario,
         string codigoCracha,
         string banco,
        string contaCorrente,
        string agencia)
        {
            AdmitirFuncionario(salario, codigoCracha, banco, contaCorrente, agencia);


            CRMV = crmv;
            Especialidade = especialidade;
            DiasDeAtendimento = diasDeAtendimento;
        }
    }
}


