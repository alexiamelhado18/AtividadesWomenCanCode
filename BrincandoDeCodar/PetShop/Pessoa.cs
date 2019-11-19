using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop
{
   public abstract class Pessoa
    {
        public Pessoa()
        {
            //Consultor dentro da classe 
            //para Ler uma vez e não instanciar no Program toda vez que criar objeto
            MeuEndereco = new Endereco();
        }


        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco MeuEndereco { get; set; }


        private int _idade;

        public int idade
        {
            get {

                _idade = DateTime.Today.Year - DataDeNascimento.Year;
                return DataDeNascimento.AddYears(_idade) > DateTime.Today ?
                    _idade-- : _idade;
            }
          
        }

      




    }
}
