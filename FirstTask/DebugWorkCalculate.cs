using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DebuggingWork0202_OpCalc;

namespace DebuggingWork0202_DebWork
{
    internal class DebugWorkCalculate
    {

        public void WorkDebug()
        {
            FileStream file = new FileStream("TextFileProgrammResult.txt", FileMode.OpenOrCreate);
            TextWriterTraceListener textWriterTraceListener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(textWriterTraceListener);
            Trace.AutoFlush = true;


            Debug.WriteLine("Debug-Start");
            Trace.WriteLine("Trace-Start");
            Console.WriteLine("Вас приветствует калькулятор. Текущие функции:\n+ (сложение)\n- (вычитание)\n* (умножение)\n/ (деление)");
            Console.Write("Первое число: ");

            
            string sAB = Console.ReadLine();
            Debug.WriteLine($"Первое число: {sAB}");
            Trace.WriteLine($"Первое число: {sAB}");
            bool trfl = double.TryParse(sAB, out double a);
            if (trfl == true)
            {
                Console.Write("Оператор: ");
                string s = Console.ReadLine();
                Debug.WriteLine($"Оператор: {s}");
                Trace.WriteLine($"Оператор: {s}");

                Console.Write("Второе число: ");
                sAB = Console.ReadLine();
                Debug.WriteLine($"Второе число: {sAB}");
                Trace.WriteLine($"Второе число: {sAB}");

                trfl = double.TryParse(sAB, out double b);
                if (trfl == true)
                {
                    Debug.WriteLine("Первый этап проверки пройден");
                    Trace.WriteLine("Первый этап проверки пройден");

                    OperationsCalculate operationsCalculate = new OperationsCalculate();
                    double c = operationsCalculate.Operations(s, a, b);
                    if (c < double.MaxValue)
                    {
                        Debug.WriteLine("Второй этап проверки пройден");
                        Trace.WriteLine("Второй этап проверки пройден");

                        Debug.WriteLine($"Результат - {c}");
                        Trace.WriteLine($"Результат - {c}");

                        Console.WriteLine($"Финальный результат: {c}");
                    }
                }
                else
                {    
                    Debug.WriteLine("Первый этап проверки не пройден (возможно введены буквы вместо чисел )");
                    Trace.WriteLine("Первый этап проверки не пройден (возможно введены буквы вместо чисел )");
                    Console.WriteLine("Что-то пошло не так (возможно введены буквы вместо чисел)");
                }
            }
            else
            {
                Debug.WriteLine("Первый этап проверки не пройден (возможно введены буквы вместо чисел )");
                Trace.WriteLine("Первый этап проверки не пройден (возможно введены буквы вместо чисел )");
                Console.WriteLine("Что-то пошло не так (возможно введены буквы вместо чисел)");
            }
        }
    }
}
