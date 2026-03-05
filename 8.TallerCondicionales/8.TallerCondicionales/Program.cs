using System;
using System.Security.Cryptography;
using System.Timers;


namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("ingrese el numero 1");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el numero 3");
            numero3 = Convert.ToInt32(Console.ReadLine());



            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
                {
                    Console.WriteLine($"{numero1},{numero2},{numero3}");
                }
                if (numero1 > numero2 && numero1 > numero3 && numero3 > numero2)
                {
                    Console.WriteLine($"{numero1},{numero3},{numero2}");
                }
                if (numero2 > numero1 && numero2 > numero3 && numero1 > numero3)
                {
                    Console.WriteLine($"{numero2},{numero1},{numero3}");
                }
                if (numero2 > numero1 && numero2 > numero3 && numero3 > numero1)
                {
                    Console.WriteLine($"{numero2},{numero3},{numero1}");
                }
                if (numero3 > numero1 && numero3 > numero2 && numero2 > numero1)
                {
                    Console.WriteLine($"{numero3},{numero2},{numero1}");
                }
                if (numero3 > numero1 && numero3 > numero2 && numero1 > numero2)
                {
                    Console.WriteLine($"{numero3},{numero1},{numero2}");
                }
            }
            else
            {
                Console.WriteLine("Ingresar numeros Diferentes");
            }*/

            //Ejercicio 2
            /*bool invencible;
            int municion = 0;
            Console.WriteLine("el personaje esta en estado invencible");
            invencible = Convert.ToBoolean(Console.ReadLine());

            Random rnd = new Random();
            municion = rnd.Next(1, 11);
            Console.WriteLine("municion " + municion);
            if (invencible == true && municion > 0)
            {
                Console.WriteLine("El personaje esta disparando");
            }
            else
            {
            Console.WriteLine("Nada pasa");
            }*/

            //Ejercicio 3
            /*double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double x3 = 0;
            double y3 = 0;
            Console.WriteLine("Ingrese coordenada x1");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada y1");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada x3");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese coordenada y3");
            y3 = Convert.ToDouble(Console.ReadLine());

            double distanciaP1P2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distanciaP2P3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double distanciaP1P3 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double a = distanciaP1P2;
            double b = distanciaP2P3;
            double c = distanciaP1P3;

            bool condicion1= (a + b > c);
            bool condicion2 = (a + c > b);
            bool condicion3 = (b + c > a);

            if (condicion1 && condicion2 && condicion3)
            {
                Console.WriteLine("Se puede construir un triangulo");
                
            }
            else if (condicion1 && condicion2)
            {
                Console.WriteLine("No se puede hacer un triangulo por que b + c > a no se cumple");
            }
            else if (condicion2 && condicion3)
            {
                Console.WriteLine("No se puede hacer un triangulo por que a + b > c no se cumple");
            }
            else if (condicion1 && condicion3)
            {
                Console.WriteLine("No se puede hacer un triangulo por que a + c > b no se cumple");
            }
            else if (condicion1)
            {
                Console.WriteLine("No se puede hacer un triangulo por que a + c > b y b + c > a no se cumplen");
            }
            else if (condicion2)
            {
                Console.WriteLine("No se puede hacer un triangulo por que a + b > c y b + c > a no se cumplen");
            }
            else  if (condicion3)
            {
                Console.WriteLine("No se puede hacer un triangulo por que a + b > c y a + c > b no se cumplen");
            }*/

            //Ejercicio 4
            /*string direccion = "";
            Console.WriteLine("Muevase ala izquierda o la derecha con I o D");
            direccion = Console.ReadLine();
            switch (direccion)
            { 
            case "I":
                Console.WriteLine("El personaje se mueve ala Izquierda");
                break;
            case "D":
                Console.WriteLine("EL personaje se mueve ala Derecha");
                break;
            default:
                Console.WriteLine("No se puede mover en esa direccion");
                break;
            }*/

            //Ejercicio 5
            /*string accion = "";
            int vidas = 0;
            Random rnd = new Random();
            vidas = rnd.Next(0,6);
            Console.WriteLine($"Vidas: {vidas}");
            if (vidas > 0)
            {
                Console.WriteLine("Ingrese una letra para realizar una accion: c, x, t, i");
                accion = Console.ReadLine();
                switch (accion)
                {
                    case "c":
                        Console.WriteLine("El personaje esta disparando");
                        break;
                    case "x":
                        Console.WriteLine("El personaje está hablando con una Rana");
                        break;
                    case "t":
                        Console.WriteLine("El personja esta en modo Turbo");
                        break;
                    case "i":
                        Console.WriteLine("El personaje esta en modo invencible");
                        break;
                    default:
                        Console.WriteLine("Ingresar una letra para una acción");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }*/

        }
    }
}
