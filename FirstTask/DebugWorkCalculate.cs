using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebuggingWork0202_OpCalc;

namespace DebuggingWork0202_DebWork
{
    internal class DebugWorkCalculate
    {

        public void WorkDebug()
        {
            Console.WriteLine("Вас приветствует калькулятор. Текущие функции:\n+ (сложение)\n- (вычитание)\n* (умножение)\n/ (деление)");
            Console.Write("Первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Оператор: ");
            string s = Console.ReadLine();
            Console.Write("Второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            OperationsCalculate operationsCalculate = new OperationsCalculate();
            double c = operationsCalculate.Operations(s, b, a);
            Console.WriteLine(c);




            //string sAB = Console.ReadLine();
            //bool trfl = double.TryParse(sAB, out double a);
            //if (trfl == true)
            //{
            //    Console.Write("Оператор: ");
            //    string s = Console.ReadLine();
            //    Console.Write("Второе число: ");
            //    sAB = Console.ReadLine();
            //    trfl = double.TryParse(sAB, out double b);
            //    if (trfl == true)
            //    {
            //       OperationsCalculate operationsCalculate = new OperationsCalculate();
            //       double c = operationsCalculate.Operations(s,a,b);
            //        if (c < double.MaxValue)
            //        {
            //            Console.WriteLine($"Финальный результат: {c}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Что-то пошло не так (возможно введены буквы вместо чисел)");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Что-то пошло не так (возможно введены буквы вместо чисел)");
            //}
        }
    }
}
