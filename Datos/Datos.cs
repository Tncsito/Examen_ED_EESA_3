using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenED_EESA_3.Datos
{
    public class Datos
    { 
        /*###################### Ocupo terminar: ############################################################################################################
         
         * ¬Longitud (YA)
         * ¬Listar (YA)
         * ¬EstaVacio (YA)
         * ¬dar valores (nombre y edad) [CERCA]
         * ¬Insertar o Registrar (CERCA)
         * ¬Buscar persona (NI CERCA)

          ###################################################################################################################################################*/
        Persona persona;
        public void Registrar()
        {
            Console.WriteLine("Vamos a registrar a 5 personas");
            Console.WriteLine("Para empezar, dame un nombre de la persona a registrar en la lista enlazada ");
            Console.WriteLine("Luego me das la edad: ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Dame otro nombre: ");
                persona.nombre = Console.ReadLine();
                Console.WriteLine("La edad de la persona: ");
                persona.edad = int.Parse(Console.ReadLine());
            }
        }
        //Longitud de la lista
        public int Longitud()
        {
            int longitud = 0;
            for (int i = 0; persona != null; i++)
            {
                longitud = longitud + i;
            }
            return longitud;
        }
        //Radio de la longitud de la lista
        public int Radio()
        {
            int radio = Longitud() / 2;
            return radio;
        }
        //Metodo listar para mostrar a la persona
        public void Listar()
        {
            for(int i = 0; persona != null; i++)
            {
                Console.Write(persona.siguiente + " ");
            }
        }
        //Busqueda de una persona
        public void Buscar()
        {
            string buscar;
            Console.WriteLine("Dame el nombre de la persona a buscar: ");
            buscar = Console.ReadLine();
            for (int i = 0; persona != null; i++)
            {
                //if(persona.siguiente = buscar)
                //{

                //}
                
            }
        }
        //Dar valor vacio
        public bool EstaVacio()
        {
            persona.siguiente = null;
            return false;
        }
    }
}
