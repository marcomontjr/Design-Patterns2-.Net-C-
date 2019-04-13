﻿namespace DesignPatterns2.Cap6
{
    class MensagemCliente : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome) =>        
            this.nome = nome;

        public void Envia() => Enviador.Envia(this);

        public string Formata() =>
            string.Format("Enviando a Mensagem para o cliente {0}", nome);
    }
}