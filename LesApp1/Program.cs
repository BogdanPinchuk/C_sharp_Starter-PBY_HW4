using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // створення випадкових змінних в відповідному діапазоні
            Random rnd = new Random();

            // Індентифікатори для зміннихб так як не вказано якы змінні брати візьмемо випадкові
            double operand1 = rnd.NextDouble(),
                operand2 = rnd.NextDouble(),
                res = default;    // результат розрахунку

            // успішність розрахунку
            bool sucssuccess = true;

            // Виведення чисел
            Console.WriteLine("Згенеровані випадкові числа:");
            Console.WriteLine($"\ta = {operand1:N}");
            Console.WriteLine($"\tb = {operand2:N}\n");

            // Введення арифметичної операції
            Console.WriteLine("Введіть арифметичну операцію: [+, -, *, /, %]\n");
            Console.Write("\t");

            // Зчитування введеноъ операції
            //string sign = Console.ReadLine();
            string sign = Console.ReadKey().KeyChar.ToString();

            switch (sign)
            {
                case "+":
                    res = operand1 + operand2;
                    break;
                case "-":
                    res = operand1 - operand2;
                    break;
                case "*":
                    res = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        // немає успішного виконання
                        sucssuccess = false;
                        // виведення повыдомлення про помилку
                        Console.WriteLine("\n\nНедопустиме ділення на 0 в даній версії програми!\n" +
                            "Але з математичноъ точки зору, ви б отримали + або - безкінечність.\n");
                    }
                    else
                    {
                        res = operand1 / operand2;
                    }
                    break;
                case "%":
                    if (operand2 == 0)
                    {
                        // немає успішного виконання
                        sucssuccess = false;
                        // виведення повыдомлення про помилку
                        Console.WriteLine("\n\nНедопустиме ділення на 0 (при розрахунку залишку) в даній версії програми!\n");
                    }
                    else
                    {
                        res = operand1 % operand2;
                    }
                    break;
                default:
                    // немає успішного виконання
                    sucssuccess = false;
                    // виведення повыдомлення про помилку
                    Console.WriteLine("\nПомилка введення арифметичної дії!\n");
                    break;
            }

            // виведення результату в консоль
            if (sucssuccess)
            {
                Console.WriteLine($"\n\n\t{operand1:N} {sign} {operand2:N} = {res:N}");
            }

            // Повторення
            Console.WriteLine("\nЗробити ще одну арифметитчну дію: [т, н]");
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
