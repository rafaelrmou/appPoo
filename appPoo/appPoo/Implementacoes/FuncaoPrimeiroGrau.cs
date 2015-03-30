using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPoo.Implementacoes
{
    public class FuncaoPrimeiroGrau : appPoo.Modelos.Funcao
    {
        public FuncaoPrimeiroGrau()
            : this(0, 0, 0)
        {
        }

        public FuncaoPrimeiroGrau(double a, double b, double igualdade)
        {
            base.incogA = a;
            base.incogB = b;
            base.igualdade = igualdade;
        }

    }
}
