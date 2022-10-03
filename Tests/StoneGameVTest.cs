using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class StoneGameVTest
    {
        [Fact]
        public void Test()
        {
            StoneGameV(new int[] { 6, 2, 3, 4, 5, 5 });
        }

        [Fact]
        public void Test2()
        {
            StoneGameV(new int[] { 7, 7, 7, 7, 7, 7, 7 });
        }

        [Fact]
        public void Test3()
        {
            StoneGameV(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
        }

        public int StoneGameV(int[] stoneValue)
        {
            int score = 0;
            while(stoneValue.Length > 1)
            {
                int halfPoint = stoneValue.Length / 2;
                IEnumerable<int> leftStones = stoneValue.Take(halfPoint);
                IEnumerable<int> rightStones = stoneValue.Skip(halfPoint);

                int leftSum = leftStones.Sum();
                int rightSum = rightStones.Sum();

                if(leftSum > rightSum)
                {
                    score += rightSum;
                    stoneValue = rightStones.ToArray();
                }
                else
                {
                    score += leftSum;
                    stoneValue = leftStones.ToArray();
                }
            }
            return score;
        }
    }
}
/// Divide the array 
/// 7/2 = 3, We will take 3,4 elements