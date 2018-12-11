using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Persona
    {

        string nombre, apellidos;
        int edad;

        
        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        string ObtenerNombre()
        {
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            return nombre;
        }

        string ObtenerApellidos()
        {
            Console.Write("Ingrese los apellidos: ");
            string apellidos = Console.ReadLine();
            return apellidos;
        }

        int ObtenerEdad()
        {
            Console.Write("Ingrese una edad: ");
            int edad = Console.Read();
            return edad;
        }

        static void Main(string[] args)
        {

        }
    }

}
