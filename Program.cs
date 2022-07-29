using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_semana2_IvaniaG
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            // Ask the user to type the first number.
            Console.WriteLine("Coloque primer numero, presione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type the second number.
            Console.WriteLine("Coloque segundo numero, presione enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("\t1 - Suma");
            Console.WriteLine("\t2 - Resta");
            Console.WriteLine("\t3 - Multiplicacion");
            Console.WriteLine("\t4 - Division");
            Console.Write("El resultado es? ");

            // Use a switch statement to do the math.
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"El resultado es: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "2":
                    Console.WriteLine($" El resultado es: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "3":
                    Console.WriteLine($"El resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "4":
                    Console.WriteLine($"El resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Oprima el boton enter para salir");
            Console.ReadKey();

        }
    }
}
