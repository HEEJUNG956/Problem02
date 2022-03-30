using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2페이지_level_1_12번___시저암호
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string answer = "";
            char[] temp = s.ToCharArray();
            for(int i = 0; i < s.Length; i++)
            {
                if ((temp[i] >= 'a' && temp[i] <= 'z') || (temp[i] >= 'A' && temp[i] <= 'Z'))
                {
                    if(char.IsUpper(temp[i]))
                    {
                        temp[i] = (char)((temp[i] + n - 'A') % 26 + 'A');
                    }
                    else
                    {
                        temp[i] = (char)((temp[i] + n - 'a') % 26 + 'a');
                    }
                }
            }
            answer = new string(temp);
            Console.WriteLine(answer);
        }
    }
}
