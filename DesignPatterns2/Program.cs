using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using DesignPatterns2.SingletonFacade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cap2
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //};

            //Piano piano = new Piano();

            //piano.Toca(musica);


            //Cap3 (Memento)
            //Historico historico = new Historico();

            //Contrato contrato = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);

            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //Console.WriteLine(contrato.Tipo);
            //Console.ReadKey();

            //Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            //Cap4
            //IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(200)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));

            //IExpressao soma = new Soma(esquerda, direita);

            //Console.WriteLine(soma.Avalia());

            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();

            //Console.WriteLine(funcao());

            //Cap5
            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);

            //Cap6
            //IMensagem mensagem = new MensagemAdministrativa("Victor");
            //IEnviador enviador = new EnviaPorEmail();
            //mensagem.Enviador = enviador;
            //mensagem.Envia();

            //Cap7
            //FilaDeTrabalho fila = new FilaDeTrabalho();
            //Pedido pedido = new Pedido("Maurício", 100.0);
            //Pedido pedido2 = new Pedido("Marcelo", 200.0);

            //fila.Adiciona(new PagaPedido(pedido));
            //fila.Adiciona(new PagaPedido(pedido2));
            //fila.Adiciona(new FinalizaPedido(pedido));
            //fila.Adiciona(new FinalizaPedido(pedido2));

            //fila.Processa();

            //Cap8
            //Cliente cliente = new Cliente();
            //cliente.Nome = "Victor";
            //cliente.Endereco = "Rua Vergueiro";
            //cliente.DataNascimento = DateTime.Now;

            //string xml = new GeradorDeXML().GeraXML(cliente);

            //Console.WriteLine(xml);

            //Cap9
            //string cpf = "1234";
            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente(cpf);

            //var fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(Tipo.Boleto, fatura);
        }
    }
}