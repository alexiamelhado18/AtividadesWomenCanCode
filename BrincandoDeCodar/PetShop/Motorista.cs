using System;


namespace PetShop
{
    public class Motorista : Funcionario
    {
        public string CategoriaCNH { get; set; }
        public string PlacaVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string Renavan  { get; set; }
    }
        public enum TipoVeiculo
        {
            Carro,
            Moto,
            Caminhão
        }
}
