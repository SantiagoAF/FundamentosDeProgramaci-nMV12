using System;


namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador= 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador:{contador} - Acumulador: { acumulador}");
                contador++;

            }

            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/


            int acumulador = 0;
            int contador = 0;
            Console.Write("Ingrese un numero");
            contador = Convert.ToInt32(Console.ReadLine());
            acumulador = contador - 1; 
            while (acumulador > 0)
            {
                contador = contador * acumulador;
                acumulador--;
                Console.WriteLine(contador);
            }
            Console.WriteLine("El resultado es: " + contador);
        }
    }
}
