using DesignPatterns2.Cap4;
using DesignPatterns2.Visitor;
using System;

namespace DesignPatterns2.Cap5
{
    class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("+");
            Console.Write("(");
            //esquerda
            soma.Esquerda.Aceita(this);
            //direita
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("-");
            Console.Write("(");
            //esquerda
            subtracao.Esquerda.Aceita(this);
            //direita
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero) =>        
            Console.Write(numero.Valor);
    }
}