using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
   public class Crush
    {
        public string Apelido { get; set; }

        public string Telefone { get; set; }

        public string Local { get; set; }

        public  EstadoCivil EstadoCivilCrush { get; set; }

        public int Avaliacao { get; set; }

        public List<Comportamento> Comportamentos { get; set; }

        private int PropriedadePrivada { get; set; }

        public string Aparencia (int nota)
        {
            switch (nota)
            {
                case 10:
                return "Olhos verdes, moreno, alto, bonito, sexy, engraçado e inteligente.";

                case 9:
                return "Olhos verdes, moreno, alto, bonito, sexy, engraçado e inteligente.";

                case 8:
                return "Moreno, alto, bonito, sexy, engraçado e inteligente.";

                case 5: 
                return "Moreno, alto, engraçado e inteligente.";

                case 3:
                return "Moreno";

                default:
                return "Nem quero conhecer";


            }
        }

        public void BeijosNoBoy(int nivelDeSaudade)
        {
            bool darBeijoNoBoy = false;

            for (int i = 0; i < nivelDeSaudade; i++)
            {
                darBeijoNoBoy = true;
            }
        }

        public string GanharPresentedoBoy(List<string> presentes)
        {
            string meusPresentes= "Eu vou ganhar ";

            //Serve pra qualquer lista dentro do .Net
            foreach (string presente in presentes)
            {

                meusPresentes += presente + ", ";

            }
            return meusPresentes;
        }

        public enum EstadoCivil
        {
            Solteiro,
            Casado,
            Noivo,
            Namorando,
            Divorciado,
            Viuva
        }

        public void teste()
        {
            PropriedadePrivada = 5;
        }

    }
}
