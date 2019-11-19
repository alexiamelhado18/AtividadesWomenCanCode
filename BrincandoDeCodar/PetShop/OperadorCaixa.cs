using System;
using System.Collections.Generic;

namespace PetShop
{
    class OperadorCaixa : Funcionario
    {
        public decimal DiferenciaDescontarSalario { get; set; }

        public List<ControleCaixa> OperacoesCaixa { get; set; }

    }
}
