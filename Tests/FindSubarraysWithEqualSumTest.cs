namespace Csharp.Tests
{
    public class FindSubarraysWithEqualSumTest
    {
        public bool FindSubarrays(int[] nums)
        {
            if (nums.Length == 0) return false;
            else
            {
                List<int> sums = new List<int>();
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    var item1 = nums[i];
                    var item2 = nums[i + 1];
                    var total = item1 + item2;
                    if (sums.Contains(total))
                    {
                        return true;
                    }
                    else
                    {
                        sums.Add(total);
                    }
                }

            }
            return false;
        }
    }

}