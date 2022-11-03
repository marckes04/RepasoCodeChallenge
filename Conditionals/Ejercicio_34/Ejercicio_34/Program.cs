using System;

namespace Ejercicio_34
{
    class Program
    {
        //Leer un numero menor que mil y contar cuantos caracteres tiene
        static void Main(string[] args)
        {

            Console.WriteLine("Digite un numero menor que mil");
            int num = int.Parse(Console.ReadLine());

            if(num < 0)
            {
                num = num * -1;
            }

            if (num >= 1 && num <= 9)
            {
                Console.WriteLine("El numero tiene 1 digito");
            }


            else if (num >= 10 && num <= 99)
            {
                Console.WriteLine("El numero tiene 2 digitos");
            }

            else if (num >= 100 && num <= 999)
            {
                Console.WriteLine("El numero tiene 3 digitos");
            }
        }

    }
}