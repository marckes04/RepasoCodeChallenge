using System;

namespace Ejercicio_25
{
    /*
     * Leer un numero entero de tres digitos y determinar si alguno de sus digitos es igual a la suma de los 
     * otros dos.
     */

    class program
    {
        static void Main(string[] arg)
        {
            int Num, Dig1,Dig2, Dig3;

            Console.WriteLine("Digite un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            if(Num >= 100 && Num <= 999)
            {
                Dig1 = Num / 100;
                Dig2 = (Num/10) % 10;
                Dig3 = Num % 10;

                if(Dig1 == Dig2 + Dig3 || Dig2 == Dig1+Dig3 ||
                   Dig3 == Dig1 + Dig2)
                {
                    Console.WriteLine("La suma de sus digitos es igual a la suma de los otros dos");
                }

                else
                {
                    Console.WriteLine("La suma de sus digitos no es igual a la suma de los otros dos");
                }
            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}