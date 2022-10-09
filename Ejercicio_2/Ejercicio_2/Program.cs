using System;
using System.Linq;


namespace Ejercicio_2
{
    // Identificar si un numero tiene 3 digitos

    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Inserte un numero");
             Numero = int.Parse(Console.ReadLine());

            if((Numero >= 100 && Numero <= 999) || (Numero >= -999 && Numero <= -100))
           
                Console.WriteLine("Numero Leido tiene 3 digitos");
            

            else
           
                Console.WriteLine("Numero Leido no tiene 3 digitos");

        }
    }
}


