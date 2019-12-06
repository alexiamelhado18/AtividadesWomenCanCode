using Floricultura.Models;
using System.Collections.Generic;
using System.Linq;

namespace Floricultura.Repositorio
{
    public class FlorRepositorio
    {
        
        private List<Flor> _flores = new List<Flor>();
        
        //Método contrutor garante que o objeto ser executado
        //Adicionando flor na lista
        public FlorRepositorio(List<Flor> floresGuardadas)
        {
            _flores = floresGuardadas;
        }
        //Adicionando o método do objeto flor
        public void Adicionar(Flor flor)
        {
            _flores.Add(flor);
        }

        public List<Flor> Listar()
        {
            return _flores;
        }

        public Flor Obter(string id)
        {
            //Quando digitar o Where, você vai precisar dar ctrl+.
            //para adicionar o using System.Linq
            var flor = _flores.Where(x => x.Id.ToString() == id).FirstOrDefault();
            return flor;
        }
    }
}
