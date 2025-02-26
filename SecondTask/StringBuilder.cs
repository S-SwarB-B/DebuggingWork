using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingWork0202.SecondTask_SB
{
    internal class StringBuild
    {
        public string StringB(int count) 
        {
            string s = "";
            for (int i = 0; i < count; i++)
            {
                StringBuilder sb = new StringBuilder($"Iteration: {i}");
                s += sb.ToString();
            }
            return s;
        }
        public string StringBHard(int count)
        {
            string s = "";
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int a = rnd.Next(-100000, 100000);
                int b = rnd.Next('a', 'z');
                char c = (char)b;
                StringBuilder sb = new StringBuilder($"Iteration: {i}, RandomNumber: {a}, RandomChar: {c}\n");
                s += sb.ToString();
            }
            return s;
        }
    }
}
