using   System;

// Leer si un numero termina en 4 o No

namespace Ejercicio_1
{
    class program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserte Un Numero: ");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero % 10 == 4)
                Console.WriteLine("Numero Termina en 4");
            else
                Console.WriteLine("Numero No Termina en 4");
        }
    }
}