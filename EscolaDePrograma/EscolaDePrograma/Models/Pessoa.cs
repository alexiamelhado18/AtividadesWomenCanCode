using System;


namespace EscolaDePrograma.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public Endereco MeuEndereco { get; set; }
    }
}
