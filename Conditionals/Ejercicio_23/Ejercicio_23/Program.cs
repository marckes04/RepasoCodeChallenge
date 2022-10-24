using System;

namespace Ejercicio_23
{
    class Programm
    {
        // Leer un numero entero de tres digitos y determinar cuantos primos tiene.
        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, Dig3, CuentaPrimos;

            Console.WriteLine("Digite un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            if(Num >= 100 && Num <= 999)
            {
                CuentaPrimos = 0;
                Dig1 = Num / 100;
                Dig2 = (Num/10) % 10;
                Dig3 = Num % 10;

                if(Dig1 == 2 || Dig1 == 3 || Dig1 == 5 || Dig1 == 7)
                {
                    CuentaPrimos = CuentaPrimos + 1;
                }

                if (Dig2 == 2 || Dig2 == 3 || Dig2 == 5 || Dig2 == 7)
                {
                    CuentaPrimos = CuentaPrimos + 1;
                }

                if (Dig3 == 2 || Dig3 == 3 || Dig3 == 5 || Dig3 == 7)
                {
                    CuentaPrimos = CuentaPrimos + 1;
                }

                Console.WriteLine("Este numero entero tiene {0} numeros primos", CuentaPrimos);

            }

            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
            

        }
    }
}