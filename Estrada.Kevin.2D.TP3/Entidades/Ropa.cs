using System;
using System.Text;

namespace Entidades
{
    public abstract class Ropa
    {
        protected int talle;
        protected string color;
        protected bool paraHombre;
        protected Ropa(int talle, string color)
        {
            this.talle = talle; 
            this.color = color;
        }

        public int Talle
        {
            get { return talle; }
            set { talle = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Motrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Talle: {talle}");
            sb.AppendLine($"Color: {color}");

            return sb.ToString();
        }

    }
}
