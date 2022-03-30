using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_18번___문자열내림차순
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            Array.Sort(a);
            Array.Reverse(a);

        }
    }
}
