using System.Collections.Generic;

namespace DesignPatterns2.Cap3
{
    class Historico
    {
        private IList<EstadoContrato> Estados = new List<EstadoContrato>();
        public void Adiciona(EstadoContrato estado) => Estados.Add(estado);        

        public EstadoContrato Pega(int indice) => Estados[indice];
    }
}