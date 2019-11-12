using System;
using System.Collections.Generic;
using Crushs;

namespace OOClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Crush crush = new Crush();

            // Instaciando classe cSharp que herda de pessoa
            Programadora cSharp = new Programadora(2, true);

            
            cSharp.PossuiGraduacao = true;
            cSharp.Salario = 4000;

            //Instanciando a classe List(tipagem lista) 
            cSharp.Linguagens = new List<string>();
            cSharp.Linguagens.Add("C#");
            cSharp.Linguagens.Add("Phyton");
            cSharp.Linguagens.Add("Java");

            

            cSharp.Nome = "Alexia";
            cSharp.Idade = 18;
            //cSharp.NomeDaMae = "Sonia";

            //Instaciando Meuendereco
            cSharp.MeuEndereco = new Endereco();
            cSharp.MeuEndereco.Cidade = "São Paulo";
            cSharp.MeuEndereco.Bairro = "Jardim São João";
            cSharp.MeuEndereco.Estado = "São Paulo";
            cSharp.MeuEndereco.Numero = "321";


            Console.WriteLine($"Olá {cSharp.Nome}, você mora no Bairro " +
                $"{cSharp.MeuEndereco.Bairro}," +
                $" e tem {cSharp.Idade} anos. ");
                
           

        }
    }
}
