using System;

namespace Ejercicio_4
{
    // Leer un numero Entero de dos digitos y calcular la suma entre ellos

    class program
    {
        static void Main(string[] args)
        {
            int Num, Dig1, Dig2, sumD;

            Console.WriteLine("Digite un numero de dos digitos");

            Num = int.Parse(Console.ReadLine());

            if(Num < 0)
            {
                Num = Num * -1;
            }

            if(Num >= 10 && Num <= 99)
            {
                Dig1 = Num / 10;
                Dig2 = Num % 10;
                sumD =  Dig1 + Dig2;
                Console.WriteLine("La suma de los dos digitos es: {0} ", sumD);
            }
            else
            {
                Console.WriteLine("El numero no tiene dos digitos");
            }


        }
    }        
}
