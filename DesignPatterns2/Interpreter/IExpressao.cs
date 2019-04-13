using DesignPatterns2.Visitor;

namespace DesignPatterns2.Cap4
{
    interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}