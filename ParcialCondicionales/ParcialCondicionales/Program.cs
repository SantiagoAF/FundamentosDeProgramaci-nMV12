using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            Console.WriteLine("Ingresar edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad > 0)
            {
                string sala = "";
                string juego = "";
                int precio  = 0;
                if (1 < edad && edad <= 6
                    ) 
                {
                    Console.WriteLine("La sala disponible es Sala 1, Ingresar alguna sala disponible");
                    sala = Console.ReadLine();
                    if (sala == "Sala 1") 
                    Console.WriteLine("Los juegos disponibles en esta sala son, Juego 1 y Juego 5, Ingresar alguno disponible");
                    juego = Console.ReadLine();
                    if (juego == "Juego 1")
                    {
                        precio = 3000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}"); 
                    }
                    if (juego == "Juego 5")
                    {
                        precio = 7000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                    }        
                }
                if (6 < edad && edad <= 16) 
                {
                    Console.WriteLine("La sala disponible es Sala 2, Ingresar alguna sala disponible");
                    sala = Console.ReadLine();
                    if (sala == "Sala 2") 
                    Console.WriteLine("Los juegos disponibles en esta sala son, Juego 3 y Juego 6, Ingresar alguno disponible");
                    juego = Console.ReadLine();
                    if (juego == "Juego 3")
                    {
                        precio = 7000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                    }
                    if (juego == "Juego 6")
                    {
                        precio = 9000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                    }
                }
                if (17 <= edad && edad <= 26) 
                {
                    Console.WriteLine("La sala disponible es Sala 3 y Sala 4, Ingresar alguna sala disponible");
                    sala = Console.ReadLine();
                    if (sala == "Sala 3") 
                    Console.WriteLine("Los juegos disponibles en esta sala son, Juego 2 y Juego 7, Juego   Ingresar alguno disponible");
                    juego = Console.ReadLine();
                        if (juego == "Juego 2")
                        {
                        precio = 5000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                        if (juego == "Juego 7")
                        {
                        precio = 10000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                    if (sala == "Sala 4") 
                    Console.WriteLine("Los juegos disponibles en esta sala son, Juego 4 y Juego 8, Juego   Ingresar alguno disponible");
                    juego = Console.ReadLine();
                        if (juego == "Juego 4")
                        {
                        precio = 9000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                        if (juego == "Juego 8")
                        {
                        precio = 7000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                }
                if (edad > 26)
                {
                    Console.WriteLine("La sala disponible es Sala 5, Ingresar alguna sala disponible");
                    sala = Console.ReadLine();
                    if (sala == "Sala 5") 
                    Console.WriteLine("Los juegos disponibles en esta sala son, Juego 9 y Juego 10, Ingresar alguno disponible");
                    juego = Console.ReadLine();
                        if (juego == "Juego 9")
                        {
                        precio = 5000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                        if (juego  == "Juego 10")
                        {
                        precio = 3000;
                        Console.WriteLine($"Edad: {edad}");
                        Console.WriteLine($"Sala seleccionada: {sala}");
                        Console.WriteLine($"Juego seleccionado: {juego}");
                        Console.WriteLine($"Precio a pagar: {precio}");
                        }
                }
            }
            else
            {
                Console.WriteLine("Error");       
            }
        }
    }
}
