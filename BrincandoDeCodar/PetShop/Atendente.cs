using System;


namespace PetShop
{
    class Atendente : Funcionario
    {
        public decimal ValorMensalVendido { get; set; }
        public int Meta { get => 2000; }
        public decimal PorcetagemComissao { get => 5; }
    }
}
