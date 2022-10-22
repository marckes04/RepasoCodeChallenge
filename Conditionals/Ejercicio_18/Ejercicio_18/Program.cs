using System;

namespace Ejercicio_18
{
    /*Leer un numero entero de tres digitos y determinar si algun digito
      es multiplo de los otros    
     */
    class Program
    {
        // Leer un numero de tres digitos y determinar si un digito es multiplo de los otros
        static void Main(string[] args)
        {
            int Num,Dig1,Dig2,Dig3;

            Console.WriteLine("Escriba un numero entre 100 y 999");
            Num = int.Parse(Console.ReadLine());

            Dig1 = Num / 100;
            Dig2 = (Num / 10) % 10;
            Dig3 = Num % 10;

            if((Dig1%Dig2 == 0  && Dig2%Dig1 == 0) ||
               (Dig2%Dig1 == 0  && Dig2%Dig3 == 0) ||
               (Dig3%Dig1 == 0  && Dig3%Dig2 == 0))
            {
                Console.WriteLine("Algun digito es multiplo de los otros");
            }
            else
            {
                Console.WriteLine("Ningun digito es multiplo de los otros");
            }
        }
    }
}
