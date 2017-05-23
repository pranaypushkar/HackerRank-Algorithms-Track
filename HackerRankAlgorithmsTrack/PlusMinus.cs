/*
  *  Author            - PRANAY PUSHKAR
  *  Date              - 23 May 2017
  *  IDE               - Visual Studio 2012
  *  Language          - C#
  *  Problem Statement -  https://www.hackerrank.com/challenges/plus-minus
 */

using System;

namespace HackerRankAlgorithmsTrack
{
    public class PlusMinus
    {
        public void PlusMinusMethod()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll<string, int>(arr_temp, Int32.Parse);

            int positiveCount = 0;
            int zeroCount = 0;
            int negativeCount = 0;

            foreach (int element in arr)
            {
                if (element > 0)
                {
                    positiveCount++;
                }
                else if (element == 0)
                {
                    zeroCount++;
                }
                else if (element < 0)
                {
                    negativeCount++;
                }
            }

            double positveFraction = 0D;
            double negativeFraction = 0D;
            double zeroFraction = 0D;

            positveFraction = (double)positiveCount / n;
            negativeFraction = (double)zeroCount / n;
            zeroFraction = (double)negativeCount / n;

            Console.WriteLine(string.Format("{0:0.000000}", positveFraction));
            Console.WriteLine(string.Format("{0:0.000000}", zeroFraction));
            Console.WriteLine(string.Format("{0:0.000000}", negativeFraction));
            Console.ReadLine();
        }

    }
}
