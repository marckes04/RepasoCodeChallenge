using System;

namespace Ejercicio_32
{
    //  Leer un numero entero y determinar si es multiplo de 7 
    class Program
    {
        static void Main(string[] args)
        {
            int Num;

            Console.WriteLine("Digite un numero: ");
            Num = int.Parse(Console.ReadLine());

            if (Num % 7 == 0)
                Console.WriteLine("El numero es multiplo de 7");
            else
                Console.WriteLine("El numero no es multiplo de 7");
        }
    }
}
