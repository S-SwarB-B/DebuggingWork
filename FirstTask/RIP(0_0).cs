using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingWork0202.FirstTask_RIP
{
    internal class RIP_0_0_
    {
        public void RIP()
        {
            Console.WriteLine("Ты точно этого хочешь?))\n" +
                "0 - отмена действия (компьютер скажет спасибо)\n" +
                "Любое другое действие - F\n");
            string RIP_PC = Console.ReadLine();
            if (RIP_PC == "0")
            {

            }
            else 
            {
                int i = 1;
                double count = 0;
                string d = "";
                string s = "";
                while (i == 1)
                {
                   s = s + count;
                   count++;
                   s = s + s + s;
                   s = s + s + s;
                   s = s + s + s;
                   d = s + d + s;
                   count = Math.Pow(count, count);
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                   Console.WriteLine($"{s},{d}{s},{d}{s},{d}{s},{d}{s},{d}");
                }
            }
        }
    }
}
