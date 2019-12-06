

namespace Media.Models
{
    public class Nota
    {


        public Nota(int nota1, int nota2, int nota3, int nota4)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3; 
            Nota4 = nota4;
        }

        public int Nota1 { get; set; } 
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }

        public string VerificarNull(Nota nota)
        {
            var notas = (nota.Nota1 + nota.Nota2 + nota.Nota3 + nota.Nota4);
            if (notas == null)
            {
                return ("Pendente");
            }
            else
            {
                return ("Nota não cadastrada");
          
   }
        }
       public string ValorMedia(Nota nota)
        {


            var media = (nota.Nota1 + nota.Nota2 + nota.Nota3 + nota.Nota4)/4;

            if (media > 7)
            {
                return ("Aprovado");
            }
            else
            {
                return ("Reprovado");

            }
           
        }
    }
}
