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
        static void Main(string[] args)

        {
            bool isContinueWork = true;
            while (isContinueWork)
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
            Console.WriteLine(" 0 - Вийти з програми");
           
          
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
                            {"Вiвторок:", "Англiйська та айтiшка"},
                            {"Середа:", "айтiшка та заняття з ментором" },
                            {"Четвер:", "Англiйcька та кетасушi" },
                            {"П'ятниця:", "Кетасушi" },
                            {"Суббота:", "кетасушi" },
                            {"Недiля:", "Вiдпочинок та айтiшка" } };
                        Console.WriteLine("Розклад занять на тиждень:");
                        foreach(string succes in schedule)
                        {
                            Console.WriteLine(succes);
                        }
                        break;
                    case 8:
                        List<string> cart = new List<string> { "Банан", "Кiвi", "Ананасовий сiк", "Шпинат" };
                        Console.WriteLine("Вмiст кошика:");
                        foreach (string item in cart)
                        {
                            Console.WriteLine("-" + item);
                        }
                        break;
                    case 9:
                        Dictionary<string, string> phoneBook = new Dictionary<string, string>()
                        {
                        {"Антон:","380509521905"},
                        {"Мiша:","380684207236"},
                        {"Марина:","380978193567"},
                        {"Даша:","380955482582"},
                        {"Сергiй:","380635337296"}};
                        Console.WriteLine("Телефонна книга:");
                        foreach (var list in phoneBook)
                        {
                            Console.WriteLine(list);
                        }

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
