using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHomeWork
{
    internal class FindLetter
    {
        // 문자열 속에 문자 찾기
        // 입력 : pineapple in yummy
        // 출력 : 4
        static void FindLetter_(string[] args)
        {
            Console.Write("문자열을 입력해주세요. : ");
            string sentence = Console.ReadLine();
            Console.Write("찾을 단어를 입력해주세요. : ");
            string word = Console.ReadLine();
            int checkWord = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == word[0])
                {
                    int stringNum = i;
                    for (int j = 0; j < word.Length; i++, j++)
                    {
                        if (sentence[i] != word[j])
                        {
                            checkWord = -1;
                            break;
                        }

                        if (j == word.Length - 1)
                        {
                            checkWord = 0;
                            Console.WriteLine(stringNum);
                            break;
                        }
                    }
                }
            }
            if (checkWord == -1)
                Console.WriteLine(checkWord);
        }

    }
}
