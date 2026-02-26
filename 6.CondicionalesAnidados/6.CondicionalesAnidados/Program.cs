using System;

namespace _6.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = 0;
            Console.WriteLine("Ingrese Nota#1");
            Nota1 = Convert.ToDouble(Console.ReadLine());
            double Nota2 = 0;
            Console.WriteLine("Ingrese Nota#1");
            Nota2 = Convert.ToDouble(Console.ReadLine());
            double Nota3 = 0;
            Console.WriteLine("Ingrese Nota#1");
            Nota3 = Convert.ToDouble(Console.ReadLine());

            double Promedio = (Nota1 + Nota2 + Nota3) / 3;

            if (Promedio < 7.5)
            {
                Console.WriteLine("Error, promedio muy deficiente");
            }
            else
            {
                if (7.5 <= Promedio && Promedio <= 8.4)
                {
                    Console.WriteLine("El promedio es " + Promedio + " Bien");
                }
                else
                {
                    if (8.5 <= Promedio && Promedio <= 9.4)
                    {
                        Console.WriteLine("El promedio es " + Promedio + " Muy bien");
                    }
                    else
                    {
                        if (9.5 <= Promedio && Promedio <= 10)
                        {
                            Console.WriteLine("El promedio es " + Promedio + " Excelente");
                        }
                    }
                }
            }
        }
    }
}
