using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedidos<T>
    {
        private List<T> ropaPedidos;
        private Cliente cliente;

        public Pedidos()
        {
            ropaPedidos = new List<T>();
        }
        public Pedidos(Cliente cliente):this()
        { 
            this.cliente = cliente;
        }

        public Cliente Cliente
        {
            get { return cliente; }
        }
    }
}
