using System;

namespace Ejercicio_9
{
    // Leer un numero entero de dos digitos y determinar si un digito es multiplo del otro

    class program
    {
        static void Main(string[] args)
        {
            int Numero, Dig1, Dig2;
            Console.WriteLine("Escriba un numero de dos digitos: ");
            Numero = int.Parse(Console.ReadLine());

            if(Numero < 0)
            {
                Numero = Numero * -1;
            }

            if(Numero >= 10 && Numero <= 99)
            {
                Dig1 = Numero / 10;
                Dig2 = Numero % 10;

                if(Dig1 % Dig2 == 0 || Dig2 % Dig1 == 0)
                {
                    Console.WriteLine("Un digito es multiplo del otro");
                }
                else
                {
                    Console.WriteLine("Un digito no es multiplo del otro");
                }
            }
            else
            {
                Console.WriteLine("El numero no tiene dos digitos");
            }

        }
    }
}
