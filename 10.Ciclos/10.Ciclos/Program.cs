using System;


namespace _10.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 0;
            int conjugado = 0;
            
            while (num >= 0)
            {
                Console.WriteLine("Ingrese numeros para sumar");
                num = Convert.ToInt32(Console.ReadLine());

                conjugado = num + conjugado;
                Console.WriteLine(conjugado);
            }
            Console.WriteLine($"suma {conjugado}");



        }
    }
}
