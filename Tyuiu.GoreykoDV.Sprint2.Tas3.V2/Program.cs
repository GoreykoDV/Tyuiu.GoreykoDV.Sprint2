using Tyuiu.GoreykoDV.Sprint2.Task3.V2.Lib;

namespace Tyuiu.GoreykoDV.Sprint2.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Горейко Д.В. | РППб-26-1";

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Оператор if – полная и короткая форма записи                             *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Горейко Дарья Владимировна | РППб-26-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу вычисляет требуемое                                   *");
            Console.WriteLine("* значение функции Y с использованием вложенных оператор if-else           *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры               *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите значение переменой х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
                       
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            
            Console.WriteLine("Значение функции = " + res);
           
            Console.ReadKey();
        }
    }
}
