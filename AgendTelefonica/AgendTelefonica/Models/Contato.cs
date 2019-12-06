using AgendTelefonica.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Regra do Negócio
namespace AgendTelefonica.Models
{
    public class Contato
    {

        private ContatoRepositorio repo;
        //Método construtor obrigátoriedade para os atributos e caso 
        //seja null deixar em string.Empty
        public Contato(int id,string nome, 
            string celular,
            string email,
            string comercial = null,
            string fixo = null,
            string apelido = null)
        {
            Id = id;
            Nome = nome;
            Celular = celular;
            Email = email;
            Comercial = comercial ?? string.Empty;
            Fixo = fixo ?? string.Empty;
            Apelido = apelido ?? string.Empty;

        }

        public Contato()
        {
            repo = new ContatoRepositorio();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Comercial { get; set; }
        public string Fixo { get; set; }
        public string Email { get; set; }
        public string Apelido { get; set; }
    
        //Método retornar todos contatos
        public List<Contato> RetornarTodos()
        {
            return repo.SelecionarTodos();
        }
        //Métpdo buscar Contato pelo Id
        public Contato BuscarContato(int id)
        {
              return repo.BuscarContato(id);
        }
         public void IncluirContato(Contato contato)
        {
            repo.IncluirContato(contato);
        }


        public void EditarContato(Contato contato)
        {
            repo.EditarContato(contato);
        }

        public void ExcluirContati(int Id)
        {
            repo.ExcluirContato(Id);
        }
    }

}
