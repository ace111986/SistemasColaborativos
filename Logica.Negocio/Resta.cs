﻿using System;

namespace Logica.Negocio
{
    public class Resta
    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado = 0.0;
            elResultado = operandoUno - operandoDos;
            return elResultado;

        }
    }
}