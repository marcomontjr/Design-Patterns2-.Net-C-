using System;

namespace DesignPatterns2.Cap4
{
    class Divisao : IExpressao
    {
        IExpressao Esquerda;
        IExpressao Direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia() != 0 ? 
                               Direita.Avalia() : 
                               throw new DivideByZeroException(nameof(valorDireita));

            return valorEsquerda / valorDireita;
        }
    }
}