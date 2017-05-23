using System;

namespace HackerRankAlgorithmsTrack
{
    public class SolveMeFirst
    {
        public void SolveMeFirstMethod()
        {

            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
            Console.ReadLine();


        }

        private int solveMeFirst(int a, int b)
        {
            return a + b;

        }
    }
}
