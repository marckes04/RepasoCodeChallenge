using System;

namespace Ejercicio_8
{
    class program
    {
        static void Main(string[] args)
        {
            //Leer un numero entero de dos digitos y decir si los dos digitos son primos

            int Numero, Dig1,Dig2 ;

            Console.WriteLine("Inserte un numero de dos digitos");
            Numero = int.Parse(Console.ReadLine());

            if (Numero >= 10 && Numero <= 99)
            {
                Dig1 = Numero / 10;
                Dig2 = Numero % 10;

                if ((Dig1 == 2 || Dig1 == 3 || Dig1 == 5 || Dig1 == 7)
                    && (Dig2 == 2 || Dig2 == 3 || Dig2 == 5 || Dig2 == 7))
                {
                    Console.WriteLine("Los dos digitos son primos");
                }

                else
                {
                    Console.WriteLine("uno de los de los digitos o los dos digitos no son primos");
                }
            }

            else
            {
                Console.WriteLine("El numero no es de dos digitos");
            }

        }
    }
}