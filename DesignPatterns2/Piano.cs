using DesignPatterns2.Cap2;
using System;
using System.Collections.Generic;

namespace DesignPatterns2
{
    class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (var nota in musica)            
                Console.Beep(nota.Frequencia, 300);            
        }
    }
}