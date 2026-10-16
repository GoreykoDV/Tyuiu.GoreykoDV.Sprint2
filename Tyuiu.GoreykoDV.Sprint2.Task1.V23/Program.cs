using Tyuiu.GoreykoDV.Sprint2.Task1.V23.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 242;
            int b = 571;
            int c = 325;
            int d = 155;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            Console.Title = "Спринт #2 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Логические операции                                                      *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #23                                                              *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать)              *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^                                *");
            Console.WriteLine("*последовательность операций не должна нарушаться)*                         *");
            Console.WriteLine("*а также арифметических выражений, которая вернет логическую последовательность*");
            Console.WriteLine("* (True, False, True, False, True, False), при a = 242, b = 571, c = 325, d = 155*");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);
            Console.WriteLine("c =" + c);
            Console.WriteLine("d =" + d);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadLine();
        }
    }
}
