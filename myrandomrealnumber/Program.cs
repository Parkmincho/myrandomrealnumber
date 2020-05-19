using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int solution = random.Next() % 1000;
            while(true)
            {
                Console.Write("숫자를 입력하세요 : ");
                int input = int.Parse(Console.ReadLine());
                if(solution == input)
                {
                    Console.WriteLine("정답입니다.\n");
                    break;
                }
                else if(solution > input)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.\n");
                }
                else
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.\n");
                }
            }
        }
    }
}
