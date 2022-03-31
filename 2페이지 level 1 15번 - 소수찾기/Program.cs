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
            // 모두 false

            for(int i = 2; i < n + 1; i++)
            {
                // 10 입력시 i 2부터 11까지 반복
                if(!arr[i])
                {
                    answer++;
                    for(int j = 0; i * j < n + 1; j++)
                    {
                        // 
                        arr[i * j] = true;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
