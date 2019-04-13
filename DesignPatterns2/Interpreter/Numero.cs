using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap4
{
    class Numero : IExpressao
    {
        public int Valor { get; private set; }
        public Numero(int numero) => Valor = numero;

        public int Avalia() => Valor;

        public void Aceita(IVisitor impressora) =>
           impressora.ImprimeNumero(this);
    }
}