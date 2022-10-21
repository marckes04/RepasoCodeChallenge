using System;

namespace Ejercicio_11
{
    //Leer dos numeros enteros y determinar cual es mayor
    class Programm
    {
       static void Main(string[] args)
        {
            int Num, Dig1, Dig2;

            Console.WriteLine("Escriba un numero entero");
            Num = int.Parse(Console.ReadLine());

            if(Num <0)
            {
                Num = Num * -1;
            }

            if(Num >= 10 || Num <= 99)
            {
                Dig1 = Num / 10;
                Dig2 = Num % 10;

                if(Dig1 > Dig2)
                {
                    Console.WriteLine("El digito 1° es mayor que el 2°");
                }

                else if( Dig1 == Dig2)
                {
                    Console.WriteLine("Los dos digitos son iguales");
                }

                else
                {
                    Console.WriteLine("El digito 2° es mayor que el 1°");
                }
            }

            else
            {
                Console.WriteLine("El numero no tiene dos digitos");
            }
        }
    }
}