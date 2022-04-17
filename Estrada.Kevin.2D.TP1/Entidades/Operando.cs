using System;

namespace Entidades
{
    public class Operando
    {

        private double numero;
        public Operando()
        {
            numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string numero)
        {
            double.TryParse(numero, out this.numero);
        }

        public double ValidarOperando(string strNumero)
        {
            bool isNumeric = double.TryParse(strNumero, out double numero);
            if (isNumeric == true)
            {
                return numero;
            }
            else
            { return 0; }
        }

        public string Numero
        {
            set
            {
                double auxiliarValue = ValidarOperando(value);
                numero = auxiliarValue;
            }
        }

        private static bool EsBinario(string binario)
        {

            for (int i = 0; i < binario.Length; i++)
            {
                if (!(binario.Substring(i).Contains('0') || (binario.Substring(i).Contains('1'))))
                {
                    return false;
                }
            }
            return true;
        }

        public static string BinarioDecimal(string binario)
        {
            bool controlBinario = EsBinario(binario);
            if (controlBinario)
            {
                int num = 0;
                int auxiliarNum;
                int divisor = 10;
                int.TryParse(binario, out int numeroBinario);
                for (int i = numeroBinario, j = 0; i > 0; i /= divisor, j++)
                {
                    auxiliarNum = i % divisor;
                    if (auxiliarNum != 1 && auxiliarNum != 0)
                    {
                        return "Valor invalido";
                    }
                    num += auxiliarNum * (int)Math.Pow(2, j);
                }
                return num.ToString();
            }
            return "Valor invalido";
        }

        public static string DecimalBinario(double numeroEntero)
        {
            string binario = "";
            int auxiliar = Math.Abs((int)numeroEntero);

            if (auxiliar > 0)
            {
                while (auxiliar > 0)
                {
                    binario = auxiliar % 2 + binario;

                    auxiliar = auxiliar / 2;
                }

                return binario;
            }
            return "Valor invalido";
        }

        public static string DecimalBinario(string numeroEntero)
        {
            double.TryParse(numeroEntero, out double auxiliar);
            return DecimalBinario(auxiliar);

        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;

            }
            return n1.numero / n2.numero;


        }

    }

}
