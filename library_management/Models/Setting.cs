using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Models
{
    public class Setting
    {
        public static string InputString(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            return input;
        }

        public static void FinishOption()
        {
            string message = "Presione cualquier tecla para volver al menú principal...";
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

        public static int InputInt(string prompt)
        {

            Console.Write(prompt);
            int input;
            while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor entero");
                Console.Write(prompt);
            }
            return input;
        }

        public static double InputDouble(string prompt)
        {
            Console.Write(prompt);

            double input;
            while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor numérico");
                Console.Write(prompt);
            }
            return input;
        }

    }
}