using System;


namespace PetShop
{
    class Funcionario : Pessoa
    {
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public decimal Salario { get; set; }
        public string Cracha { get; set; }
        public string ContaCorrente { get; set; }
        public string Agencia { get; set; }
        public int DiaPagamento { get; set; }
        public string Banco { get; set; }
        



        public string EfetuarPagamento()
        {
            if(DiaPagamento == DateTime.Today.Day)
            {
                return $"O valor {Salario} foi depositado" +
                    $"no banco {Banco}, agencia {Agencia}," +
                    $"conta corrente {ContaCorrente}";
            }
            return $"Sinto muito mas o dia do pagamento é" +
                $"{DiaPagamento}";
        } 

        public void AdmitirFuncionario(decimal salario,
        string codigoCracha,
        string banco,
        string contaCorrente,
        string agencia)
        {
           
           
            DataEntrada = DateTime.Today;
            Salario = salario;
            Cracha = codigoCracha;
            Banco = banco;
            ContaCorrente = contaCorrente;
            Agencia = agencia;
            DiaPagamento = 10;

   
            {
                AdmitirFuncionario(salario, codigoCracha, banco, , agencia);
            }





        }

   
    }
}
