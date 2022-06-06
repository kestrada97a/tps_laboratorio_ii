using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private long dni;
        private string direccion;
        
        public Cliente(string nombre, string apellido, long dni, string direccion)
        {
            this.nombre = nombre;                  
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
        }

        public string Nombre
        { 
            get { return nombre; } 
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public long Dni
        {
            get { return dni; }
        }
        public string Direccion
        {
            get { return direccion; }
        }
    }
}
