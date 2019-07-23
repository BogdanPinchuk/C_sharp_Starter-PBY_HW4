using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Слова про погоду http://www.weekenglish.ru/english-cards/weather/
            // також це можна реалізувати за допомогою колекцій Dictionary<T, V>

            // Підключення української мови
            Console.OutputEncoding = Encoding.Unicode;

            // Заголовок
            Console.WriteLine("Міні-словник \"ru-en\" про погоду\n");

            // Введення слова
            Console.WriteLine("Введіть слово про погоду на російській мові:\n");
            Console.Write("\t");
            string word = Console.ReadLine().ToLower();

            // Ідентифікатор для перекладу
            string tWord = default;

#if false
            // Перекладення слів
            switch (word)
            {
                case "погода":
                    tWord = "weather";
                    break;
                case "солнечный":
                    tWord = "sunny";
                    break;
                case "дождь":
                    tWord = "rain";
                    break;
                case "холод":
                    tWord = "cold";
                    break;
                case "ветер":
                    tWord = "wind";
                    break;
                case "жара":
                    tWord = "heat";
                    break;
                case "лёгкий туман":
                    tWord = "mist";
                    break;
                case "туман":
                    tWord = "fog";
                    break;
                case "снег":
                    tWord = "snow";
                    break;
                case "прохладный":
                    tWord = "cool";
                    break;
                case "ливень":
                    tWord = "shower";
                    break;
                case "молния":
                    tWord = "lightning";
                    break;
                case "лёгкий ветерок":
                    tWord = "breeze";
                    break;
                default:
                    tWord = "Этого слова нет в базе данных этого словаря,\n" +
                        "или в слове допущена ошибка.";
                    break;
            }
#endif

#if true
            // Створення колекції словника
            Dictionary<string, string> ru_en = new Dictionary<string, string>();
            // найпростіше внесення даних, не оптимальне
            ru_en.Add("погода", "weather");
            ru_en.Add("солнечный", "sunny");
            ru_en.Add("дождь", "rain");
            ru_en.Add("холод", "cold");
            ru_en.Add("ветер", "wind");
            ru_en.Add("жара", "heat");
            ru_en.Add("лёгкий туман", "mist");
            ru_en.Add("туман", "fog");
            ru_en.Add("снег", "snow");
            ru_en.Add("прохладный", "cool");
            ru_en.Add("ливень", "shower");
            ru_en.Add("молния", "lightning");
            ru_en.Add("лёгкий ветерок", "breeze");

            // Знаходження слова в словнику KeyNotFoundException
            try // перевірка на виключення
            {
                tWord = ru_en[word];
            }
            catch // виконання в разі помилки
            {
                tWord = "Этого слова нет в базе данных этого словаря,\n" +
                        "или в слове допущена ошибка.";
            }
#endif

            // Переклад слова
            Console.WriteLine($"\nПереклад: {tWord}\n");

            // Повторення
            Console.WriteLine("Ви хочете перекласти ще одне слово: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey();

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n"))
            {
                Console.Clear();
                Main();
            }
        }
    }
}
