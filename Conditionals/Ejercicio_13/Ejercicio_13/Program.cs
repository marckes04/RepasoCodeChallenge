using System;
 
namespace Ejercicio_13
{
    class program
    {
        /* Leer dos numeros enteros de dos digitos y determinar si la suma de los dos numeros origina 
         * un numero par
        */
        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, SumaD;


            Console.WriteLine("Digite un numero entero: ");
            Num = int.Parse(Console.ReadLine());

            if(Num < 0)
            {
                Num = Num * -1;
            }

            if(Num >= 10 && Num <= 99)
            {
                Dig1 = Num/10;
                Dig2 = Num % 10;
                SumaD = Dig1 + Dig2;
                if (SumaD % 2 == 0)
                {
                    Console.WriteLine("La suma de dos digitos es par");
                }
                else
                {
                    Console.WriteLine("La suma de dos digitos es impar");
                }

            }

            else
            {
                Console.WriteLine("El numero no tien dos digitos");
            }
        }
    }
}

