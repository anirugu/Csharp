using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class ConcatenationofArray
    {
        [Fact]
        public void Run()
        {
            GetConcatenation(new int[] { 1, 2, 3 });
        }

        public int[] GetConcatenation(int[] nums)
        {
            int[] copied = new int[nums.Length * 2];
            Console.WriteLine(nums.Length);
            nums.CopyTo(copied, 0);
            nums.CopyTo(copied, nums.Length);
            return copied;
        }
    }
}
