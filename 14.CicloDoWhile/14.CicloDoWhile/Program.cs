using System;


namespace _14.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroPrimo = 2;
            do
            {
                bool esPrimo = true;
                int divisor = 2;
                while (divisor < numeroPrimo)
                {
                    if (numeroPrimo % divisor == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                    divisor++;
                }
                if (esPrimo)
                {
                    Console.WriteLine(numeroPrimo + " Es Primo");
                }
                numeroPrimo++;
            } while (numeroPrimo <= 100);      
        }
    }
}
