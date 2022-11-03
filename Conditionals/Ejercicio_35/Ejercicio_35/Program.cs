using System;

namespace Ejercicio_35
{
    class programm
    {
        // Leer un numero entero de dos digitos, guardar este digito en una varibale y luego mostrarlo
        // por pantalla

        static void Main(string[] args)
        {
            int num, D1, D2;
            Console.WriteLine("Escriba un numero de dos digitos");
            num = int.Parse(Console.ReadLine());

            if (num >= 10 && num <= 99)
            {
                D1 = num / 10;
                D2 = num % 10;

                Console.WriteLine("Los digitos de estos numero son: {0} y {1} ", D1, D2);
            }

            else
            {
                Console.WriteLine("Numero fuera de rango");
            }
        }
    }
}