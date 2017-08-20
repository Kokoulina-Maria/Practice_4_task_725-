using System;


namespace Practice_4_task_725ж
{
    class Program
    {
        static double f(double x)
        //функция для подсчета функции x^4-4.1*x^3+x^2-5.1*x+4.1
        {
            return x * x * x * x - 4.1 * x * x * x + x * x - 5.1 * x + 4.1;
        }

        static void Main(string[] args)
        {
            const double x = 4.1;//настоящий ответ для определения погрешности
            Console.WriteLine("Решение уравнения x^4-4.1*x^3+x^2-5.1*x+4.1=0 на отрезке [3.7, 5] с заданной абсолютной погрешностью");
            do
            {
                double left = 3.7;//левый край границы отрезка
                double right = 5;//правый край границы отрезка
                double xNew;//искомое число, полученное решение
                Console.WriteLine();

                double e; bool ok;// переменная для проверки
                do//начало проверки
                {
                    Console.Write("Введите абсолютную погрешность с точностью не более 16 знаков после запятой (Для получения более точного результата погрешность должна быть не более 0,25): ");
                    ok = double.TryParse(Console.ReadLine(), out e);
                    if (!ok) Console.WriteLine("Неверный ввод!");
                } while (!ok);// конец проверки

                do//начинаем вычислять xNew
                {
                    xNew = left + (right - left) / 2;//находим середину нового отрезка
                    if (f(xNew)*f(left) < 0) right = xNew;//если полученное решение правее(больше) ответа, то полученное решение становится правым краем
                    else left = xNew;//если полученное прешение левее (меньше) ответа, то полученное решение становится левым краем               
                } while (Math.Abs(Math.Round(x - xNew, 14)) > e);//пока разница между настоящим и полученным решением не станет меньше или равна e

                Console.WriteLine("Полученное решение: " + xNew);
                Console.ReadLine();
            } while (true);
        }
    }
}
