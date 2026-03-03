using System;


namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string diaSemana = "";
            float subTotal = 0.0f;
            float descuento = 0.0f;

            Console.WriteLine("Ingrese el monto de compra");
            subTotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana");
            diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "Lunes":
                    descuento = subTotal * 0.1f;
                    Console.WriteLine($"hoy es Lunes, el descuento es de {descuento}, el valor total a pagar es de {subTotal-descuento}");
                    break;
                case "Martes":
                    descuento = subTotal * 0.15f;
                    Console.WriteLine($"hoy es Martes, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                case "Miercoles":
                    descuento = subTotal * 0.1f;
                    Console.WriteLine($"hoy es Miercoles, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                case "Jueves":
                    descuento = subTotal * 0.15f;
                    Console.WriteLine($"hoy es Jueves, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                case "Viernes":
                    descuento = subTotal * 0.20f;
                    Console.WriteLine($"hoy es Viernes, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                case "Sabado":
                    descuento = subTotal * 0.20f;
                    Console.WriteLine($"hoy es Sabado, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                case "Domingo":
                    descuento = 0f;
                    Console.WriteLine($"hoy es Domingo, el descuento es de {descuento}, el valor total a pagar es de {subTotal - descuento}");
                    break;
                default:
                    Console.WriteLine("Por favor Ingrese un día de la semana correcto");
                   break;
            }*/

            double num1 = 0;
            double num2 = 0;
            string Operacion = "";

            Console.WriteLine("Ingresar numero 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresar numero 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese operacion, suma, resta, multiplicacion o division");
            Operacion = Console.ReadLine().ToLower();
           

            switch (Operacion)
            {
                case "suma":
                    Console.WriteLine(num1 + num2);
                    break;
                case "resta":
                    Console.WriteLine(num1 - num2);
                    break;
                case "multiplicacion":
                    Console.WriteLine(num1 * num2);
                    break;
                case "division":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Ingresar valor valido");
                    break;
            }
        }
    }
}
