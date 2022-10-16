using System;

namespace Ejercicio_7
{
    class programm
    {
        //Leer numero de dos digitos y verificar si es primo y negativo

        static void Main(string[]arg)
        {
            int Numero = 0;
            Console.WriteLine("Escriba un Numero");
            Numero = int.Parse(Console.ReadLine());

            if(Numero == -2 || Numero == -3 || Numero == -5 || Numero == -7 ||
               Numero == -11 || Numero == -13 || Numero == -17 || Numero == -19)
            {
                Console.WriteLine("El numero es primo y negativo");
            }

            else
            {
                Console.WriteLine("El numero no es primo o no es negativo");
            }

        }
    }
}
