using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DebuggingWork0202_OpCalc
{
    internal class OperationsCalculate
    {
        public double Operations(string s, double a, double b)
        {
            try
            {
                if (s == "/" && b == 0)
                {
                    return (int)a / 0;
                }
                if (s == "+")
                {
                    return a + b;
                }
                else if (s == "-")
                {
                    return a - b;
                }
                else if (s == "*")
                {
                    return a * b;
                }
                else if (s == "/")
                {
                    return a / b;
                }
                else
                {
                    return (int)a / 0;
                }
            }
            catch
            {
                Debug.WriteLine("Второй этап проверки не пройден (деление на ноль или несуществующий оператор)");
                Trace.WriteLine("Второй этап проверки не пройден (деление на ноль или несуществующий оператор)");
                Console.WriteLine("Ошибка. Возможно вы использовали не правильный оператор или этот оператор отсутствует в нашей программе\n" +
                                  "Также есть вероятность, что была произведена попытка деления на 0");
                return double.MaxValue;
            }
        }
    }
}
