using System;
using System.Diagnostics.Eventing.Reader;


namespace CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese numero 1");
            num1 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Ingrese numero 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                if (num1 > num3)
                {
                    Console.WriteLine("El mayor número es " + num1);
                }
                else
                {
                    Console.WriteLine("El mayor número es " + num3);
                }


            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("El mayor número es " + num2);
                }
                else
                {
                    Console.WriteLine("El mayor número es 5" + num3);    
                }
            }
        }
    }       
}
