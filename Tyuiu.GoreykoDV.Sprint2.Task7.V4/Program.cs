using Tyuiu.GoreykoDV.Sprint2.Task7.V4.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Спринт #2 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* добавление к решению итоговых проектов по спринту                        *");
            Console.WriteLine("* Задание #7                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные            *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X,Y                       *");
            Console.WriteLine("* в заштрихованной области.                                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение переменой x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменой y: ");
            double y = Convert.ToDouble(Console.ReadLine());

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
