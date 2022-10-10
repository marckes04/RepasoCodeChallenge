using System;

namespace Ejercicio_6
{
    // Leer numero entero menor que 20 y determinar si es primo

    class program
    {
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Digite un numero");
            Num = int.Parse(Console.ReadLine());

            if(Num < 20)
            {
                if(Num == 2 || Num == 3 || Num == 5 || Num == 7 || Num == 11
                    || Num == 13 || Num ==17 || Num == 19)
                {
                    Console.WriteLine("Numero es primo y menor que veinte");
                }
                else
                {
                    Console.WriteLine("Numero no es primo y menor que veinte");
                }
            }

            else
            {
                Console.WriteLine("Numero no es menor que 20");
            }

        }
    }
}