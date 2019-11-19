using System;


namespace PetShop
{
    class Estagiario : Funcionario
    {
        public string Curso  { get; set; }
        public TipoCurso TipoCurso { get; set; }
        public string TempoDeCurso { get; set; }
        public string TempoRestante { get; set; }
        public string AreaAtuacao { get; set; }
    }
    public enum TipoCurso
    {
        EnsinoFundamental,
        EnsinoMedio,
        Graduacao,
        PosGraduacao
    }
}
