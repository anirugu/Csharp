
using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.Tests
{
    public class SmallestEvenMultipleTest
    {
        [Fact]
        public void Test()
        {
            SmallestEvenMultiple(9);
        }

        public int SmallestEvenMultiple(int n)
        {
            // WIP
            if (n % 2 == 0)
                return n;
            else
            {
                return n * 5;
            }
        }
    }
}

