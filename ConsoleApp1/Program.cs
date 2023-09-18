using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите какое действие вы хотите выполнить:");
            Console.WriteLine("1.Сложить два числа");
            Console.WriteLine("2.Вычесть первое число из второго");
            Console.WriteLine("3.Умножить первое число на второе");
            Console.WriteLine("4.Разделить первое число на второе");
            Console.WriteLine("5.Возвести в степень N первое число");
            Console.WriteLine("6.Найти квадратный корень числа");
            Console.WriteLine("7.Найти 1 процент из числа");
            Console.WriteLine("8.Найти факториал из числа");
            Console.WriteLine("9.Выйти из программы");

            int x = int.Parse(Console.ReadLine());
            do
            {

                if (x == 1)
                {
                    Console.WriteLine("Введите первое число");
                    string pervoe = Console.ReadLine();
                    int pervoecheslo = Convert.ToInt32(pervoe);
                    Console.WriteLine("Введите второе число");
                    string vtroe = Console.ReadLine();
                    int vtoroecheslo = Convert.ToInt32(vtroe);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(pervoecheslo + vtoroecheslo);
                    Console.WriteLine("Введите номер действия ещё раз");
                    int x = int.Parse(Console.ReadLine());
                }

                else if (x == 2)
                {
                    Console.WriteLine("Введите первое число");
                    string pervoe = Console.ReadLine();
                    int pervoecheslo = Convert.ToInt32(pervoe);
                    Console.WriteLine("Введите второе число");
                    string vtroe = Console.ReadLine();
                    int vtoroecheslo = Convert.ToInt32(vtroe);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(pervoecheslo - vtoroecheslo);
                    Console.WriteLine("Введите номер действия ещё раз");
                    int x = int.Parse(Console.ReadLine());
                }

                else if (x == 3)
                {
                    Console.WriteLine("Введите первое число");
                    string pervoe = Console.ReadLine();
                    int pervoecheslo = Convert.ToInt32(pervoe);
                    Console.WriteLine("Введите второе число");
                    string vtroe = Console.ReadLine();
                    int vtoroecheslo = Convert.ToInt32(vtroe);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(pervoecheslo * vtoroecheslo);
                    Console.WriteLine("Введите номер действия ещё раз");
                }
                else if (x == 4)
                {
                    Console.WriteLine("Введите первое число");
                    string pervoe = Console.ReadLine();
                    int pervoecheslo = Convert.ToInt32(pervoe);
                    Console.WriteLine("Введите второе число");
                    string vtroe = Console.ReadLine();
                    int vtoroecheslo = Convert.ToInt32(vtroe);
                    Console.WriteLine("Результат:");
                    Console.WriteLine(pervoecheslo / vtoroecheslo);
                    Console.WriteLine("Введите номер действия ещё раз");
                }
            } while (x != 9);
        }
    }
}
