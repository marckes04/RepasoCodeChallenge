using System;

namespace Ejercicio_31
{
    //Leer un numero entero y determinar si es igual a 10

    class Programm
    {
        static void Main(string[] arg)
        {
            int num = 0;

            Console.WriteLine("Inserte un numero");
            num = int.Parse(Console.ReadLine());

            if (num == 10)
                Console.WriteLine("El numero es igual a 10");
            else
                Console.WriteLine("El numero es diferente a 10");
        }
    }
}
