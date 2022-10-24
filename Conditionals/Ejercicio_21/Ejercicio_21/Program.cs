using System;
using System.Net;

namespace Ejercicio_21
{
    /*
     * Leer dos numeros enteros de dos digitos cada uno 
     * y determinar en cual de ellos se encuentra el mayor
     * digito.
     */

    class program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, D11, D12,D21,D22;
            Console.WriteLine("Digite dos numeros, cada uno entre 10 y 99");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());

            if((Num1 >= 10 && Num1 <= 99) && (Num2 >= 10 && Num2 <= 99))
            {
                D11 = Num1 / 10;
                D12 = Num1 % 10;
                D21 = Num2 / 10;
                D22 = Num2 % 10;

                if (D11 > D21 || D11 > D22 || D12 > D21 || D12 > D22)
                {
                    Console.WriteLine("El digito mayor está en el primer numero");
                }

                else if (D21 > D11 || D21 > D12 || D22 > D11 || D22 > D12)
                {
                    Console.WriteLine("El digito mayor está en el segundo numero");
                }

                else
                {
                    Console.WriteLine("Todos los numeros son iguales");
                }

            }
            else
            {
                Console.WriteLine("los numeros no están entre 10 y 99");
            }
        }
    }
}
