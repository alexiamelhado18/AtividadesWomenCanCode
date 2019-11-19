
using PetShop;
namespace BrincandoDeCodar
{
   class Program
    {
        static void Main(string[] args)
        {


            Veterinario drPet = new Veterinario();

            DadosPessoais();
            DadosParaPagamento();







        }
        private static void DadosPessoais()
        {
            System.Console.WriteLine("Informe o nome do Veterinario");
            string nome = System.Console.ReadLine();

            System.Console.WriteLine("Informe o CRWM do Veterinario");
            string crwm = System.Console.ReadLine();

            System.Console.WriteLine("Informe o Cracha do Veterinario");
            string cracha = System.Console.ReadLine();
        }
        private static void DadosParaPagamento()
        {

            System.Console.WriteLine("Informe o Salário do Veterinario");
            string salario = System.Console.ReadLine();

            System.Console.WriteLine("Informe o Banco do Veterinario");
            string banco = System.Console.ReadLine();

            System.Console.WriteLine("Informe o Agencia do Veterinario");
            string agencia = System.Console.ReadLine();

            System.Console.WriteLine("Informe o Conta do Veterinario");
            string cc = System.Console.ReadLine();

        }

       

    }
}
