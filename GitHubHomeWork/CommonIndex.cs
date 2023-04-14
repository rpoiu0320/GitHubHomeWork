using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHomeWork
{
    /* k개의 정렬된 배열에서 공통항목을 찾는 solution을 완성하라. 단, 중복은 허용하지 않는다.
     * 
     * static int[] FindCommomItems(int[] arr1, int[] arr2, int[] arr3) { }
     * 
     * 입력
     * int[] arr1 = { 1, 5, 5, 10 }
     * int[] arr2 = { 3, 4, 5, 5, 10}
     * int[] arr3 = { 5, 5, 10, 20 }
     * 
     * 결과
     * 5, 10
     * */
    internal class CommonIndex
    {
        static int[] FindCommonItems(int[] arr1, int[] arr2, int[] arr3)
        {
            int indexLength = arr1.Length;

            if (indexLength < arr2.Length)
                indexLength = arr2.Length;

            if (indexLength < arr3.Length)
                indexLength = arr3.Length;

            int[] num1_2 = new int[indexLength];
            int[] num2_3 = new int[indexLength];
            int[] num3_1 = new int[indexLength];

            for (int i = 0; i < arr2.Length; i++)
            {
                int j = 0;
                int value = arr2[i];
                if (Array.Exists(arr1, OnIndex => OnIndex == value))
                    num1_2[j] = Array.IndexOf(arr1, arr2[i]);
            }

            return num1_2;
        }
        static void CommonIndex_()
        {
            int[] arr1 = { 1, 5, 5, 10 };
            int[] arr2 = { 3, 4, 5, 5, 10 };
            int[] arr3 = { 5, 5, 10, 20 };


            int indexLength = arr1.Length;
            if (indexLength < arr2.Length)
                indexLength = arr2.Length;

            if (indexLength < arr3.Length)
                indexLength = arr3.Length;

            int[] index = FindCommonItems(arr1, arr2, arr3);

            for(int i = 0; i < indexLength; i++)
            {
                Console.WriteLine(index[i]);
            }
        }

        public static void Main()
        {
            CommonIndex_();
        }

    }
}
