using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_20번___두정수사이의합
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            long answer = 0;

            while(a != b)
            {
                answer += a;
                a = (a > b) ? a - 1 : a + 1;
            }
            Console.WriteLine(answer + b);
        }
    }
}
