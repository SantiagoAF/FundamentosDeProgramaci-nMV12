using System;

namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = " ";
            float sueldo = 0.0f;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Single.Parse(Console.ReadLine());
                 //Si la condicion es verdadera
            if (sueldo >= 3000)
            {
                Console.WriteLine("La persona " + nombre + " debe abonar impuestos");
            }
            else //Si la condición es falsa
            { 
                Console.WriteLine("La persona "+ nombre + " esta exenta de impuestos");

            }*/
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("Ingresar numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine((Convert.ToDouble(num1 + num2)) + " y " + (Convert.ToDouble((num1 - num2))));
            }
            else 
            {
                Console.WriteLine((Convert.ToDouble(num1 * num2)) + " y " + (Convert.ToDouble((num1 / num2))));
            }
        }
    }
}
