namespace GitHubHomeWork
{
    internal class Program
    {
        // 주어진 숫자가 소수인지 판별하는 solution을 완성하라.
        /* static bool IsPrime(int n)
        {} 
        */
        static bool IsPrime(int n)
        {
            if (n == 2)
                return true;
            else if (n % 2 == 0)
                return false;
            for (int i = 3; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("정수를 입력해주세요 : ");
            int inPutNum = int.Parse(Console.ReadLine());



            if (IsPrime(inPutNum) == true)
                Console.WriteLine("{0}은(는) 소수입니다.", inPutNum);
            else
                Console.WriteLine("{0}은(는) 소수가 아닙니다.", inPutNum);
        }

    }
}