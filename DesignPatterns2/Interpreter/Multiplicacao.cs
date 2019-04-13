namespace DesignPatterns2.Cap4
{
    class Multiplicacao : IExpressao
    {
        IExpressao Esquerda;
        IExpressao Direita;
        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();

            return valorEsquerda * valorDireita;
        }
    }
}