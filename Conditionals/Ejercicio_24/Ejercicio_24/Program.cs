using System;

namespace Ejercicio_24
{
    class program
    {
        // Leer un numero entero de tres digitos y determinar cuantos digitos
        static void Main(string[] args)
        {
            int Num, Dig1,Dig2,Dig3,CuentaPares;

            Console.WriteLine("Digite un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            if(Num >= 100 && Num <= 999)
            {
                Dig1 = Num / 100;
                Dig2 = (Num / 10) % 10;
                Dig3 = Num % 10;

                CuentaPares = 0;

                if(Dig1 % 2 == 0)
                {
                    CuentaPares++;
                }

                if (Dig2 % 2 == 0)
                {
                    CuentaPares++;
                }


                if (Dig3 % 2 == 0)
                {
                    CuentaPares++;
                }

                Console.WriteLine("El numero par tiene {0} digitos pares", CuentaPares);
            }
            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}
