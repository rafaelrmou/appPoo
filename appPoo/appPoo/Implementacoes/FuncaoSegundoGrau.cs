using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPoo.Implementacoes
{
    public class FuncaoSegundoGrau : appPoo.Modelos.Funcao
    {
        public double incogC { get; set; }

        public FuncaoSegundoGrau()
            : this(0, 0, 0, 0)
        {
        }

        public FuncaoSegundoGrau(double a, double b, double c, double igualdade)
        {
            base.incogA = a;
            base.incogB = b;
            this.incogC = c;
            base.igualdade = igualdade;
        }

        public override string resolver()
        {
            base.resolver();
            //Δ = b² - 4ac
            double b2 = base.Multiplicacao(base.incogB, base.incogB);

            double menosQuatroAC = base.Multiplicacao(4, base.Multiplicacao(base.incogA, this.incogC));

            double delta = base.Subtracao(b2, menosQuatroAC);

            double[] raizes = aplicarBhaskara(delta);

            return "1º: " + raizes[0].ToString() + " 2º:" + raizes[1].ToString();
        }

        public double[] aplicarBhaskara(double delta)
        {
            double[] bhaskara = new double[2];
            if (delta < 0)
            {
                throw new Exception("Delta não pode ser menor que 0!");
            }
            else if (delta == 0)
            {
                bhaskara = new double[] {
                    base.Subtracao(0,
                                    base.Divisao(base.incogB,
                                                            (base.Multiplicacao(2,
                                                                                 base.incogA)))) };
            }
            else
            {
                bhaskara[0] = ((-base.incogB) + Math.Sqrt(delta)) / (2 * base.incogA);
                bhaskara[1] = ((-base.incogB) - Math.Sqrt(delta)) / (2 * base.incogA);
            }

            return bhaskara;
        }
    }
}
