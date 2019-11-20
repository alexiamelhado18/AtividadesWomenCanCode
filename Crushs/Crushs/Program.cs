using System;
using System.Collections.Generic;

namespace Crushs
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //Instnciando Classe Crush
            Crush marido = new Crush();
           
            //Criando Objeto Marido
            marido.Apelido = "Junin";
            marido.Avaliacao = 8;
            marido.BeijosNoBoy(10);

            //Instanciando Lista presenteDoBoy
            List<string> presentesDoBoy = new List<string>();
            presentesDoBoy.Add("Chocolate");
            presentesDoBoy.Add("Relogio");
            presentesDoBoy.Add("Jantar.");

            //Mostra lista de presenteDoBoy
            Console.WriteLine(marido.GanharPresentedoBoy(presentesDoBoy));

            //Instanciando Classe Crush chamando tipagem List comportamentos
            marido.Comportamentos = new List<Comportamento>();

            //Criando objeto compEngracado
            Comportamento compEngracado = new Comportamento();

            compEngracado.Descricao = "Engrçado";
            compEngracado.Intensidade = 10;

            compEngracado.IncluirIntensidade(10);

            marido.Comportamentos.Add(compEngracado);

            Comportamento compRomantico = new Comportamento();

            compRomantico.Descricao = "Engrçado";
            compRomantico.Intensidade = 10;

            compRomantico.DiminuirIntensidade(5);

            marido.Comportamentos.Add(compRomantico);
            marido.Comportamentos.Add(compEngracado);



            
        }
    }
}
