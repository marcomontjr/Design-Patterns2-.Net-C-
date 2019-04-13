namespace DesignPatterns2.Cap6
{
    class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome) =>
            this.nome = nome;

        public void Envia() => Enviador.Envia(this);        

        public string Formata() =>     
            string.Format("Enviando a Mensagem para o adm {0}", nome);        
    }
}