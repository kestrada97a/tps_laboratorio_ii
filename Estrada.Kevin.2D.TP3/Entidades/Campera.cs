using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campera : Ropa
    {
        private string tela;
        private bool conCapucha;


        public Campera(string tela, bool conCapucha, int talle, string color):base(talle,color)
        { 
            this.tela = tela;
            this.conCapucha = conCapucha;
        }

        public string Tela
        {
            get { return tela; }
        }

        public bool ConCapucha
        {
            get { return conCapucha; }
        }

    }
}
