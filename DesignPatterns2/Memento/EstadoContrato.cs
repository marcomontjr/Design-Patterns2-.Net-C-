﻿namespace DesignPatterns2.Cap3
{
    class EstadoContrato
    {
        public Contrato Contrato { get; private set; }
        public EstadoContrato(Contrato contrato) => Contrato = contrato;        
    }
}