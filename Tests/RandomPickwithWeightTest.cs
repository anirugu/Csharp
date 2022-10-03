using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class RandomPickwithWeightTest
    {
        public class Solution
        {
            // WIP
            int[] array;
            Random random;
            public Solution(int[] w)
            {
                array = w;
                random = new Random();
            }

            public int PickIndex()
            {
                return random.Next(0, array.Length-1);
            }
        }

    }
}
