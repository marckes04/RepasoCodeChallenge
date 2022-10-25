using System;

namespace Ejercicio_30
{
    class Programm
    { 
        /*Leer un numero entero de 4 digitos y determinar si el segundo digito
          es igual al penultimo
         */
        static void Main(string[] args)
        {
            int Num, D1, D2, D3, D4;
            Console.WriteLine("Digite un numero de 4 digitos");
            Num = int.Parse(Console.ReadLine());

            if (Num >= 1000 && Num <= 9999)
            {
                D1 = Num / 1000;
                D2 = (Num / 100) % 10;
                D3 = (Num / 10) % 10;
                D4 = Num % 10;

                if(D2 == D3)
                {
                    Console.WriteLine("Los numero de la segunda y cuarta posicion son iguales");
                }
                else
                {
                    Console.WriteLine("Los numero de la segunda y cuarta posicion son diferentes");
                }
            }

            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}
