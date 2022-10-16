using System;

namespace Ejercicio_10
{
    class Program
    {
        // Leer un Numero entero de dos digitos y determinar si estos son iguales
        static void Main(String[] args)
        {
            int Numero,Dig1,Dig2;
            Console.WriteLine("Inserte un numero de dos digitos: ");
            Numero = int.Parse(Console.ReadLine());

            if(Numero >= 10 && Numero <= 99)
            {
                Dig1 = Numero / 10;
                Dig2 = Numero % 10;

                if(Dig1 == Dig2)
                {
                    Console.WriteLine("Los dos numeros son iguales");
                }
                else
                {
                    Console.WriteLine("Los dos numeros son diferentes");
                }
            }
            else
            {
                Console.WriteLine("El numero no tiene dos digitos");
            }
        }
    }
}