using System;

namespace Playground
{
    public class TwoSum
    {
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target) return new int[] { i, j };
                }
            }

            throw new ArgumentException();
        }

        public int[] TwoSumHashAndSearch(int[] nums, int target)
        {
            var map = new System.Collections.Generic.Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }
            throw new ArgumentException("No two sum solution");
        }

        public int[] TwoSumHashOnePass(int[] nums, int target)
        {
            var map = new System.Collections.Generic.Dictionary<int, int>();

            int complement;

            for (int i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}
