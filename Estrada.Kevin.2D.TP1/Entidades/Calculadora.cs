using System;

namespace Entidades
{
    public static class Calculadora
    {
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
