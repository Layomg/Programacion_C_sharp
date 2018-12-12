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

        public Persona()
        {

        }
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
            Persona persona_0 = new Persona();
            string nombre_1 = persona_0.ObtenerNombre();
            string apellido_1 = persona_0.ObtenerApellidos();
            int edad_1 = persona_0.ObtenerEdad();

            Persona persona_1 = new Persona(nombre_1, apellido_1, edad_1);

            Persona persona_2 = new Persona();
            persona_2.nombre = persona_0.ObtenerNombre();
            persona_2.apellidos = persona_0.ObtenerApellidos();
            persona_2.edad = persona_0.ObtenerEdad();


        }
    }

}
