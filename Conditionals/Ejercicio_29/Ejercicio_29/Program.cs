using System;

namespace Ejercicio_29
{
    class Program
    { /*
       * Leer un numero entero de 5 digitos y determinar si es numero capicuo
       *ej.15651 y 59895
       */
        static void Main(String[] args)
        {
            int Num, D1, D2,D3, D4, D5;

            Console.WriteLine("Digite un numero de 5 digitos");
            Num = int.Parse(Console.ReadLine());

            if(Num >= 10000 && Num <= 99999)
            {
                D1 = Num / 10000;
                D2 = (Num / 1000) % 10;
                D3 = (Num / 100) % 10;
                D4 = (Num / 10) % 10;
                D5 = Num % 10;

                if(D1 == D5 && D2 == D4)
                {
                    Console.WriteLine("El numero es capicuo");
                }
                else
                {
                    Console.WriteLine("El numero No es capicuo");
                }

            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }

        }
    }
}