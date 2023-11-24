using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenED_EESA_3.Datos
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string valor { get; set; }
        public Persona siguiente { get; set; }
        public Persona(string valor, Persona siguiente, string nombre, int edad)
        {
            this.valor = valor;
            this.siguiente = siguiente;
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
