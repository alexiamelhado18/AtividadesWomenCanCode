using System;
using System.Collections.Generic;
using System.Text;

namespace OOClasse
{
    class Pessoa
    {

        public string Nome {get; set;}

        public int Idade { get; set;}

        protected string NomeDaMae {get; set;}

        //O MeuEndereco terá as propriedades Endereco
        public Endereco MeuEndereco { get; set; }


    }
}
