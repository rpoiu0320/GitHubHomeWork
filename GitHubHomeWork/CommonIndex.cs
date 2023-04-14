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
            int[] num1_3 = new int[indexLength];
            int[] num2_1 = new int[indexLength];
            int[] num2_3 = new int[indexLength];
            int[] num3_1 = new int[indexLength];
            int[] num3_2 = new int[indexLength];

            
            
            return num1_2;
        }

        public static int[] IndexOf(int[] firstArray, int[] secondArray)
        {
            int indexLength = firstArray.Length;
            int[] index = { };
            for (int i = 0; i < firstArray.Length; i++)
            {
                int j = 0;
                var check = Array.Exists(firstArray, x => x == secondArray[i]);
                if (check)
                {
                    num1_2[j] = Array.IndexOf(firstArray, secondArray[i]);
                    j++;
                }
            }
            return 
        }
        public static void CommonIndex_()
        {
            int[] arr1 = { 1, 5, 5, 10 };
            int[] arr2 = { 3, 4, 5, 5, 10 };
            int[] arr3 = { 5, 5, 10, 20 };

            int indexLength = arr1.Length;
            if (indexLength < arr2.Length)
                indexLength = arr2.Length;

            if (indexLength < arr3.Length)
                indexLength = arr3.Length;

            Array.Resize(ref arr1, indexLength);
            Array.Resize(ref arr2, indexLength);
            Array.Resize(ref arr3, indexLength);

            FindCommonItems(arr1, arr2, arr3);
        }

        public static void Main()
        {
            CommonIndex_();
        }

    }
}
