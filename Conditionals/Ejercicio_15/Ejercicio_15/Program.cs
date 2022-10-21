using System;

namespace Ejercicio_15
{
    /*
     Leer numero enterode tres digitos y determinar cuanto es la suma de los digitos
     */
    class Program
    {
        static void Main(string[] arg)
        {
            int Num, Dig1, Dig2, Dig3, SumaD;

            Console.WriteLine("Digite un numero de tres digitos: ");
            Num = int.Parse(Console.ReadLine());

            if(Num < 0)
            {
                Num = Num * -1;
            }

            if(Num >= 100 && Num <= 999)
            {
                Dig1 = Num/ 100;
                Dig2 = (Num/10) % 10;
                Dig3 = Num % 10;
                SumaD = Dig1+ Dig2+Dig3;
                Console.WriteLine("La suma de los digitos es: "+SumaD);
            }
        }
    }
}
