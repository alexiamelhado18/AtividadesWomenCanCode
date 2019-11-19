using System;


namespace PetShop
{
    public class AjudanteLimpeza : Funcionario
    {
        public bool PossuiUniforme  { get; set; }
        public string TamanhoUniforme { get; set; }
        public Turno Turno { get; set; }
    }

    public enum Turno
    {
        Manha,
        Tarde,
        Noite
    }

}
