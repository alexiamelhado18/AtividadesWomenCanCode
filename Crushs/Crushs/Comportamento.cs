using System;
using System.Collections.Generic;
using System.Text;

namespace Crushs
{
    public class Comportamento
    {
        private int myVar;

        public int MyProperty
        {
            //Exibe valor de myVar
            get { return myVar; }

            //Escrita
            set {

                if (value >5)
                {
                    myVar = 3;
                }
                else if(value == 3)
                {
                    myVar = 8;
                }
                else
                {
                    myVar = value;
                }

                myVar = value; 
            }
        }


        public string Descricao { get; set; }

        public int Intensidade { get; set; }

        //Parametro é informação ue vem de fora
        //Método é pra aumentar a intensidade
        public void IncluirIntensidade(int intensidade)
        {

            Intensidade += intensidade;
        }

        //Método é pra Diminuir a intensidade
        public void DiminuirIntensidade(int intensidade)
        {

            Intensidade -= intensidade;
        }
    }
}
