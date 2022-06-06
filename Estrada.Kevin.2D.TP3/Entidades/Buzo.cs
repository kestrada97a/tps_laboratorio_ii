using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Buzo : Ropa
    {
        private string tela;
        private bool isMangaLarga;

        public Buzo(string tela, bool isMangaLarga, int talle, string color) : base (talle,color)
        {
            this.tela = tela;
            this.isMangaLarga = isMangaLarga;
        }

        public string Tela
        {
            get { return tela; }
        }

        public bool IsMangaLarga
        {
            get { return isMangaLarga; }
        }
    }
}
