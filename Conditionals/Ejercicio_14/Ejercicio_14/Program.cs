using System;

namespace Ejercicio_14
{
    class program
    {
        //Leer dos Numeros enteros de dos digitos y determinar a cuanto es igual
        //la suma de todos los digitos

        static void Main(string[] args)
        {
            int N1, N2, D11, D12, D21, D22, SumaD;
            Console.WriteLine("Digite dos numeros enteros");
            N1 = int.Parse(Console.ReadLine());
            N2 = int.Parse(Console.ReadLine());

            if (N1 < 0) 
            {
                N1 = N1 * -1;
            }
            if (N2 < 0) 
            {
                N2 = N2*-1;
            }

            if(N1 >= 10 && N1 <= 99 && N2 >= 10 && N2 <= 99)
            {
                D11 = N1 / 10;
                D12 = N1 % 10;
                D21 = N2 / 10;
                D22 = N2 % 10;

                SumaD = D11+D12+D21+D22;
                Console.WriteLine("La suma de los digitos es: " + SumaD);
            }
            else
            {
                Console.WriteLine("Uno de los numeros o ambos numero No es de dos digitos");
            }

        }
    }
}
