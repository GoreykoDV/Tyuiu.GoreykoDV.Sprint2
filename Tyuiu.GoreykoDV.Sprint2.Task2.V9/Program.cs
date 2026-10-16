using Tyuiu.GoreykoDV.Sprint2.Task2.V9.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #2 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Оператор if – полная и короткая форма записи                             *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения                *");
            Console.WriteLine("* с клавиатуры и вычисляет находится ли точка с координатами X,Y           *");
            Console.WriteLine("* в заштрихованной области                                                 *");
            Console.WriteLine("*последовательность операций не должна нарушаться)*                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение переменой х: ");
            int x =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменой y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);
          
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находиться в закрашеной области");
            }
            else
            {
                Console.WriteLine("Точка не находиться в закрашеной области");
            }

            Console.ReadKey();
        }
    }
}
