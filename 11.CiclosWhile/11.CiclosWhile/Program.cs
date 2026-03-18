using System;
using System.Runtime.InteropServices;

namespace _11.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int suma = 0;
            int impar = 1; 

            while (impar <= 99)
            {
                suma += impar;   
                impar += 2;      
            }

            Console.WriteLine($"La suma total es: {suma}");*/


     

            Console.WriteLine($"Ingrese la cantidad de numeros");
            int cantidad = int.Parse(Console.ReadLine());
            int mayoresque0 = 0;
            int menoresque0 = 0;
            int igualesque0 = 0;
            int contador = 0;

            while (contador < cantidad)
            {
                Console.Write($"Introduce el número {contador + 1}: ");
                int numero = int.Parse(Console.ReadLine());
                if (contador > 0)
                {
                    mayoresque0++;
                }
                else if (contador < 0)
                {
                    menoresque0++;
                }
                else
                {
                    igualesque0++;
                }
                contador++;
            }
       

            Console.WriteLine($"La cantidad de numeros mayores que 0 es: {mayoresque0}");
            Console.WriteLine($"La cantidad de numeros menores que 0 es: {menoresque0}");
            Console.WriteLine($"La cantidad de numeros iguales que 0 es: {igualesque0}");

        }
    }
}
