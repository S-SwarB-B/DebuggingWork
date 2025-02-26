using DebuggingWork0202_DebWork;
using DebuggingWork0202.SecondTask_WDS;

namespace DebugNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите режим\n" +
                          "1 - Калькулятор\n" +
                          "2 - Заполнение строк\n" +
                          "Ваш выбор: ");
            int button = Convert.ToInt32(Console.ReadLine());
            if (button == 1)
            {
                DebugWorkCalculate debugWorkCalculate = new DebugWorkCalculate();
                debugWorkCalculate.WorkDebug();
            }
            else if (button == 2) 
            { 
                WorkDubugString workDubugString = new WorkDubugString();
                workDubugString.WorkDS();
            }
            else
            {
                Console.WriteLine("Что-то пошло не так (возможно вы написали не ту цифру)");
            }
        } 
    }
}