using System;


namespace _16.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int empates = 0;
            int perdidos = 0;
            int ganados = 0;
            for (int partidos = 0; partidos < 30; partidos++)
            {
                int partidosResultado = rnd.Next(0, 3);
                if (partidosResultado == 0)
                {
                    empates++;
                }
                else if (partidosResultado == 1)
                {
                    perdidos++;
                }
                else
                {
                    ganados++;    
                }
            }
            Console.WriteLine($"Número de partidos ganados: {ganados}");
            Console.WriteLine($"Número de partidos perdidos: {perdidos}");
            Console.WriteLine($"Número de partidos empatados: {empates}");
            Console.WriteLine($"% de partidos ganados: {ganados * 100 / 30}%");
            Console.WriteLine($"% de partidos perdidos: {perdidos * 100 / 30}%");
            Console.WriteLine($"% de partidos empatados: {empates * 100 / 30}%");
        }
    }
}
