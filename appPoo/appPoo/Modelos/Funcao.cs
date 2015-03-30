using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPoo.Modelos
{
    public class Funcao : appPoo.Interfaces.IFuncao
    {
        public double incogA { get; set; }

        public double incogB { get; set; }

        public double igualdade { get; set; }


        public double Soma(double a, double b)
        {
            return a + b;
        }

        public double Subtracao(double a, double b)
        {
            return a - b;
        }

        public double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        public double Divisao(double a, double b)
        {
            if (b == 0)
                throw new Exception("O divisor deve ser diferente de zero!");

            return a / b;
        }

        public virtual string resolver()
        {
            try
            {


                //Primeira subtraimos o valor da incogB do valor da igualdade e depois fazemos a divisão entre o
                //resultado dessa subtração e incogA
                double resultado = Divisao(Subtracao(igualdade, incogB), incogA);

                return resultado.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
