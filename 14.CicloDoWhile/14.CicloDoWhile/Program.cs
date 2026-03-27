using System;


namespace _14.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int numeroPrimo = 2;
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
            } while (numeroPrimo <= 100);      */





            /*char Continuar = ' ';
            char Operador = ' ';
            int num1 = 0;
            int num2 = 0;
            do
            {
                Console.WriteLine("Ingrese la operación s para suma, r para resta, d para división, m para multioplicación");
                Operador = Convert.ToChar(Console.ReadLine());
                
                Console.WriteLine("Ingrese el primer numero");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (Operador == 's')
                {
                    Console.WriteLine($"La suma es:{num1 + num2}");
                }
                else if (Operador == 'r')
                {
                    Console.WriteLine($"La resta es:{num1 - num2}");
                }
                else if (Operador == 'd')
                {
                    Console.WriteLine($"La división es:{num1 / num2}");
                }
                else if (Operador == 'm')
                {
                    Console.WriteLine($"La multiplicación es:{num1 * num2}");
                }
                else
                {
                    Console.WriteLine("Ingresar un dato Valido");
                }

                    Console.WriteLine("Desea continuar s para si, n para no");
                Continuar = Convert.ToChar(Console.ReadLine());
            } while (Continuar == 's');
            */

            /*string continuar = "";
            int contadorTotal = 0;
            int sumaTotal = 0;
            int contadorImpares = 0;
            int contadorPares = 0;
            int numero = 0;
            do
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

               
                if (numero % 2 == 0)
                {
                    contadorPares++;
                }
                else
                {
                    contadorImpares++;
                }

                
                sumaTotal += numero;
                contadorTotal++;

                Console.Write("¿Desea ingresar otro número? (s/n): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

           
            double promedio = sumaTotal / contadorTotal;

            Console.WriteLine("Resultados");
            Console.WriteLine("Cantidad de números pares: " + contadorPares);
            Console.WriteLine("Cantidad de números impares: " + contadorImpares);
            Console.WriteLine("Promedio de todos los números: " + promedio);
            Console.WriteLine("Promedio de todos los números: " + promedio);*/

           /* Console.WriteLine("Ingrese la contraseña");
            string contraseña = Console.ReadLine();
            string password = "";
            int numeroDeIntentos = 0;

            do
            {                
                Console.WriteLine($"La contraseña es {contraseña}");
                Console.WriteLine($"Ingrese la contraseña correcta");
                password = Console.ReadLine();






                numeroDeIntentos++;
            } while (contraseña != password);

            Console.WriteLine($"Numero de intentos");*/
    

        }
    }
}

