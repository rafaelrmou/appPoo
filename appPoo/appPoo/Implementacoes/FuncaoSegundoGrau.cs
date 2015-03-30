using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPoo.Implementacoes
{
    public class FuncaoSegundoGrau : appPoo.Modelos.Funcao
    {
        public double incogA2 { get; set; }

        public FuncaoSegundoGrau()
            : this(0, 0, 0, 0)
        {
        }

        public FuncaoSegundoGrau(double a, double b, double c, double igualdade)
        {
            base.incogA = b;
            base.incogB = c;
            this.incogA2 = a;
            base.igualdade = igualdade;
        }

        public override string resolver()
        {
            try
            {

                if (incogA2 == 0)
                {
                 return  base.resolver();
                }
                //Δ = b² - 4ac
                double b2 = base.Multiplicacao(base.incogA, base.incogA);

                double menosQuatroAC = base.Multiplicacao(4, base.Multiplicacao(incogA2, this.incogA));

                double delta = base.Subtracao(b2, menosQuatroAC);

                double[] raizes = aplicarBhaskara(delta);

                return "Delta: " + delta + "\n1ª raíz: " + raizes[0].ToString() + "\n2ª raíz:" + raizes[1].ToString();
            }
            catch (Exception e)
            {

                return e.Message;
            }
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
                                    base.Divisao(base.incogA,
                                                            (base.Multiplicacao(2,
                                                                                 incogA2)))) };
            }
            else
            {
                bhaskara[0] = ((-base.incogA) + Math.Sqrt(delta)) / (2 * incogA2);
                bhaskara[1] = ((-base.incogA) - Math.Sqrt(delta)) / (2 * incogA2);
            }

            return bhaskara;
        }
    }
}
