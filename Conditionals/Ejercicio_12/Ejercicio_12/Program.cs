using System;

namespace Ejercicio_12
{
    /* Leer dos numeros enteros de dos digitos y determinar si tienen dos digitos comunes,
     * es decir, si un digitoque está presente en un numero tambien está presente en el 
     * otro numero
     */

    class programm
    {
        static void Main(string[] args)
        {
            int N1,N2,D11,D12,D21,D22;
            Console.WriteLine("Escriba dos Numeros Enteros");
            Console.WriteLine("Digite el primer numero:");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el Segundo numero:");
            N2 = int.Parse(Console.ReadLine());

            if(N1 < 0)
            {
                N1 = N1 * -1;
            }

            if (N2 < 0)
            {
                N2 = N2 * -1;
            }

            D11 = N1 / 10;
            D12 = N1 % 10;
            D21 = N2 / 10;
            D22 = N2 % 10;

            if(D11 == D21 || D11 == D22 || D12 == D21 ||D12 == D22)
            {
                Console.WriteLine("Los dos numeros tiene digitos comunes");
            }
            else
            {
                Console.WriteLine("Los dos numeros no tienen digitos comunes");
            }
        }
    }
}