using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap7
{
    class Pedido
    {
        public string Cliente { get; private set; }
        public double ValorPedido { get; private set; }
        public DateTime DataFinalizacao { get; private set; }
        public Status Status { get; private set; }

        public Pedido(string cliente, double valor)
        {
            Cliente = cliente;
            ValorPedido = valor;
            Status = Status.Novo;
        }

        public void Paga() => Status = Status.Pago;
        public void Entregue()
        {
            Status = Status.Entregue;
            DataFinalizacao = DateTime.Now;
        } 
        
    }
}
