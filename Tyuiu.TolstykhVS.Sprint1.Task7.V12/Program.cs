using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint1.Task7.V12.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task7.V12
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Толстых В.С. | СМАРТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Толстых Вячеслав Сергеевич | СМАРТБ-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных вводимых пользователем                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите положительное число x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите положительное число y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат" + Math.Round(ds.Calculate(x,y),3));
            Console.ReadKey();
        }
    }
}
