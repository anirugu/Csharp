namespace Csharp.Tests
{
    public class TwoSumTest
    {
        [Fact]
        public void Test()
        {
            TwoSum(new int[] { }, 11);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[] { };
            Parallel.For(0, nums.Length, (i) =>
            {
                var c = nums[i];
                Parallel.For(i + 1, nums.Length, (j) =>
                {
                    var cc = nums[j];
                    if (c + cc == target)
                        res = new int[] { i, j };
                });
            });
            return res;
        }
    }
}


