using System;

namespace Ejercicio_5
{
    // Leer un numero de dos digitos y decir sin son pares

    class program
    {
        static void Main(string[] arg)
        {
            int Num,Dig1,Dig2;

            Console.WriteLine("Escriba un Numero de dos digitos");
            Num = int.Parse(Console.ReadLine());
            if(Num < 0)
            {
                Num = Num * -1;
            }

            if (Num >= 10 && Num <= 99)
            {
                Dig1 = Num / 10;
                Dig2 = Num % 10;

                if ((Dig1 % 2 == 0) && (Dig2 % 2 == 0))
                {
                    Console.WriteLine("Los dos digitos son pares");
                }

                else
                {
                    Console.WriteLine("Los dos digitos no son pares");
                }
            }
            else
            {
                Console.WriteLine("El numero no tiene dos Digitos");
            }


        }
    }
}