
using Media.Repositorio;

namespace Media.Models
{
    public class Aluno 
    {
        private AlunoRepositorio repositorio;

        public Aluno(int ra, string nome, int idade, string turma,  Nota nota, Frequencia frequencia)
        {
            Ra = ra;
            Nome = nome;
            Idade = idade;
            Turma = turma;
            NotaAluno = nota;
            FrequenciaAluno = frequencia;

        }

        public Aluno()
        {
            repositorio = new AlunoRepositorio();
        }

        public int Ra{ get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Turma { get; set; }

        public Nota NotaAluno { get; set; }
        public Frequencia FrequenciaAluno { get; set; }


        }
    }

