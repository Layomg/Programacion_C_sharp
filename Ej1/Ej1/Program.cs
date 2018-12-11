using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Bicicleta
    {
        double velocidadActual, platoActual, piñonActual;

        public Bicicleta()
        {
            velocidadActual = 5;
            platoActual = 1;
            piñonActual = 1;
        }

        void acelerar()
        {
            velocidadActual = velocidadActual * 2;
        }

        void frenar()
        {
            velocidadActual = velocidadActual / 2;
        }

        double cambiarPlato(double plato)
        {
            Console.Write("Ingrese un plato: ");
            plato = int.Parse(Console.ReadLine());
            return plato;
        }

        double cambiarPiñon(double piñon)
        {
            Console.Write("Ingrese un piñón: ");
            piñon = int.Parse(Console.ReadLine());
            return piñon;
        }
        static void Main(string[] args)
        {
            Bicicleta miBicicleta = new Bicicleta();
            Console.WriteLine(miBicicleta.velocidadActual);
            Console.WriteLine(miBicicleta.platoActual);
            Console.WriteLine(miBicicleta.piñonActual);
            miBicicleta.acelerar();
            miBicicleta.frenar();
            miBicicleta.piñonActual = miBicicleta.cambiarPiñon(miBicicleta.piñonActual);
            miBicicleta.platoActual = miBicicleta.cambiarPlato(miBicicleta.platoActual);
        }
    }
}
