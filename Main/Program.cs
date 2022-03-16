using System;

namespace Main
{
    internal class Program
    {
        ///1
        static int FoundIndex(string str , char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==ch) return i;
            }
            return -1;
        }

        ///2
        static int Sqrt(int num)
        {
            int i = 1;
            while (true)
            {
                if (i*i>num)
                {
                    return i - 1;
                }
                i++;
            }
            return -1;
        }
        ///3
        static int Sum(int num)
        {
            int sum=0;
            while (num!=0)
            {
                sum = sum + num % 10;
                num /= 10;
            }
            return sum;
        }
        ///4
        static int Max(int[] arr)
        {
            int max=arr[0];
            foreach (var item in arr)
            {
                if (max<item)
                {
                    max = item;
                }
            }
            return max;
        }

        ///5
        static int[] Pos(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) arr[i] = arr[i] * -1;
            }
            return arr;
        }


        static void Main(string[] args)
        {

        }


    }
}
