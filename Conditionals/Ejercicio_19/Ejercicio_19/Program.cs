using System;

namespace Ejercicio_19
{
   class Programm
    {
        /*
         Leer tres numeros enteros y determinar cual es mayor.
         Usar dos variables
         */
        static void Main(string[] arg)
        {
            int Num1,Num2;
            Console.WriteLine("Digite 3 numeros");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());

            if (Num1 > Num2) 
            {
                Console.WriteLine(Num2);
                if (Num1 > Num2)
                {
                    Console.WriteLine("El numero {0} es el mayor", Num1);
                }
                else
                {
                    Console.WriteLine("El numero {0} es el mayor", Num2);
                }
            }
            else
            {
                Console.WriteLine(Num1);
                if(Num1 > Num2)
                {
                    Console.WriteLine("El numero {0} es el mayor", Num1);
                }

                else
                {
                    Console.WriteLine("El numero {0} es el mayor", Num2);
                }
            }

        }
    }
}