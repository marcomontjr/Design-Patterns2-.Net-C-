﻿using System;

namespace DesignPatterns2.Cap6
{
    class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por E-mail");
            Console.WriteLine(mensagem.Formata());
        }
    }
}