using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pantalon : Ropa
    {
        private string tela;
        private bool isChupin;

        public Pantalon(string tela, bool isChupin, int talle, string color):base(talle,color)
        {
            this.tela = tela;
            this.isChupin = isChupin;
        }
    }
}
