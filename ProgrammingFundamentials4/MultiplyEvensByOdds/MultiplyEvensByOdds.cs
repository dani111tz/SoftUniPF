using System;

namespace MultiplyEvensByOdds
{
    public class MultiplyEvensByOdds
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            var result = GetMultipleOfOddEvenDigits(num);

            Console.WriteLine(result);


        }

        private static object GetMultipleOfOddEvenDigits(int num)
        {
            var oddSum = SumOddDigits(num);
            var evenSum = SumEvenDigits(num);
            return oddSum * evenSum;

        }

        private static int SumOddDigits(int num)
        {
            int sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 != 0)
                    sum = sum + digit;
                num = num / 10;

            }
            return sum;
        }

        private static int SumEvenDigits(int num)
        {
            int sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var digit = num % 10;
                if (digit % 2 == 0)
                    sum = sum + digit;
                num = num / 10;

            }
            return sum;

        }
    }
}
