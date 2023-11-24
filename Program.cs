namespace ExamenED_EESA_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Datos.Datos datos = new Datos.Datos();

            /*
             * EJERCICIO:
                Se pide desarrollar un programa de consola con el lenguaje C# que implemente una lista enlazada que contenga objetos de la clase Persona. La clase Persona debe tener las siguientes propiedades:

                nombre: una cadena de texto que representa el nombre de la persona.

                edad: un número entero que representa la edad de la persona.

                El programa debe realizar las siguientes tareas:

                Crear una lista vacía.

                Insertar al final de la lista cinco personas, ejemplos:

                nombre: "Juan", "María" y "Pedro".

                edad: 25, 35 y 10, respectivamente.

                Buscar en la lista la persona con el nombre "Juan" y que devuelva un mensaje donde se diga la posicion en la que se encuentra o mensaje de que no se encuentra en caso contrario .

                Imprimir todos los elementos de la lista ordenados ascendente por la edad.
             
             */

            /*
             ¿QUÉ HICE?
                Me faltaron las cosas principales, pero 
                las funcionalidades que ocupa las hice
             */
            datos.Registrar();
            
            datos.Listar();
        }
    }
}