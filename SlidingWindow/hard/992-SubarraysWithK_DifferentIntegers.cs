// https://leetcode.com/problems/subarrays-with-k-different-integers/

public class Solution {
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return GetCountOfArraysContainLessOrEqualElementThanK(nums, k) - GetCountOfArraysContainLessOrEqualElementThanK(nums, k - 1);
    }
    
    public int GetCountOfArraysContainLessOrEqualElementThanK(int[] nums, int k)
    {
        if (k < 0) return 0;

        var res = 0;
        var left = 0;
        var numbersCount = new Dictionary<int, int>();

        for (var right = 0; right < nums.Count(); right++)
        {
            if (!numbersCount.ContainsKey(nums[right]))
            {
                numbersCount[nums[right]] = 0;
                k--;
            }
            numbersCount[nums[right]] += 1;

            while (k < 0)
            {
                numbersCount[nums[left]] -= 1;
                if (numbersCount[nums[left]] == 0)
                {
                    numbersCount.Remove(nums[left]);
                    k++;                    
                }
                left++;
            }

            res += right - left + 1;
        }

        return res;
    }
}