using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_task_725ж
{
    class Program
    {
        static void Main(string[] args)
        {
            const double x = 4.1;//настоящий ответ для определения погрешности
            Console.WriteLine("Решение уравнения x^4-4.1*x^3+x^2-5.1*x+4.1=0 на отрезке [3.7, 5] с заданной абсолютной погрешностью");
            Console.WriteLine();
            double left = 3.7;//левый край границы отрезка
            double right = 5;//правый край границы отрезка
            double xNew = left + (right - left) / 2;//искомое число
            Double e; bool ok;// переменная для проверки
            do
            {
                Console.Write("Введите абсолютную погрешность с точностью не более 16 знаков после запятой (Для получения более точного результата погрешность должна быть не более "+(Math.Abs(x-xNew))+"): ");
                ok = Double.TryParse(Console.ReadLine(), out e);
                if (!ok) Console.WriteLine("Неверный ввод!");
            } while (!ok);// конец проверки

            //While ()
        }
    }
}
