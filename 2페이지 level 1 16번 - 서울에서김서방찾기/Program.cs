using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_16번___서울에서김서방찾기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string answer = "";
            string[] seoul = {a, b};
            

            for(int i = 0; i < seoul.Length; i++)
            {
                if(seoul[i] == "kim")
                {
                    answer = "김서방은 " + i + "에 있다";
                }
            }
            Console.WriteLine(answer);
        }
    }
}
