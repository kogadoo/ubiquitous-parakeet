using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Выберите какую операцию вы хотите выполнить:");
            Console.WriteLine("1.Сложить два числа");
            Console.WriteLine("2.Вычесть первое из второго");
            Console.WriteLine("3.Перемножить два числа");
            Console.WriteLine("4.Разделить первое на второе");
            Console.WriteLine("5.Возвести в степень N первое число");
            Console.WriteLine("6.Найти квадратный корень из первого числа");
            Console.WriteLine("7.Найти один процент от первого числа");
            Console.WriteLine("8.Найти факториал числа");
            Console.WriteLine("9.Выйти из программы");
            string action = Console.ReadLine();
            do
            {
                double result;
                if (action == "1")
                {
                    Console.WriteLine("Введите первое число");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = double.Parse(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "2")
                {
                    Console.WriteLine("Введите первое число");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = double.Parse(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "3")
                {
                    Console.WriteLine("Введите первое число");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = double.Parse(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "4")
                {
                    Console.WriteLine("Введите первое число");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double num2 = double.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!");
                        Console.WriteLine();
                        Console.WriteLine("Введите операцию еще раз");
                        action = Console.ReadLine();
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine("Результат: " + result);
                        Console.WriteLine();
                        Console.WriteLine("Введите операцию еще раз");
                        action = Console.ReadLine();
                    }
                }
                else if (action == "5")
                {
                    Console.WriteLine("Введите число");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите степень, в которое нужно возвести число");
                    double num2 = double.Parse(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "6")
                {
                    Console.WriteLine("Введите число");
                    double num1 = double.Parse(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "7")
                {
                    Console.WriteLine("Введите число");
                    double num1 = double.Parse(Console.ReadLine());
                    result = Math.Sqrt(num1 / 100);
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
                else if (action == "8")
                {
                    Console.WriteLine("Введите число");
                    double num1 = double.Parse(Console.ReadLine());
                    double x;
                    result = 1;
                    for (x = 1; x <= num1; x++)
                    {
                        result = result * x;
                    }
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine();
                    Console.WriteLine("Введите операцию еще раз");
                    action = Console.ReadLine();
                }
            } while (action != "9");
        }
    }
}
