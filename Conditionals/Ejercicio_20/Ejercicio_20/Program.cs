using System;

namespace Ejercicio_20
{
    //Leer tres numeros enteros y mostrarlos ascendentemente
    class programm
    {
        static void Main(string[] args)
        {
            int Num1,Num2, Num3;
            Console.WriteLine("Digite tres numeros");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());   
            Num3 = int.Parse(Console.ReadLine());

            if(Num1 <= Num2 && Num2 <= Num3)
            {
                Console.WriteLine(Num1);
                Console.WriteLine(Num2);
                Console.WriteLine(Num3);
            }

            if (Num1 <= Num3 && Num3 <= Num2)
            {
                Console.WriteLine(Num1);
                Console.WriteLine(Num3);
                Console.WriteLine(Num2);
            }

            if (Num2 <= Num1 && Num1 <= Num3)
            {
                Console.WriteLine(Num2);
                Console.WriteLine(Num1);
                Console.WriteLine(Num3);
            }

            if (Num2 <= Num3 && Num3 <= Num1)
            {
                Console.WriteLine(Num2);
                Console.WriteLine(Num3);
                Console.WriteLine(Num1);
            }

            if (Num3 <= Num1 && Num1 <= Num2)
            {
                Console.WriteLine(Num3);
                Console.WriteLine(Num1);
                Console.WriteLine(Num2);
            }

            if (Num3 <= Num2 && Num2 <= Num1)
            {
                Console.WriteLine(Num1);
                Console.WriteLine(Num2);
                Console.WriteLine(Num3);
            }



        }
    }
}
