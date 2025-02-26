using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingWork0202.SecondTask_OT
{
    internal class OptimisationTable
    {
        static void konc(int count, ref string s1, ref string s2, ref string s3)
        {
            string s = "";
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            for (int i = 0; i < count; i++)
            {
                s += $"Iteration: {i}";
                if (i == 1000)
                {
                    s1 = Convert.ToString(stopwatch.Elapsed);
                }
                if (i == 10000)
                {
                    s2 = Convert.ToString(stopwatch.Elapsed);
                }
                if (i == 100000)
                {
                    s3 = Convert.ToString(stopwatch.Elapsed);
                }
            }
            stopwatch.Stop();
        }

        static void StringB(int count, ref string s4, ref string s5, ref string s6)
        {
            string s = "";
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                StringBuilder sb = new StringBuilder($"Iteration: {i}");
                s += sb.ToString();
                if (i == 1000)
                {
                    s4 = Convert.ToString(sw.Elapsed);
                }
                if (i == 10000)
                {
                    s5 = Convert.ToString(sw.Elapsed);
                }
                if (i == 100000)
                {
                    s6 = Convert.ToString(sw.Elapsed);
                }
            }
            sw.Stop();
        }

        public void OptTabl() 
        {
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            string s5 = "";
            string s6 = "";
            konc(100001,ref s1,ref s2,ref s3);
            StringB(100001,ref s4,ref s5,ref s6);
            Console.WriteLine($"       ||        Konc      ||      StringBl    ||\n" +
                              $"1000   || {s1} || {s4} ||\n" +
                              $"10000  || {s2} || {s5} ||\n" +
                              $"100000 || {s3} || {s6} ||\n");
        }
    }
}
