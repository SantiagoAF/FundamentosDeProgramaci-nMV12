using System;


namespace OperadoresTiposDatosConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores
            //Operadores Numericos
            //Cambio de signo 

            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.WriteLine(num1 + "//" + num2 + "//" + num3);
            //Aritmeticos
            int num4 = 2 + 3;
            int num5 = 12 - 58;
            int num6 = 23 * 4;
            float num7 = (float)57 / 3;

            Console.WriteLine("suma:{0}, Resta:{1}, Multiplicación:{2}, Division:{3}", num4, num5, num6, num7);
            //Operadores de Incremento y Decremento
            num4++;//Incremento en una unidad
            num1--;//Decremento en una unidad
            num3 += 200;//Suma
            num1 -= 1000;//Resta
            num7 *= num1;//Multiplicacion
            num5 /= num1;//Division
            //Orden de evaluacion de operadores aritmeticos
            int num8 = 4 * 3 / 2;
            int num9 = 4 * (3 / 2);
            int num10 = 4 + 2 * (3 - 2);
            //Operadores Logicos Y-AND-NO(&&)
            Console.WriteLine("Tabla De Verdad Conjuncion");
            Console.WriteLine("V y V: " + (true && true));
            Console.WriteLine("V y F: " + (true && false));
            Console.WriteLine("F y V: " + (false && true));
            Console.WriteLine("F y F: " + (false && false));
            //Disyuncion - 0 - Or - ||
            Console.WriteLine("Tabla De Verdad Conjuncion");
            Console.WriteLine("V 0 V: " + (true || true));
            Console.WriteLine("V 0 F: " + (true || false));
            Console.WriteLine("F 0 V: " + (false || true));
            Console.WriteLine("F 0 F: " + (false || false));
            //Operadores de Comparacion
            bool dato1 = 4 > 5;
            bool dato2 = 4 != 6;
            bool dato3 = 1 == 1;
            bool dato4 = !dato2;
            bool dato5 = 100 < 200 || dato1 && true;
        }


    }
    
}
