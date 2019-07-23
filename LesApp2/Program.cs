using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Введення числа
            Console.WriteLine("Введіть число:\n");
            Console.Write("\t");
            double a = double.Parse(Console.ReadLine().Replace(".", ","));

            // запис діапазону
            string range = default;

            // перевірка попадання в діапазон
            if ((0 <= a) && (a <= 14))
            {
                range = "[0 - 14]";
            }
            else if ((15 <= a) && (a <= 35))
            {
                range = "[15 - 35]";
            }
            else if ((36 <= a) && (a <= 50))
            {
                range = "[36 - 50]";
            }
            else if ((51 <= a) && (a <= 100))
            {
                range = "[51 - 100]";
            }
            else
            {
                range = "";
            }

            // виведення результатів
            if (range != "")
            {
                Console.WriteLine("\nВи попали в діапазон: " +
                    range + ". \n");
            }
            else
            {
                Console.WriteLine("\nВи не попали ні в один із діапазонів.");
            }

            // Повторення
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey();

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
        }
    }
}
