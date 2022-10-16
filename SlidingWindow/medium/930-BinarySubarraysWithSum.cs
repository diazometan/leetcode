// https://leetcode.com/problems/binary-subarrays-with-sum/

public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        return GetCountOfArraysLessOrEqualGoal(nums, goal) - GetCountOfArraysLessOrEqualGoal(nums, goal - 1);
    }

    public int GetCountOfArraysLessOrEqualGoal(int[] nums, int goal)
    {
        if (goal < 0) return 0;
        
        var res = 0;
        var left = 0;
        
        for (var right = 0; right < nums.Count(); right++)
        {
            goal -= nums[right];
            
            while (goal < 0)
            {
                goal += nums[left];
                left++;
            }
            

            res += right - left + 1;
        }
        
        return res;
    }
}