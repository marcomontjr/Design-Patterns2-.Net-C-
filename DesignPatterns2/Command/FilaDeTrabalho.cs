using System.Collections.Generic;

namespace DesignPatterns2.Cap7
{
    class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando) => Comandos.Add(comando);

        public void Processa()
        {
            foreach (var comando in Comandos)            
                comando.Executa();            
        }
    }
}