using System;

namespace DesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        IExpressao Numero;

        public RaizQuadrada(IExpressao numero) => Numero = numero;
        
        public int Avalia()
        {
            int valorNumero = Numero.Avalia();
            return (int)Math.Sqrt(valorNumero);
        }
    }
}