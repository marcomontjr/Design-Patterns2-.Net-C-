namespace DesignPatterns2.Cap7
{
    class FinalizaPedido : IComando
    {
        private Pedido Pedido;

        public FinalizaPedido(Pedido pedido) => Pedido = pedido;

        public void Executa()
        {
            Pedido.Entregue();
            System.Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);
        }
    }
}