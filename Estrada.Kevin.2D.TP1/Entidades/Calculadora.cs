using System;

namespace Entidades
{
    public static class Calculadora
    {
     /// <summary>
     /// Valida si el operador es un "+ / - *"
     /// </summary>
     /// <param name="operador"></param>
     /// <returns retorna el valor validado></returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '-')
            {
                return '-';
            }
            else if (operador == '/')
            {
                return '/';
            }
            else if (operador == '*')
            {
                return '*';
            }
            else
            {
                return '+';
            }
        }

        /// <summary>
        /// Valida el operador y realiza la operacion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns> resultado de la operacion </returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char auxiliar = ValidarOperador(operador);
            if(auxiliar == '-')
            {
                return num1 - num2;
            }
            if(auxiliar == '*')
            {
                return num1 * num2;
            }
            if(auxiliar == '/')
            {
                return num1 / num2;
            }
            else
            {
                return num1 + num2;
            }
        }

    }

    

}
