using System;
using System.Diagnostics;


namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
           
            static int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            int fib5 =  Fibonachi(5);
            Console.WriteLine($"5 число Фибоначчи = {fib5}, затрачено времени {sw.Elapsed}");
            sw.Stop();
            sw.Restart();
            
            int fib10 = Fibonachi(10);
            Console.WriteLine($"10 число Фибоначчи = {fib10},затрачено времени {sw.Elapsed}");
            sw.Stop();
            sw.Restart();
            
            int fib20 = Fibonachi(20);
            Console.WriteLine($"20 число Фибоначчи = {fib20},затрачено времени {sw.Elapsed}");
            sw.Stop();
            sw.Restart();
            static int Fibonachi2(int n)
            {
                int result = 0;
                int b = 1;
                int tmp;
                for (int i = 0; i < n; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;
                }
                return result;
            }
            int fibonachi5 =  Fibonachi2(5);
            Console.WriteLine($"5 число Фибоначчи = {fibonachi5}, затрачено времени {sw.Elapsed}");
            sw.Stop();
            sw.Restart();
            int fibonachi10 = Fibonachi2(10);
            Console.WriteLine($"10 число Фибоначчи = {fibonachi10},затрачено времени {sw.Elapsed}");
            sw.Stop();
            sw.Restart();
            int fibonachi20 = Fibonachi2(25);
            Console.WriteLine($"20 число Фибоначчи = {fibonachi20},затрачено времени {sw.Elapsed}");
            sw.Stop();
            Console.WriteLine($"20 число Фибоначчи = {fibonachi20},затрачено времени {sw.Elapsed}");
        }
    }
}