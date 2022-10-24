using System;

namespace Ejercicio_22
{
class program
    {
        // Leer un numero entero de tres digitos y determinar si el primer digito es igual al ultimo

        static void Main(string[] arg)
        {
            int Num, PrimDig, UltDig;

            Console.WriteLine("Digite un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            if (Num >= 100 && Num <= 999)
            {
                PrimDig = Num / 100;
                UltDig = Num % 10;

                if (PrimDig == UltDig)
                    Console.WriteLine("El primero y el ultimo digito son iguales");
                else
                    Console.WriteLine("El primero y el ultimo digito No son iguales");
            }
            else
            {
                Console.WriteLine("Numeros fuera del rango solicitado");
            }
        }
    }
}