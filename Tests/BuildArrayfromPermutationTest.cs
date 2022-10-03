using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Tests
{
    public class BuildArrayfromPermutationTest
    {
        public int[] BuildArray(int[] nums)
        {
            int[] result =  new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                int index = nums[i];
                result[i] = nums[index];
            }
            return result;
        }
    }
}
