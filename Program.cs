using DebuggingWork0202_DebWork;
using System.Diagnostics;

namespace DebugNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DebugWorkCalculate debugWorkCalculate = new DebugWorkCalculate();
            debugWorkCalculate.WorkDebug();
        } 
    }
}