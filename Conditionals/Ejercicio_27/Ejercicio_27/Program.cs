using System;

namespace Ejercicio_27
{
    /*
     * leer un numero de tres digitos y determinar cuantos impares tiene
     */
    class Pogramm
    {
        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, Dig3, CuentaImpares;

            Console.WriteLine("Digite un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            if (Num >= 100 && Num <= 999)
            {
                Dig1 = Num / 100;
                Dig2 = (Num / 10) % 10;
                Dig3 = Num % 10;

                CuentaImpares = 0;

                if (Dig1 % 2 != 0)
                {
                    CuentaImpares++;
                }

                if (Dig2 % 2 != 0)
                {
                    CuentaImpares++;
                }


                if (Dig3 % 2 != 0)
                {
                    CuentaImpares++;
                }

                Console.WriteLine("El numero par tiene {0} digitos impares", CuentaImpares);
            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}
