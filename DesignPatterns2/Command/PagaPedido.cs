namespace DesignPatterns2.Cap7
{
    class PagaPedido : IComando
    {
        public Pedido Pedido;
        public PagaPedido(Pedido pedido) => Pedido = pedido;

        public void Executa()
        {
            Pedido.Paga();
            System.Console.WriteLine("Pagando o pedido do cliente {0}", Pedido.Cliente);
        }
    }
}