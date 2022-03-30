using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_14번___수박수박수박수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string answer = "";

            for(int i = 0 ; i < n; i++)
            {
                answer += i % 2 == 0 ? "수" : "박";
            }
            Console.WriteLine(answer);
        }
    }
}
