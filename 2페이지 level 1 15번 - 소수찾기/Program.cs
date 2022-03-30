using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_15번___소수찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 0;
            bool[] arr = new bool[n + 1];

            for(int i = 2; i < n + 1; i++)
            {
                if(!arr[i])
                {
                    answer++;
                    for(int j = 0; i * j < n + 1; j++)
                    {
                        arr[i * j] = true;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
