using System;

namespace _13.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int suma = 0; //Acumuluador

            do
            {
                suma += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine($"La suma de los primeros números enteros es: {suma}");*/

            /*int numero = 0;
            char respuesta = ' ';
            

            do
            {
                Console.Clear();
                int contador = 1;
                Console.WriteLine("Digite el número para calcular su tabla de multiplicar:");
                numero = int.Parse(Console.ReadLine());


                do
                {
                    Console.WriteLine($"{numero} X {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);

                Console.WriteLine("¿Desea calcular más tablas de multiplicar");
                respuesta = Char.Parse(Console.ReadLine());

            } while (respuesta == 's');*/



            string nombre = "";
            string cuenta = "";
            float saldo = 0;
            int respuesta = 0;
            int numeroDeUsuarios = 0;
            float acumuladoSaldo = 0;
           do
           {
                Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cuenta");
            cuenta = Console.ReadLine();
            Console.WriteLine("ingrese el saldo");
            saldo = Single.Parse(Console.ReadLine());

           

            
            if (saldo > 3000000)
            {
                Console.WriteLine($"usuario {nombre}, con cuenta {cuenta}, tiene un saldo de ${saldo}, y es apto para el crédito");
            }
                else
                {
                    if (saldo >= 3000000)
                    {
                        Console.WriteLine($"usuario {nombre}, con cuenta {cuenta}, tiene un saldo de ${saldo}, y no es apto para el crédito");
                    }
                }
                acumuladoSaldo += saldo;
                numeroDeUsuarios++;
            Console.WriteLine("Desea encuestar mas usuarios?\n1.Sí 2.No");
             respuesta = int.Parse(Console.ReadLine());
           } while (respuesta == 1);
            Console.WriteLine($"El numero de encuestados es:{numeroDeUsuarios}, el valor de promedio de los saldos de los usuarios encuestados es de:{acumuladoSaldo / numeroDeUsuarios}");

        }
    }
}
