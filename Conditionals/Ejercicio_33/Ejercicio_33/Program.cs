using System;

namespace Ejercicio_33
{
    class Programm
    {
        // Leer un numero y determinar si un numero termina en 7
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Digite un numero entero: ");
            Num = int.Parse(Console.ReadLine());

            if (Num % 10 == 7)
                Console.WriteLine("El numero termina en 7");
            else
                Console.WriteLine("El numero no termina en 7");
        }
    }
}
