using System;
using System.Globalization;
using System.Runtime.InteropServices;


namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int acumulador = 0;

             for (int Contador = 1; Contador <=5; Contador++)
             {
                 acumulador += Contador;

             }

             Console.WriteLine($"La suma de los cinco primeros números enteros es {acumulador}");*/

            /*int num = Convert.ToInt32(Console.ReadLine());
            int referencia = num;
            for ( int factorial = 1; factorial < referencia; factorial++)
            {
                num *= factorial;
            }

            Console.WriteLine(num);*/


            /*Console.WriteLine("multiplos de 5 de:");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hasta:");
            int hasta = Convert.ToInt32(Console.ReadLine());
            int multiplosde5 = 0;
            Console.Clear();
            for (int de = K; de <= hasta; de++)
            {
                if (de % 5 == 0 )
                {
                    Console.WriteLine(de);
                    multiplosde5++;
                }
            }
            Console.WriteLine($"Los multiplos de 5 que hay en ese rango son: {multiplosde5}");*/

            int hombres = 0;
            int mujeres = 0;
            int mayoresEdad = 0;
            int menoresEdad = 0;

            Random rnd = new Random();

            for (int i = 1; i <= 100; i++)
            {
                
                int genero = rnd.Next(0, 2);
                if (genero == 0)
                    hombres++;
                else
                    mujeres++;

                
                int edad = rnd.Next(14, 26);
                if (edad >= 18)
                    mayoresEdad++;
                else
                    menoresEdad++;
            }
          
            Console.WriteLine($"Hombres: {hombres}");
            Console.WriteLine($"Mujeres: {mujeres}");
            Console.WriteLine($"Mayores de edad: {mayoresEdad}");
            Console.WriteLine($"Menores de edad: {menoresEdad}");


        }
    }
}
