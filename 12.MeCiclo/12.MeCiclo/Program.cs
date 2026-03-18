using System;


namespace _12.MeCiclo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el rango de números:");
            int rango = int.Parse(Console.ReadLine());

            int contador = 1;       
            int pares = 0;          

            while (contador <= rango) 
            {
                if (contador % 2 == 0) 
                {
                    pares = pares + 1; 
                }
                contador = contador + 1;
            }

            Console.WriteLine("La cantidad de números pares es " + pares);

        }
    }
}
