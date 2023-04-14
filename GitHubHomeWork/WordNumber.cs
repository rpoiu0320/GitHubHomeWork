using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHomeWork
{
    // 입력 : 안녕하세요. 나는 서울에 사는 홍길동입니다.
    // 출력 : 6
    internal class WordNumber
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력해주세요 : ");
            string writing = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < writing.Length; i++)
            {
                if (writing[i] == ' ')
                    count++;
                else if (i == writing.Length - 1 && writing[i] == '.')
                    count++;
            }
            Console.WriteLine(count);
        }

    }
}
