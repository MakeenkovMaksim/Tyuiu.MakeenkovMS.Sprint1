using Tyuiu.MakeenkovMS.Sprint1.Task3.V12.Lib;

namespace Tyuiu.MakeenkovMS.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Макеенков М. С. | ПИНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Макеенков Максим Сергеевич | ПИНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника   *");
            Console.WriteLine("* по длинам двух катетов. Ответ округлите до 3 знаков после запятой.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите длину первого катета: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второго катета: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.TriangleArea(a, b);

            Console.WriteLine("Площадь прямоугольного треугольника равна: " + res);
            Console.ReadKey();
        }
    }
}
