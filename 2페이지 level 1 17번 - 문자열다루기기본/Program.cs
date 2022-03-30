using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_17번___문자열다루기기본
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool answer = false;
            string s = Console.ReadLine();
            if(s.Length == 4 || s.Length == 6)
            {
                answer = int.TryParse(s, out int i);
            }
            Console.WriteLine(answer);
        }
    }
}
