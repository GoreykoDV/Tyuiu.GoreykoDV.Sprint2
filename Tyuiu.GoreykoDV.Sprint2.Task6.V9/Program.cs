using Tyuiu.GoreykoDV.Sprint2.Task6.V9.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Получение результата из switch                                           *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, сокращенную форму записи оператора switch            *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                               *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами:          *");
            Console.WriteLine("* m (порядковый номер месяца) и n (число).                                 *");
            Console.WriteLine("* По заданным n и m определить дату следующего дня                         *");
            Console.WriteLine("* (принять, что n и m не характеризуют 31 декабря).                        *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите день: ");
            int n = Convert.ToInt32(Console.ReadLine());


            string res = ds.FindDateOfNextDay(m, n);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");


            Console.WriteLine("Дата следующего дня: " + res);

            Console.ReadKey();
        }
    }
}
