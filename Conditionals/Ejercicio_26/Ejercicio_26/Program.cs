using System;

namespace Ejercicio_26
{
    class Program
    {
        // Leer un numero de tres digitos y determinar a cuanto es igual la suma de sus digitos
        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, Dig3, SumD;

            Console.WriteLine("Escribe un numero entero de tres digito: ");
            Num = int.Parse(Console.ReadLine());

            if (Num >= 100 && Num <= 999)
            {
                Dig1 = Num / 100;
                Dig2 = (Num / 10) % 10;
                Dig3 = Num % 10;

                SumD = Dig1 + Dig2 + Dig3;

                Console.WriteLine("La suma de los tres digitos es: {0} ", SumD);

            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}
