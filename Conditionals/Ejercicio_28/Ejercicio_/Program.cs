using System;

namespace Ejercicio_28
{
    class Programm
    {
        /*
         *Leer numero entero menor que 50 positivo y determinar si es numero primo 
         */
        static void Main(string[] args)
        {
            int Num;
            string cont = " ";
            Console.WriteLine("Escriba numero menor que 50 positivo y si es primo");
           Num = int.Parse(Console.ReadLine());

            if(Num > 0 && Num <50)
            {
               for(int i = 2; i < Num; i++)
               {
                    if ((Num % i) == 0)
                    {
                        cont = "A";
                    }
               }

               if (cont == "A")
                {
                    Console.WriteLine("El numero no es primo");
                }
                else
                {
                    Console.WriteLine("El numero es primo");
                }
            }

            else
            {
                Console.WriteLine("Numero fuera de rango");
            }

            
        }
    }
}