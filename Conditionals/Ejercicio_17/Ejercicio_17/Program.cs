using System;

namespace Ejercicio_17
{
    /* Leer Numero entero de tres digitos y determinar en que posición está 
     * el mayor digito.
     */
    class Programm
    {
        static void Main(string[] args)
        {
            int Num,Dig1,Dig2,Dig3;
            Console.WriteLine("Escriba un numero entero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            Dig1 = Num / 100;
            Dig2 = (Num / 10) % 10;
            Dig3 = Num % 10;

            if (Dig1 > Dig2 && Dig1 > Dig3)
            {
                Console.WriteLine("El mayor digito está en la posición 1°");
            }

            if (Dig3 > Dig1 && Dig3 > Dig2)
            {
                Console.WriteLine("El mayor digito está en la posición 3°");
            }

            if (Dig2 > Dig1 && Dig2 > Dig3)
            {
                Console.WriteLine("El mayor digito está en la posición 2°");
            }
        }
    }
}
