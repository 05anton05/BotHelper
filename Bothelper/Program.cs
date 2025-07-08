using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bothelper
{
    class Program
    {
        static int CountVowels(string text, int index = 0)
        {
            const string letters = "яюєіїaeiouАЕЄИІЇОУЫЭЮЯаеєиіїоуыэюя";
            int counter = 0;

            if (index == text.Length)
            {
                return counter;
            }

            if (letters.Contains(text[index]))
            {
                counter += 1;
            }

            return counter + CountVowels(text, index + 1);
        }
        
        static (string longest, string shortest) FindLongestAndShortest(string[] words)
        {
            if (words == null || words.Length == 0)
                throw new ArgumentException("Масив слів не може бути порожнім або null.");

            string longest = words[0];
            string shortest = words[0];

            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
                else 
                {
                    shortest = word;
                }
            }

            return (longest, shortest);
        }
        static List<int> FindTask(List<string> tasks, string name)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == name)
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }
        static List<int> FindTask(List<string> tasks, string name, bool partialMatch)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < tasks.Count; i++)
            {
                string taskLower = tasks[i].ToLower();
                string nameLower = name.ToLower();

                bool isMatch = partialMatch && taskLower.Contains(nameLower);

                if (isMatch)
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }
        static int[] CalculateSumAndProduct(int[] numbers, out int sum, out int product)
        {
           
           
            sum = 0;
            product = 1;
            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }
            return numbers;

        }
        static string[] BuildSentece(params string[] words)
        {
            Console.WriteLine("введiть цифру кiлькостi слiв");
            int input = int.Parse (Console.ReadLine());
            string[] word = new string[input];

            for (int j = 0; j < input; j++)
            {
                Console.Write($"Введiть слово {j + 1}: ");
                 word [j] = Console.ReadLine();
            }
            foreach (string sentece in word)
            {
                Console.Write(sentece + " ");
            }
            return words;
        }
        static void PrintMenu()
        {
             Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(Environment.NewLine + " Вітаю, я бот-помічник! Обери команду:");
            Console.WriteLine(" 1 - Перевірити число на парність");
            Console.WriteLine(" 2 - Таблиця множення числа");
            Console.WriteLine(" 3 - Порахувати суму чисел");
            Console.WriteLine(" 4 - Вивести моє ім’я задом наперед");
            Console.WriteLine(" 5 - Знайти число в массивi");
            Console.WriteLine(" 6 - Показати температуру на недiлю вперед");
            Console.WriteLine(" 7 - Розклад занять для нового життя");
            Console.WriteLine(" 8 - Отримати вмiст кошику смачного мiлкшейку");
            Console.WriteLine(" 9 - Отримати телефонну книгу топових людей");
            Console.WriteLine("10 - Створити речення");
            Console.WriteLine("11 - Порахувати сумму та добуток массива чисел");
            Console.WriteLine("12 - Вигадати задачу за назвою та отримати iндекс: ");
            Console.WriteLine("13 - Знайти iндекс задачi: ");
            Console.WriteLine("14 - Знайти найдовше та найкоротше слово в списку: ");
            Console.WriteLine("15 - Показати кiлькiсть голосних букв веденному словi:");
            Console.WriteLine(" 0 - Вийти з програми");
                     
        }
        static void Main(string[] args)

        {
           bool isContinueWork = true;
            while (isContinueWork)
            {

                PrintMenu();
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Пропишiть число:");
                        int firstNumber = int.Parse(Console.ReadLine());
                        if (firstNumber % 2 == 0)
                        {
                            Console.WriteLine(firstNumber + " - Число парне!");
                        }
                        else
                        {
                            Console.WriteLine(firstNumber + " - Число непарне!");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Пропишiть число:");
                        int secondNumber = int.Parse(Console.ReadLine());
                        for (int a = 1; a < 11; a++)
                        {
                            int result = secondNumber * a;
                            Console.WriteLine($"{secondNumber} x {a} = {result} ");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Введiть будь-яке число:");
                        int thirdNumber = int.Parse(Console.ReadLine());
                        int startNumber = 0;
                        for (int b = 1; b <= thirdNumber; b++)
                        {
                            startNumber = startNumber + b;
                        }
                        Console.WriteLine("cумма чисел вiд 1 до " + thirdNumber + " = " + startNumber);

                        break;
                    case 4:
                        Console.Write("Ввeдiть iм'я: ");
                        string userName = Console.ReadLine();

                        foreach (char four in userName.Reverse())
                        {
                            Console.Write(four);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        int[] array5 = { -20, -10, 0, 10, 20, 30, 40, 50, 60 };
                        Console.Write(" массив чисел: ");
                        for (int i = 0; i < array5.Length; i++)
                        {
                            Console.Write(" " + array5[i] + ";");
                        }

                        Console.WriteLine("\n пропишить число, яке хочете знайти в массивi: ");
                        int number = int.Parse(Console.ReadLine());
                        int leftSide = 0;
                        int rightSide = array5.Length - 1;
                        while (leftSide <= rightSide)
                        {
                            int center = (leftSide + rightSide) / 2;
                            if (array5[center] == number)
                            {
                                Console.WriteLine("Iндекс числа " + number + " в массивi: " + center);
                                break;
                            }
                            else if (array5[center] < number)
                            {
                                leftSide = center + 1;
                            }
                            else
                            {
                                rightSide = center - 1;
                            }
                        }
                        if (leftSide > rightSide)
                        {
                            Console.WriteLine("Число " + number + " не знайдено в массивi.");
                        }
                        else
                        {
                            Console.WriteLine("Число " + number + " знайдено в массивi.");
                        }
                        break;
                    case 6:
                        double[] temps = { 29.5, 31, 30.5, 33.5, 30 };
                        string[] DayOfWeek = { "Понеділок:", "Вівторок:", "Середа:", "Четвер:", "П'ятниця:" };
                        Console.WriteLine("Температура на тиждень вперед:");
                        for (int i = 0; i < temps.Length; i++)
                        {
                            Console.WriteLine($"{DayOfWeek[i]}" + $" {temps[i]}" + "°C");
                        }
                        break;
                    case 7:
                        string[,] schedule = {
                            {"Понедiлок:", "Кетасушi"},
                            {"Вiвторок:",  "Англiйська та айтiшка"},
                            {"Середа:",    "айтiшка та заняття з ментором" },
                            {"Четвер:",    "Англiйcька та кетасушi" },
                            {"П'ятниця:",  "Кетасушi" },
                            {"Суббота:",   "кетасушi" },
                            {"Недiля:",    "Вiдпочинок та айтiшка" } };
                        Console.WriteLine("Розклад занять на тиждень:");
                        foreach (string succes in schedule)
                        {
                            Console.WriteLine((succes));
                        }
                        break;
                    case 8:
                        List<string> cart = new List<string>();
                        cart.Add("Банан");
                        cart.Add("Кiвi");
                        cart.Add("Ананасовий сiк");
                        cart.Add("Шпинат");
                        Console.WriteLine("Вмiст кошика:");
                        foreach (string item in cart)
                        {
                            Console.WriteLine("-" + item);
                        }
                        break;
                    case 9:
                        Dictionary<string, string> phoneBook = new Dictionary<string, string>()
                        {
                        {"Антон:","380503333333"},
                        {"Мiша:","380682222222"},
                        {"Марина:","380971111111"},
                        {"Даша:","3809554*2582"},
                        {"Сергiй:","380635*37296"}};
                        Console.WriteLine("Телефонна книга:");
                        foreach (var list in phoneBook)
                        {
                            Console.WriteLine(list);
                        }

                        break;
                    case 10:
                        BuildSentece();
                        break;
                    case 11:
                        Console.WriteLine("Пропишiть кiлькiсть елементiв  числового массиву: ");
                        int element = int.Parse(Console.ReadLine());
                        var numbers = new int[element];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.WriteLine($"Введiть число{i + 1}:");
                            numbers[i] = int.Parse(Console.ReadLine());
                        }

                        CalculateSumAndProduct(numbers, out int sum, out int product);

                        Console.WriteLine($"Сума чисел: {sum}, Добуток чисел: {product}");

                        break;
                    case 12:
                        List<string> firstTasks = new List<string>();
                        firstTasks.Add("Виконати домашнє завдання по с#");
                        firstTasks.Add("Займатись з реппетитором по англiйськiй мові");
                        firstTasks.Add("Пiти в тренажерний зал");
                        firstTasks.Add("Помити автомобiль Volkswagen golf 1.9 турбодизель");
                        firstTasks.Add("Вивчити новий матерiал по c# з ментором");

                        Console.WriteLine("Ключовi cлова: (Виконати); (Займатись); (Пiти); (Помити); (Вивчити)");

                        Console.WriteLine("Введiть ключове слово та отримайте задачу: ");
                        string answer = Console.ReadLine();
                        List<int> foundIndex = FindTask(firstTasks, answer, partialMatch: true);
                        if (foundIndex.Count > 0)
                        {
                            Console.WriteLine("Знайденi задачi:");
                            foreach (int index in foundIndex)
                            {
                                Console.WriteLine($"{index}: {firstTasks[index]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Задачу не зайдено");
                        }
                
                        break;
                    case 13:
                        List<string> secondTask = new List<string>();
                        secondTask.Add("Поприбирати в квартирi");
                        secondTask.Add("Зателефонувати матусi");
                        secondTask.Add("Приготувати коктейль");
                        secondTask.Add("Вiдпочивати");
                        foreach (string task in secondTask)
                        {
                            Console.WriteLine(task);
                        }
                        Console.WriteLine("Введи назву задачi для пошуку:");
                        string nameToFind = Console.ReadLine();
                        List<int> foundElement = FindTask(secondTask, nameToFind);

                        Console.WriteLine("Iндекс задачi: ");
                        foreach (int index in foundElement)
                        {
                            Console.WriteLine(index);
                        }

                        break;
                    case 14:
                        Console.WriteLine("Введiть цифру, яка буде дорiвнювати кiлькостi cлiв:");
                        int quantity = int.Parse(Console.ReadLine());
                        string[] words = new string[quantity];
                        Console.WriteLine(" Введiть словo:");
                        for (int i = 0; i < words.Length; i++)
                        {
                            words[i] = Console.ReadLine();

                        }

                        var resultOfSearching = FindLongestAndShortest(words);
                        Console.WriteLine($"Найдовше слово: {resultOfSearching.longest}");
                        Console.WriteLine($"Найкоротше слово: {resultOfSearching.shortest}");
                        break;
                    case 15:
                        Console.WriteLine("Введiть слово:");
                        string inputWord = Console.ReadLine();
                       
                        int vowelCount = CountVowels(inputWord);
                        Console.WriteLine($"Кількість голосних: {vowelCount}");


                        break;
                    case 0:
                        Console.WriteLine("Програму завершено, дякую за користування!");
                        isContinueWork = false;
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                if (userChoice != 0)
                {
                    Console.WriteLine("\nНатисни будь-яку клавішу, щоб повернутися до головного меню...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Програму завершено, дякую за користування!");
                    isContinueWork = false;
                    Console.Clear();
                }
                


            }
            
            

        }
        




    }
}
