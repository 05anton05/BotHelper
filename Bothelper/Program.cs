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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(Environment.NewLine + " Вітаю, я бот-помічник! Обери команду:");
            Console.WriteLine(" 1 - Перевірити число на парність");
            Console.WriteLine(" 2 - Таблиця множення числа");
            Console.WriteLine(" 3 - Порахувати суму чисел");
            Console.WriteLine(" 4 - Вивести моє ім’я задом наперед");
            Console.WriteLine(" 0 - Вийти з програми");
           
          
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Пропишiть число:");
                        int numberOne = int.Parse(Console.ReadLine());
                        if (numberOne % 2 == 0)
                        {
                            Console.WriteLine(numberOne + " - Число парне!");
                        }
                        else
                        {
                            Console.WriteLine(numberOne + " - Число непарне!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Пропишiть число:");
                        int numberTwo = int.Parse(Console.ReadLine());
                        for (int two = 1; two < 11; two++)
                        {
                            int result = numberTwo * two;
                            Console.WriteLine($"{numberTwo} x {two} = {result} ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введiть будь-яке число:");
                        int numberThree = int.Parse(Console.ReadLine());
                        int startNumber = 0;
                        for (int three = 1; three <= numberThree; three++)
                        {
                            startNumber = startNumber + three;
                        }
                        Console.WriteLine("cумма чисел вiд 1 до " + numberThree + " = " + startNumber);
                        break;
                    case 4:
                        Console.Write("Ввeдiть iм'я: ");
                        string numberFour = Console.ReadLine();

                        foreach (char four in numberFour.Reverse())
                        {
                            Console.Write(four);
                        }

                        Console.WriteLine();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                    default:

                        break;
                 


            }

        }
    }
}
