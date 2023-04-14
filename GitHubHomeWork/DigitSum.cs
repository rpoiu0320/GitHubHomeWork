using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHomeWork
{
    /* 사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 solution을 완성하라.
     * static int SumOfDigits(int num) { }
     * 
     * 입출력
     * 입력 : 18234
     * 출력 : 18
     * 
     * 입력 : 3849
     * 출력 : 24
     */
    internal class DigitSum
    {
        static int sumOfDigits(int num)
        {
            string strNum = num.ToString();                     // 자릿수 계산을 위해 string.length를 구하려고 string으로 변환한 변수

            int digit = (int)Math.Pow(10, strNum.Length - 1);   // 자릿수를 기억할 변수
            int sumNum = 0;                                     // 자릿수의 합을 기록할 변수
            int disposableNum;                              // 유기적으로 계산에 사용될 변수

            for (int i = 0; i < strNum.Length; i++)             // 자릿수만큼 반복
            {
                disposableNum = num / digit;                    // 자릿수의 값를 disposableNum 에 기록
                sumNum += disposableNum;                        // 값을 sumNum에 더해줌
                num -= disposableNum * digit;                   // 값을 구한 자릿수를 입력받은 수에서 빼줌

                digit = (int)Math.Pow(10, strNum.Length - (2 + i));     // 자릿수 변경
            }
            return sumNum;
        }
        static void DigitSum(string[] args)
        {
            Console.Write("양의 정수를 입력해주세요 : ");
            uint inPutNum = uint.Parse(Console.ReadLine());     // 양의 정수만 입력받고
            int num = checked((int)inPutNum);                   // uint를 int로 형변환

            num = sumOfDigits(num);
            Console.WriteLine(num);
        }

    }
}
