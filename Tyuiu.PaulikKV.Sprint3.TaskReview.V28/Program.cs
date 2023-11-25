using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint3.TaskReview.V28.Lib;

namespace Tyuiu.PaulikKV.Sprint3.TaskReview.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Паулик К.В. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: TaskReview                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Паулик Кирилл Владимирович | АСОиУб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Написать программу, которая выводит таблицу значений функции   *");
            Console.WriteLine("* f(x)= cos(2x) + (sin(x)/x+2.5) +2x на заданном диапазоне [-5;5]     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine(" Начало отрезка = " + startValue);
            Console.WriteLine(" Конец отрезка = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     X     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,5:f2}    |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
            Console.ReadKey();
        }
    }
}
