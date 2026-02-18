using System;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = " ";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre de usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del usuario");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine($"La Persona {nombre}, debe abonar impuestos");
            }*/
            string nombre2 = " ";
            byte edad = 0;
            Console.WriteLine("Ingrese el nombre");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }

        }   
    }
}
