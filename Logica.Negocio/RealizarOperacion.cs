using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Negocio
{
    public class RealizarOperacion
    {
        double Calcular (double operandoUno, double operandoDos, string operador)
        {
            double elResultado= 0.0;
            
            //invoque al metodo correspondiente

            switch (operador)
            {
                case "+":
                    var laSuma = new Suma();
                    elResultado = laSuma.Operar(operandoUno, operandoDos);
                    break;

               case "-":
                    var laResta = new Resta();
                    elResultado = laResta.Operar(operandoUno, operandoDos);
                    break;

               case "*":
                    var LaMultiplicacion= new Multiplicacion();
                    elResultado = LaMultiplicacion.Operar(operandoUno, operandoDos);
                    break;

               case "/":
                    var LaDivision= new Division();
                    elResultado = LaDivision.Operar(operandoUno, operandoDos);
                    break;
            }

            return elResultado;
        }
    }
}
