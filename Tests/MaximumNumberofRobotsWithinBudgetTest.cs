using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class MaximumNumberofRobotsWithinBudgetTest
    {
        [Fact]
        public void Run()
        {
            //TwoSum(new int[] { }, 11);
            //MaximumRobots(new int[] { 3, 6, 1, 3, 4 }, new int[] { 2, 1, 3, 4, 5 }, 25);
            //MaximumRobots(
            //    new int[] { 8, 76, 74, 9, 75, 71, 71, 42, 15, 58, 88, 38, 56, 59, 10, 11 },
            //    new int[] { 1, 92, 41, 63, 22, 37, 37, 8, 68, 97, 39, 59, 45, 50, 29, 37 }, 412);
            MaximumRobots(
                new int[] { 11, 12, 74, 67, 37, 87, 42, 34, 18, 90, 36, 28, 34, 20 },
                new int[] { 18, 98, 2, 84, 7, 57, 54, 65, 59, 91, 7, 23, 94, 20 }, 937);
        }

        public static int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
        {
            int totalBuy = 0;

            List<Test> tests = new List<Test>();

            for (int i = 0; i < chargeTimes.Length; i++)
            {
                tests.Add(new Test(chargeTimes[i], runningCosts[i]));
            }

            var sorted = tests.OrderBy(x => x.ChargeTimes);

            if (chargeTimes == null || chargeTimes.Length == 0) return totalBuy;
            for (int i = 1; i < chargeTimes.Length; i++)
            {
                int cost = sorted.Take(i).Select(x => x.ChargeTimes).Max() + i * sorted.Take(i).Select(y => y.RunningCosts).Sum();
                if (cost > budget)
                    break;
                else
                    totalBuy++;
            }
            return totalBuy;
        }

        class Test
        {
            public Test(int chargeTimes, int runningCosts)
            {
                ChargeTimes = chargeTimes;
                RunningCosts = runningCosts;
            }

            public int ChargeTimes;
            public int RunningCosts;
        }
    }
}
