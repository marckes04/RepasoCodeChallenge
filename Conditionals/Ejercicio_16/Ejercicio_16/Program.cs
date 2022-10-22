using System;

namespace Ejercicio_16
{
    class Programm
    {
        /*
         * Leer un numero entero de tres digitos y determinar si al menos dos de sus tres 
         * digitos son iguales
         */

        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, Dig3;
            Console.WriteLine("Escriba un numero Entero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            Dig1 = Num / 100;
            Dig2 = (Num / 10) % 10;
            Dig3 = Num % 10;

            if (Dig1 == Dig2 || Dig2 == Dig3 || Dig1 == Dig3)
            {
                Console.WriteLine("Al menos dos de sus tres digitos son iguales");
            }
            else
            {
                Console.WriteLine("No se cumple la condición");
            }
        }
    }
}