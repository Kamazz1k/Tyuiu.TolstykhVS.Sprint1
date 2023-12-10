using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolstykhVS.Sprint1.Task3.V6.Lib;

namespace Tyuiu.TolstykhVS.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Толстых В.С. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");   
            Console.WriteLine("* Тема: Написать программу,  вычисления стоимости поездки**               *");
            Console.WriteLine("* на автомобиле на дачу (туда и обратно)*************************         *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Толстых Вячеслав Сергеевич | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            double a = 67; double b = 8.5; double c = 6.5;
            Console.WriteLine("Расстояние до дачи (км) -> 67" + a); 
            Console.WriteLine("Расход бензина (литров на 100 км пробега) -> 8.5" + b);
            Console.WriteLine("Цена литра бензина (руб.) -> 6.5" + c);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("количество бензина, которое потребляет автомобиль на 100 км пробега        ");
            Console.WriteLine("цена одного литра бензина 6.4 и расстояние до дачи (67км)                    ");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" стоимости поездки на автомобиле на дачу (туда и обратно)" + ds.TravelCost(a, b, c));
            Console.ReadKey();
        }
    }
}  
