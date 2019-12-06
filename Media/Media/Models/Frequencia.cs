namespace Media.Models
{
    public class Frequencia
    {
        public Frequencia(int qtdfaltas, int qtdpresenca)
        {
            QtdFaltas = qtdfaltas;
            QtdPresenca = qtdpresenca;

        }
        public int QtdFaltas { get; set; }
        public int QtdPresenca { get; set; }
        public int Desistencia { get; set; }


        public string VerificarNullFrequencia(Frequencia frequencia)
        {

            var frequenciaDeFalta = QtdFaltas;
            var frequenciaDePresenca = QtdPresenca;
            _ = Desistencia;

            if (frequenciaDeFalta == frequenciaDePresenca == null)
            {
                return ("Pendente");
            }
            else
            {
                return ("Ainda não foi computada sua frequência");
            }
           

        }


              public string VerificarFrequencia(Frequencia frequencia)
                {
                    var faltasObtidas = QtdFaltas;
                    var presencaObtidas = QtdPresenca;

                    if (faltasObtidas < 75)
                    {
                        return ("Reprovado");
                    }
                    else if (faltasObtidas >= 75)
                    {
                        return ("Reprovado");
                    }
                    else if (presencaObtidas > 75)
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
        
    
