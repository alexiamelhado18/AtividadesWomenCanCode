using AgendTelefonica.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgendTelefonica.Repositorio
{
    public class ContatoRepositorio
    {
        //Tabela 
        private List<Contato> Contatos;
        private void CriarDados()
        {
            Contatos = new List<Contato>();

            Contatos.Add(new Contato(1,"Thamirys",
                "11 9988-6655",
                "thamirys@developers-sp.com.br"
                ));

            Contatos.Add(new Contato(2,"Aléxia",
                "11 96655005",
                "aleeevitoria@gmail.com",
                apelido: "Irmão da Aléxia(solteiro,27 anos)"));

            Contatos.Add(new Contato(3,"Thalita",
                "11 95155-4122",
                "thalita@gmail.com",
                apelido: "Cunhada da alexia"));
        }

        public ContatoRepositorio()
        {
            CriarDados();

        }

        public List<Contato> SelecionarTodos()
        {
            return Contatos.OrderBy(t => t.Nome).ToList();
        }

        public Contato BuscarContato(int id)
        {

           return  Contatos.FirstOrDefault(t => t.Id == id);
        }


        public void IncluirContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public void EditarContato(Contato contato)
        {
            //Busca pelo Id
            var meuContato = BuscarContato(contato.Id);

            // Vê no contatos caso teha o ID e Retorna sua posição 
            int indice = Contatos.IndexOf(meuContato);
            //Retorna na lista o Id o contato
            Contatos[indice] = contato;
        }

        public void ExcluirContato(int Id)
        {

            Contatos.Remove(BuscarContato(Id));
        }
    }
}
