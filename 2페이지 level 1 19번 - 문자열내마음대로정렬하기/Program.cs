using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_19번___문자열내마음대로정렬하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };
            int n = int.Parse(Console.ReadLine());
            string[] answer = strings.OrderBy(x => x).ToArray();
            answer = answer.OrderBy(x => x[n]).ToArray();

            for(int i = 0; i < answer.Length; i++)
            {
                Console.Write(answer[i] + " ");
            }
        }
    }
}
