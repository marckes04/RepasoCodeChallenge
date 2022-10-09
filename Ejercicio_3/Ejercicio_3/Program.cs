using System;

namespace Ejercicio_3
{
    // Verificar si es Numero Negativo

    class program
    {
        static void Main(string[] args)
        {
            int Numero;

            Console.WriteLine("Inserte Numero");

            Numero = int.Parse(Console.ReadLine());


            if(Numero < 0)
            {
                Console.WriteLine("El Numero es Negativo");
            }
            else
                Console.WriteLine("El Numero no es Negativo");

        }
    }
}