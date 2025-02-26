using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingWork0202.SecondTask_Konc
{
    internal class Konc
    {
        public string konc(int count) 
        {
            string s = "";
            for (int i = 0; i < count; i++)
            { 
                s += $"Iteration: {i}";
            }
            return s;
        }

        public string hardkonc(int count)
        {
            string s = "";
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int a = rnd.Next(-100000, 100000);
                int b = rnd.Next('a', 'z');
                char c = (char)b;
                s += $"Iteration: {i}, RandomNumber: {a}, RandomChar: {c}\n";
            }
            return s;
        }
    }
}
