using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebuggingWork0202.SecondTask_Konc;
using DebuggingWork0202.SecondTask_SB;
using static System.Net.Mime.MediaTypeNames;
using DebuggingWork0202.SecondTask_OT;

namespace DebuggingWork0202.SecondTask_WDS
{
    internal class WorkDubugString
    {
        public void WorkDS()
        {
            Console.Write("Как вы хотите сгенерировать строку?\n" +
                "1 - Конкатенация\n" +
                "2 - StringBuilder\n" +
                "3 - Конкатенация (сложная строка)\n" +
                "4 - StringBuilder (сложная строка)\n" +
                "5 - Таблица производительности (плохо оптимизировано, грузит 1 минуту)\n" +
                "Ваш выбор: ");
            int button = Convert.ToInt32(Console.ReadLine());
            if (button == 1)
            {
                Konc konc = new Konc();
                Console.Write("Введите количество повторений: ");
                int count = Convert.ToInt32(Console.ReadLine());
                string s = konc.konc(count); 
                Console.WriteLine(s);
            }
            else if (button == 2)
            {
                StringBuild stringBuild = new StringBuild();
                Console.Write("Введите количество повторений: ");
                int count = Convert.ToInt32(Console.ReadLine());
                string s = stringBuild.StringB(count);
                Console.WriteLine(s);
            }
            else if (button == 3)
            {
                Konc konc = new Konc();
                Console.Write("Введите количество повторений: ");
                int count = Convert.ToInt32(Console.ReadLine());
                string s = konc.hardkonc(count);
                Console.WriteLine(s);
            }
            else if (button == 4)
            {
                StringBuild stringBuild = new StringBuild();
                Console.Write("Введите количество повторений: ");
                int count = Convert.ToInt32(Console.ReadLine());
                string s = stringBuild.StringBHard(count);
                Console.WriteLine(s);
            }
            else if (button == 5)
            {
                OptimisationTable optimisationTable = new OptimisationTable();
                optimisationTable.OptTabl();
            }
            else
            {
                Console.WriteLine("Что-то пошло не так (возможно вы написали не ту цифру)");
            }
        }
    }
}
