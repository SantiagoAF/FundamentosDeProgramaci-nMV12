using System;

namespace _4.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("Ingresar número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else
            {
                if (num1 > 0)
                {
                    Console.WriteLine("El numero es positivo");
                }
                else
                {
                    Console.WriteLine("El numero es Negativo");
                }
            }            
        }
    }
}
