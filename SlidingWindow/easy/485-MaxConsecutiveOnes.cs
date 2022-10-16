// https://leetcode.com/problems/max-consecutive-ones/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        var result = 0;
        var maxCount = 0;
        
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] == 1)
            {
                maxCount++;
            }
            
            else
            {
                maxCount = 0;
            }
            
            result = Math.Max(result, maxCount);
        }
        
        return result;
    }
}